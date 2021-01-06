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
    public partial class Main_Frm : Form
    {
        public Action<bool> mAction;
        public Main_Frm()
        {
            InitializeComponent();
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            mAction?.Invoke(true);
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

    }
}
