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
        public Login_Frm()
        {
            InitializeComponent();
        }

        private void closePBox_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void closePBox_MouseHover(object sender, EventArgs e)
        {
            closePBox.BackColor = Color.FromArgb(150, 50, 50);
        }

        private void closePBox_MouseLeave(object sender, EventArgs e)
        {
            closePBox.BackColor = Color.Transparent;
        }
    }
}
