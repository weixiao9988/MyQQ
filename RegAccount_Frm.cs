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
    public partial class RegAccount_Frm : Form
    {
        public Action<bool> mAction;
        public RegAccount_Frm()
        {
            InitializeComponent();
        }

        private void RegAccount_Frm_Load(object sender, EventArgs e)
        {
            mAction?.Invoke(true);
        }

        private void RegAccount_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mAction?.Invoke(false);
        }
    }
}
