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
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private bool mainIsOpen = false;

        public Login_Frm()
        {
            InitializeComponent();
        }

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
            if (!mainIsOpen)
            {
                Main_Frm mainFrm = new Main_Frm();
                mainFrm.mAction = (bl) => mainIsOpen = bl;
                mainFrm.Show();
            }
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

        
    }
}
