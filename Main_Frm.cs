using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Main_Frm()
        {
            InitializeComponent();

            //控制ListVIew的行距和列距
            //70为行距，120为列距（跟图片大小有关）
            PubCls.SendMessage(this.lvFriend.Handle, PubCls.LVM_SETICONAPACING, 0, 0x10000 * 90 + 130);
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            mAction?.Invoke(true);
            ShowInfo();//显示个人信息
            ShowFriendList();//显示好友列表
        }

        ///<summary>
        ///显示个人信息
        ///</summary>
        public void ShowInfo()
        {
            //头像索引
            int headID = 0;
            //获取当前用户的昵称、头像
            string sqlStr= "select NickName, HeadID,Sign from tb_User where ID=" + PubCls.loginID + "";
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
                SignLab.Text = dtRead["Sign"].ToString();
            }
            //关闭读取器
            dtRead.Close();
            dataOprt.CloseCnn();
            //设置窗体标题为当前用户账号
            this.Text = PubCls.loginID.ToString();
            //显示用户头像
            headPBox.Image = imglistHead.Images[headID];
            //显示昵称及账号
            nameLab.Text = nickName + "(" + PubCls.loginID + ")";
        }

        ///<summary>
        ///显示我的好友列表
        ///</summary>
        private void ShowFriendList()
        {
            lvFriend.Items.Clear();
            //定义查找好友的SQL语句
            string sqlStr= "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where " +
                "tb_Friend.HostID=" + PubCls.loginID + " and tb_User.ID=tb_Friend.FriendID";
            SqlDataReader dtRead = dataOprt.GetDataReader(sqlStr);
            //定义变量，用来记录添加到ListView中的项索引
            int i = lvFriend.Items.Count;
            //循环添加好友列表
            while (dtRead.Read())
            {
                strFlag = dtRead["Flag"].ToString() == "0" ? " [离线]" : " [在线]";
                //记录好友昵称
                string strTemp = dtRead["NickName"].ToString();
                //对好友昵称进行处理
                string strFriendName = strTemp.Length < 9 ? strTemp.PadLeft(9, ' ') : (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');

                //向ListView中添加项，Name:好友ID，值：昵称，要显示的头像
                lvFriend.Items.Add(dtRead["FriendID"].ToString(), strTemp + strFlag, (int)dtRead["HeadID"]);
                lvFriend.Alignment = ListViewAlignment.Left;
                lvFriend.Items[i].Group = lvFriend.Groups[0];//设置项的分组为我的好友
                i++;//临时变量加1

            }

        }

        #region
        private void minPBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minPBox_MouseHover(object sender, EventArgs e)
        {
            minPBox.BackColor = Color.FromArgb(100, 100, 200);
        }

        private void minPBox_MouseLeave(object sender, EventArgs e)
        {
            minPBox.BackColor = Color.Transparent;
        }

        private void closePBox_MouseClick(object sender, MouseEventArgs e)
        {
            Application.ExitThread();//退出当前应用程序
        }

        private void closePBox_MouseHover(object sender, EventArgs e)
        {
            closePBox.BackColor = Color.FromArgb(200, 50, 50);
        }

        private void closePBox_MouseLeave(object sender, EventArgs e)
        {
            closePBox.BackColor = Color.Transparent;
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

        private void lvFrend_MouseDown(object sender, MouseEventArgs e)
        {
            //用来释放被当前线程中某个窗口捕获的光标
            PubCls.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            PubCls.SendMessage(this.Handle, PubCls.WM_SYSCOMMAND, PubCls.SC_MOVE + PubCls.HTCAPTION, 0);
            
        }

        private void SignLab_MouseHover(object sender, EventArgs e)
        {
            SignLab.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SignLab_MouseLeave(object sender, EventArgs e)
        {
            SignLab.BorderStyle = BorderStyle.None;
        }

        private void SignLab_MouseClick(object sender, MouseEventArgs e)
        {
            SignLab.Visible = false;
            SignTBox.Text = SignLab.Text;
            SignTBox.Visible = true;
            SignTBox.Select();
        }

        private void SignTBox_Leave(object sender, EventArgs e)
        {
            SignLab.Text = SignTBox.Text;
            SignTBox.Visible = false;
            SignLab.Visible = true;

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

        }

        private void tbBtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();//退出当前应用程序
        }



    }
}
