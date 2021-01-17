using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace MyQQ
{
    public partial class Main_Frm : Form
    {
        public Action<bool> mAction;
        int fromUserID;//消息发送者
        int friendHeadID;  //发消息好友的头像ID  
        int messageImageIndex = 0; //工具栏中的消息图标的索引
        public static string nickName = "";//自己的昵称
        public static string strFlag = "[离线]";
        DataOperator dataOprt = new DataOperator();//创建数据操作类的对象
        private Timer msgTim, addFriendTim, chatTim;
        private Chat_Frm chatFrm;

        public Main_Frm()
        {
            InitializeComponent();

            //控制ListVIew的行距和列距
            //70为行距，120为列距（跟图片大小有关）
            PubCls.SendMessage(this.friendLv.Handle, PubCls.LVM_SETICONAPACING, 0, 0x10000 * 70 + 130);
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            mAction?.Invoke(true);
            ShowInfo();//显示个人信息
            ShowFriendList();//显示好友列表

            //未读消息的定时器 
            msgTim = new Timer();
            msgTim.Interval = 2000;
            msgTim.Enabled = true;
            msgTim.Tick += MsgTim_Tick;

            //消息提醒定时器
            addFriendTim = new Timer();
            addFriendTim.Interval = 1000;
            addFriendTim.Tick += AddFriendTim_Tick;

            //聊天定时器
            chatTim = new Timer();
            chatTim.Interval = 500;
            chatTim.Tick += ChatTim_Tick;
        }

        /// 实时获取未读消息的定时器        
        private void MsgTim_Tick(object sender, EventArgs e)
        {
            //获取鼠标在屏幕的坐标点
            Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);
            //存储当前窗体在屏幕的所在区域
            Rectangle rect = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);
            //当鼠标在当前窗体内，并且窗体的Top属性小于0
            if (this.Top < 0 && PubCls.PtInRect(ref rect, pp))
                this.Top = 0;
            else
                if (this.Top > -5 && this.Top < 5 && !PubCls.PtInRect(ref rect, pp))    //当窗体的上边框与屏幕的顶端的距离小于5时
                    this.Top = 5 - this.Height;     //将QQ窗体隐藏到屏幕的顶端

            JudgeSelected();

            int messageTypeID = 1;//消息类型
            int messageState = 1;//消息状态
            //查找未读消息对应的好友ID
            string sqlStr = "select top 1 FromUserID, MessageTypeID, MessageState from tb_Message where ToUserID=" + PubCls.loginID + " and MessageState=0";
            SqlDataReader dataReader = dataOprt.GetDataReader(sqlStr);
            //读取未读消息
            if (dataReader.Read())
            {
                fromUserID = (int)dataReader["FromUserID"];//记录消息发送者
                messageTypeID = (int)dataReader["MessageTypeID"]; //记录消息类型
                messageState = (int)dataReader["MessageState"]; //记录消息状态
            }
            dataReader.Close();
            dataOprt.CloseCnn();
            //消息有两种类型：聊天消息、添加好友消息
            //判断消息类型，如果是添加好友消息，启动消息提醒定时器
            if (messageTypeID == 2 && messageState == 0) 
            {
                SoundPlayer player = new SoundPlayer("system.wav");
                player.Play();
                addFriendTim.Start();
            }
            else if (messageTypeID == 1 && messageState == 0)   //如果是聊天消息，启动聊天定时器，使好友头像闪烁
            {
                //获取消息发送者的ID
                sqlStr = "select HeadID from tb_User where ID=" + fromUserID;
                friendHeadID = dataOprt.ExecSQL(sqlStr);    //设置发消息好友的头像ID
                //如果发消息的人不在好友列表中，将其添加到陌生人列表中
                if(!HasShowUser(fromUserID))
                    UpdateStranger(fromUserID);//显示陌生人列表
                SoundPlayer player = new SoundPlayer("msg.wav");//聊天消息提示
                player.Play();//播放指定声音文件
                chatTim.Start();    //启动聊天定时器
            }
        }

        private void AddFriendTim_Tick(object sender, EventArgs e)
        {
            //实时获取系统消息图像索引
            messageImageIndex = messageImageIndex == 0 ? 1 : 0;
            //工具栏中显示消息读取状态图像
            tbBtnSysMsg.Image = imglistMessage.Images[messageImageIndex];
        }

        //聊天定时器
        private void ChatTim_Tick(object sender, EventArgs e)
        {
            //循环好友列表两个组中的每项，找到消息发送者，使其头像闪烁
            for (int i = 0; i < 2; i++)
            {
                foreach (ListViewItem item in friendLv.Groups[i].Items)
                {
                    //判断是否为消息发送者
                    if (item.Name==fromUserID.ToString())
                    {
                        if (chatFrm != null && chatFrm.friendID != 0)
                        {
                            //直接显示头像，避免闪烁效果
                            friendLv.SelectedItems[0].ImageIndex = friendHeadID;
                        }
                        else
                        {
                            //索引为100的图片是一个空白图片，为了实现闪烁效果
                            item.ImageIndex = item.ImageIndex < 100 ? 100 : friendHeadID;
                        }
                    }
                }
            }
        }

        private void JudgeSelected()
        {
            //判断好友列表中有选中项
            if (friendLv.SelectedItems.Count > 0)
            {
                if (friendLv.SelectedItems[0].Group == friendLv.Groups[0])    //如果选中项属于第1组
                {
                    bool[] bl = { true, true, false, true };
                    CtrlTsMenuEnabled(friendListCms, bl);
                }
                else if (friendLv.SelectedItems[0].Group == friendLv.Groups[1])
                {
                    bool[] bl = { true, true, false, false };
                    CtrlTsMenuEnabled(friendListCms, bl);
                }
            }
            else
            {
                bool[] bl = { false, true, true, false };
                CtrlTsMenuEnabled(friendListCms, bl);
            }
        }

        /// <summary>
        /// 控制控件的可用状态
        /// </summary>
        /// <param name="ctrl">控件</param>
        /// <param name="bArry">可用状态标志</param>
        private void CtrlTsMenuEnabled(ContextMenuStrip ctrl, bool[] bArry)
        {
            for (int i = 0; i < ctrl.Items.Count; i++)
                ctrl.Items[i].Enabled = bArry[i];
        }

        /// <summary>
        /// 判断发消息的用户是否在列表中
        /// </summary>
        /// <param name="ID">指定用户的ID</param>
        /// <returns>在列表中，返回true，否则为false</returns>
        private bool HasShowUser(int ID)
        {
            //是否在当前显示出的用户列表中找到了该用户
            bool find = false;
            //循环friendLv中的2个组，寻找发消息的人是否在列表中
            for (int i = 0; i < 2; i++)
            {
                foreach (ListViewItem item in friendLv.Groups[i].Items)
                    if (item.Name == ID.ToString())
                        find = true;
            }
            return find;
        }

        ///<summary>
        ///显示个人信息
        ///</summary>
        public void ShowInfo()
        {
            //头像索引
            int headID = 0;
            //获取当前用户的昵称、头像
            string sqlStr = "select NickName, HeadID,Sign from tb_User where ID=" + PubCls.loginID + "";
            SqlDataReader dtRead = dataOprt.GetDataReader(sqlStr);
            //读取查询结果
            if (dtRead.Read())
            {
                //判断NickName不为空
                if (!(dtRead["NickName"] is DBNull))
                    nickName = dtRead["NickName"].ToString();   //记录自己的昵称

                //记录自己的头像ID
                headID = Convert.ToInt32(dtRead["HeadID"]);
                //显示个性签名
                signLab.Text = dtRead["Sign"].ToString();
            }
            //关闭读取器
            dtRead.Close();
            dataOprt.CloseCnn();
            //设置窗体标题为当前用户账号
            this.Text = PubCls.loginID.ToString();
            //显示用户头像
            headPBox.Image = listHeadImg.Images[headID];
            //显示昵称及账号
            nameLab.Text = nickName + "(" + PubCls.loginID + ")";
        }

        ///<summary>
        ///显示我的好友列表
        ///</summary>
        private void ShowFriendList()
        {
            friendLv.Items.Clear();
            //定义查找好友的SQL语句
            string sqlStr= "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where " +
                "tb_Friend.HostID=" + PubCls.loginID + " and tb_User.ID=tb_Friend.FriendID";
            SqlDataReader dtRead = dataOprt.GetDataReader(sqlStr);            
            //定义变量，用来记录添加到ListView中的项索引
            int i = friendLv.Items.Count;

            friendLv.BeginUpdate();
            //循环添加好友列表
            while (dtRead.Read())
            {
                ListViewItem lvi = new ListViewItem();
                strFlag = dtRead["Flag"].ToString() == "0" ? " [离线]" : " [在线]";
                //记录好友昵称
                string strTemp = dtRead["NickName"].ToString();

                lvi.ImageIndex = (int)dtRead["HeadID"];
                lvi.Text = dtRead["FriendID"].ToString() + " " + strTemp + strFlag;
                friendLv.Items.Add(lvi);

                ////对好友昵称进行处理
                //string strFriendName = strTemp.Length < 9 ? strTemp.PadLeft(9, ' ') : (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                                
                friendLv.Items[i].Group = friendLv.Groups[0];//设置项的分组为我的好友
                i++;//临时变量加1
            }
            friendLv.EndUpdate();
            dtRead.Close();
            dataOprt.CloseCnn();
        }

        /// <summary>
        /// 显示陌生人列表
        /// </summary>
        /// <param name="ID">指定用户的ID</param>
        private void UpdateStranger(int ID)
        {
            friendLv.Items.Clear();//清空原来的列表
            //获取指定用户的昵称及头像ID
            string sqlStr= "select NickName, HeadID from tb_User where ID=" + ID;
            SqlDataReader dataReader = dataOprt.GetDataReader(sqlStr);
            int i = friendLv.Items.Count;//定义变量，用来记录添加到ListView中的项索引
            friendLv.BeginUpdate();
            while (dataReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                string strName = dataReader["NickName"].ToString();
                lvi.ImageIndex = (int)dataReader["HeadID"];
                lvi.Text = fromUserID.ToString()+strName;
                friendLv.Items.Add(lvi);
                //设置项的分组为陌生人
                friendLv.Items[i].Group = friendLv.Groups[1];
                i++;
            }
            friendLv.EndUpdate();
            dataReader.Close();
            dataOprt.CloseCnn();
        }

        #region

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMin_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Main_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mAction?.Invoke(false);
        }
        #endregion

        #region
        /// <summary>
        /// 窗体移动、拉升
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 0x10;
            const int HTBOTTOMRIGHT = 17;

            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0xA3://禁止双击最大化
                    break;
                case 0x084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息 
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
                    m.LParam = IntPtr.Zero;//默认值 
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内 
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
               
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //用来释放被当前线程中某个窗口捕获的光标
            PubCls.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            PubCls.SendMessage(this.Handle, PubCls.WM_SYSCOMMAND, PubCls.SC_MOVE + PubCls.HTCAPTION, 0);
        }

        private void friendLv_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right )
            //{
            //    //textBox1.Text = (e.X+this.Left).ToString() + "_" + (e.Y+this.Top).ToString();

            //    int x0 = e.X + this.Left + 10;
            //    int y0 = e.Y + this.Top + friendLv.Top;
            //    friendListCms.Show(new Point(x0, y0));
            //}
        }

        private void frendLv_MouseDown(object sender, MouseEventArgs e)
        {            
            //用来释放被当前线程中某个窗口捕获的光标
            PubCls.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            PubCls.SendMessage(this.Handle, PubCls.WM_SYSCOMMAND, PubCls.SC_MOVE + PubCls.HTCAPTION, 0);
            
        }

        private void SignLab_MouseHover(object sender, EventArgs e)
        {
            signLab.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SignLab_MouseLeave(object sender, EventArgs e)
        {
            signLab.BorderStyle = BorderStyle.None;
        }

        private void SignLab_MouseClick(object sender, MouseEventArgs e)
        {
            signLab.Visible = false;
            signTBox.Text = signLab.Text;
            signTBox.Visible = true;
            signTBox.Select();
        }

        private void SignTBox_Leave(object sender, EventArgs e)
        {
            signLab.Text = signTBox.Text;
            signTBox.Visible = false;
            signLab.Visible = true;

        }





        #endregion

        private void tbBtnInfo_Click(object sender, EventArgs e)
        {
            EditInfo_Frm infoSetFrm = new EditInfo_Frm();
            infoSetFrm.UpInfoEvt += ShowInfo;
            infoSetFrm.Show();
        }

        private void tbBtnSearch_Click(object sender, EventArgs e)
        {
            AddFriend_Frm addFriendFrm = new AddFriend_Frm();
            addFriendFrm.Show();
        }

        private void tbBtnUpFriend_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void tbBtnSysMsg_Click(object sender, EventArgs e)
        {
            addFriendTim.Stop();    //停止消息提醒定时器
            messageImageIndex = 0;//头像恢复正常
            //显示正常的系统消息提醒图标
            tbBtnSysMsg.Image = imglistMessage.Images[messageImageIndex];
            Remind_Frm remindFrm = new Remind_Frm();//创建系统消息窗体对象
            remindFrm.Show();//显示系统消息窗体
        }

        private void tbBtnExit_Click(object sender, EventArgs e)
        {
            //弹出确定对话框
            DialogResult result = MessageBox.Show("确实要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
                Application.ExitThread();//退出当前应用程序
        }

        //显示个人信息
        private void tsMenuShowInfo_Click(object sender, EventArgs e)
        {
            tbBtnInfo_Click(sender, e);
        }

        //大、小头像视图切换
        private void tsMenuSHead_Click(object sender, EventArgs e)
        {
            friendLv.View = friendLv.View == View.Tile ? View.SmallIcon : View.Tile;
            tsMenuSHead.Text = friendLv.View == View.Tile ? "小头像" : "大头像";
        }

        

        //添加好友 
        private void tsMenuAdd_Click(object sender, EventArgs e)
        {

        }

        private void tsMenuDel_Click(object sender, EventArgs e)
        {

        }

        


        
    }
}
