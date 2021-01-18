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
    public partial class EditInfo_Frm : Form
    {
        public delegate void UpInfoDlgt();
        public event UpInfoDlgt UpInfoEvt;
        private DataOperator dataOperator = new DataOperator();

        public EditInfo_Frm()
        {
            InitializeComponent();
        }

        private void EditInfo_Frm_Load(object sender, EventArgs e)
        {

        }

        private void ShowHead(int headID)
        {
            headPBox.Image = imglistHead.Images[headID];
            headPBox.Tag = headID;
        }

        private void chgHeadBtn_Click(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            UpInfoEvt();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
