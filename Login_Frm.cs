using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Login_Frm : Form
    {
        DataOperator dataOprt = new DataOperator();//创建数据操作类的对象
        private bool mainIsOpen = false;
        private bool regFrmOpen = false;

        public Login_Frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 验证用户输入
        /// </summary>
        /// <returns>验证成功，返回true，否则返回false</returns>
        private bool ValidateInput()
        {
            //登录账号
            if (userIDCBox.Text=="")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userIDCBox.Focus();     //使登录账号文本框获得鼠标焦点
                return false;
            }
            else if (userPWDTBox.Text.Trim()=="")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userPWDTBox.Focus();//使密码文本框获得鼠标焦点
                return false;
            }

            return true;
        }

        private void userIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidateInput();
            //根据号码查询其密码、记住密码和自动登录字段的值
            string sqlStr = "select Pwd,Remember,AutoLogin from tb_User where ID=" + int.Parse(userIDCBox.Text.Trim());
            DataSet ds = dataOprt.GetDataSet(sqlStr);       //查询结果存储到数据集中
            if (ds.Tables[0].Rows.Count > 0)       //判断是否存在该用户
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)    //判断是否记住密码
                {
                    recordPwdChkBox.Checked = true;     //记录密码复选框选中
                    userPWDTBox.Text = ds.Tables[0].Rows[0][0].ToString();      //自动输入密码
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)    //判断是否自动登录
                    {
                        autoLoginChkBox.Checked = true;
                        loginBtn_Click(sender, e);
                    }
                }
            }
        }

        /// <summary>
        /// 判断输入密码后是否按下回车键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPWDTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                loginBtn_Click(sender, e);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //定义查询SQL语句
                string sqlStr = "select count(*) from tb_User where ID=" + int.Parse(userIDCBox.Text.Trim()) + " and Pwd = '" + userPWDTBox.Text.Trim() + "'";
                
                int num = dataOprt.ExecSQL(sqlStr);
                if (num == 1)     //验证通过
                {
                    PubCls.loginID = int.Parse(userIDCBox.Text.Trim());     //设置登录的用户号码
                    if (recordPwdChkBox.Checked)
                    {
                        //记住密码                        
                        dataOprt.ExecSQLResult("update tb_User set Remember=1 where ID=" + int.Parse(userIDCBox.Text.Trim()));
                        //自动登录
                        if (autoLoginChkBox.Checked)
                            dataOprt.ExecSQLResult("update tb_User set AutoLogin=1 where ID=" +
                                int.Parse(userIDCBox.Text.Trim()));
                    }
                    else
                    {
                        dataOprt.ExecSQLResult("update tb_User set Remember=0 where ID=" +
                            int.Parse(userIDCBox.Text.Trim()));
                        dataOprt.ExecSQLResult("update tb_User set AutoLogin=0 where ID=" +
                            int.Parse(userIDCBox.Text.Trim()));
                    }

                    dataOprt.ExecSQLResult("update tb_User set Flag=1 where ID=" +
                            int.Parse(userIDCBox.Text.Trim()));
                    if (!mainIsOpen)
                    {
                        Main_Frm mainFrm = new Main_Frm();
                        mainFrm.mAction = (bl) => mainIsOpen = bl;
                        mainFrm.Show();
                    }
                    this.Visible = false;
                }
                else
                    MessageBox.Show("输入的用户名或密码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (!mainIsOpen)
            //{
            //    Main_Frm mainFrm = new Main_Frm();
            //    mainFrm.mAction = (bl) => mainIsOpen = bl;
            //    mainFrm.Show();
            //}
        }

      
        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84://鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x01)
                    {
                        m.Result = new IntPtr(0x02);
                    }
                    break;
                case 0xA3://禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void recordPwdChkBox_CheckedChanged(object sender, EventArgs e)
        {            
            if (!recordPwdChkBox.Checked)                //判断记住密码文本框是否为未选中状态
                autoLoginChkBox.Checked = false;      //自动登录设置为未选中
        }

        private void regLab_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                if (!regFrmOpen)
                {
                    RegAccount_Frm regFrm = new RegAccount_Frm();
                    regFrm.mAction = (bl) => regFrmOpen = bl;
                    regFrm.Show();
                }
                
            }            
        }

        private void findPwdLab_Click(object sender, EventArgs e)
        {

        }

        private void Login_Frm_Load(object sender, EventArgs e)
        {
            userIDCBox.Items.Add(14020);
            userIDCBox.Items.Add(10004);
            userIDCBox.SelectedIndex = 1;
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMin_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
