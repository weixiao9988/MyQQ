
namespace MyQQ
{
    partial class Main_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("我的好友", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("陌生人", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Frm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.minPBox = new System.Windows.Forms.PictureBox();
            this.closePBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.nameLab = new System.Windows.Forms.Label();
            this.signLab = new System.Windows.Forms.Label();
            this.signTBox = new System.Windows.Forms.TextBox();
            this.headPBox = new System.Windows.Forms.PictureBox();
            this.friendLv = new System.Windows.Forms.ListView();
            this.listHeadImg = new System.Windows.Forms.ImageList(this.components);
            this.listSmallHeadImg = new System.Windows.Forms.ImageList(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tbBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tbBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tbBtnUpFriend = new System.Windows.Forms.ToolStripButton();
            this.tbBtnSysMsg = new System.Windows.Forms.ToolStripButton();
            this.tbBtnExit = new System.Windows.Forms.ToolStripButton();
            this.friendListCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPBox)).BeginInit();
            this.toolBar.SuspendLayout();
            this.friendListCms.SuspendLayout();
            this.SuspendLayout();
            // 
            // minPBox
            // 
            this.minPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minPBox.BackgroundImage = global::MyQQ.Properties.Resources.min;
            this.minPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minPBox.Location = new System.Drawing.Point(250, 0);
            this.minPBox.Margin = new System.Windows.Forms.Padding(0);
            this.minPBox.Name = "minPBox";
            this.minPBox.Size = new System.Drawing.Size(28, 28);
            this.minPBox.TabIndex = 3;
            this.minPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.minPBox, "最小化");
            this.minPBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minPBox_MouseClick);
            this.minPBox.MouseLeave += new System.EventHandler(this.minPBox_MouseLeave);
            this.minPBox.MouseHover += new System.EventHandler(this.minPBox_MouseHover);
            // 
            // closePBox
            // 
            this.closePBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePBox.BackgroundImage = global::MyQQ.Properties.Resources.close;
            this.closePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePBox.Location = new System.Drawing.Point(280, 0);
            this.closePBox.Margin = new System.Windows.Forms.Padding(0);
            this.closePBox.Name = "closePBox";
            this.closePBox.Size = new System.Drawing.Size(28, 28);
            this.closePBox.TabIndex = 2;
            this.closePBox.TabStop = false;
            this.toolTip1.SetToolTip(this.closePBox, "关闭");
            this.closePBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closePBox_MouseClick);
            this.closePBox.MouseLeave += new System.EventHandler(this.closePBox_MouseLeave);
            this.closePBox.MouseHover += new System.EventHandler(this.closePBox_MouseHover);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.topPanel.Controls.Add(this.textBox1);
            this.topPanel.Controls.Add(this.nameLab);
            this.topPanel.Controls.Add(this.signLab);
            this.topPanel.Controls.Add(this.signTBox);
            this.topPanel.Controls.Add(this.headPBox);
            this.topPanel.Controls.Add(this.minPBox);
            this.topPanel.Controls.Add(this.closePBox);
            this.topPanel.Location = new System.Drawing.Point(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(308, 135);
            this.topPanel.TabIndex = 4;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLab.ForeColor = System.Drawing.Color.FloralWhite;
            this.nameLab.Location = new System.Drawing.Point(74, 59);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(51, 19);
            this.nameLab.TabIndex = 7;
            this.nameLab.Text = "label1";
            // 
            // signLab
            // 
            this.signLab.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signLab.Location = new System.Drawing.Point(76, 90);
            this.signLab.Name = "signLab";
            this.signLab.Size = new System.Drawing.Size(219, 23);
            this.signLab.TabIndex = 6;
            this.signLab.Text = "label1";
            this.signLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignLab_MouseClick);
            this.signLab.MouseLeave += new System.EventHandler(this.SignLab_MouseLeave);
            this.signLab.MouseHover += new System.EventHandler(this.SignLab_MouseHover);
            // 
            // signTBox
            // 
            this.signTBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signTBox.Location = new System.Drawing.Point(77, 90);
            this.signTBox.Name = "signTBox";
            this.signTBox.Size = new System.Drawing.Size(218, 23);
            this.signTBox.TabIndex = 5;
            this.signTBox.Visible = false;
            this.signTBox.LostFocus += new System.EventHandler(this.SignTBox_Leave);
            // 
            // headPBox
            // 
            this.headPBox.Location = new System.Drawing.Point(4, 61);
            this.headPBox.Name = "headPBox";
            this.headPBox.Size = new System.Drawing.Size(66, 66);
            this.headPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headPBox.TabIndex = 4;
            this.headPBox.TabStop = false;
            // 
            // friendLv
            // 
            this.friendLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendLv.AutoArrange = false;
            this.friendLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            listViewGroup3.Header = "我的好友";
            listViewGroup3.Name = "lvGroupFriend";
            listViewGroup4.Header = "陌生人";
            listViewGroup4.Name = "lvGroupStranger";
            this.friendLv.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.friendLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.friendLv.HideSelection = false;
            this.friendLv.LargeImageList = this.listHeadImg;
            this.friendLv.Location = new System.Drawing.Point(1, 137);
            this.friendLv.MultiSelect = false;
            this.friendLv.Name = "friendLv";
            this.friendLv.Size = new System.Drawing.Size(308, 368);
            this.friendLv.SmallImageList = this.listSmallHeadImg;
            this.friendLv.StateImageList = this.listSmallHeadImg;
            this.friendLv.TabIndex = 5;
            this.friendLv.UseCompatibleStateImageBehavior = false;
            this.friendLv.View = System.Windows.Forms.View.Tile;
            this.friendLv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.friendLv_MouseClick);
            this.friendLv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frendLv_MouseDown);
            // 
            // listHeadImg
            // 
            this.listHeadImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listHeadImg.ImageStream")));
            this.listHeadImg.TransparentColor = System.Drawing.Color.Empty;
            this.listHeadImg.Images.SetKeyName(0, "1.bmp");
            this.listHeadImg.Images.SetKeyName(1, "2.bmp");
            this.listHeadImg.Images.SetKeyName(2, "3.bmp");
            this.listHeadImg.Images.SetKeyName(3, "4.bmp");
            this.listHeadImg.Images.SetKeyName(4, "5.bmp");
            this.listHeadImg.Images.SetKeyName(5, "6.bmp");
            this.listHeadImg.Images.SetKeyName(6, "7.bmp");
            this.listHeadImg.Images.SetKeyName(7, "8.bmp");
            this.listHeadImg.Images.SetKeyName(8, "9.bmp");
            this.listHeadImg.Images.SetKeyName(9, "10.bmp");
            this.listHeadImg.Images.SetKeyName(10, "11.bmp");
            this.listHeadImg.Images.SetKeyName(11, "12.bmp");
            this.listHeadImg.Images.SetKeyName(12, "13.bmp");
            this.listHeadImg.Images.SetKeyName(13, "14.bmp");
            this.listHeadImg.Images.SetKeyName(14, "15.bmp");
            this.listHeadImg.Images.SetKeyName(15, "16.bmp");
            this.listHeadImg.Images.SetKeyName(16, "17.bmp");
            this.listHeadImg.Images.SetKeyName(17, "18.bmp");
            this.listHeadImg.Images.SetKeyName(18, "19.bmp");
            this.listHeadImg.Images.SetKeyName(19, "20.bmp");
            this.listHeadImg.Images.SetKeyName(20, "21.bmp");
            this.listHeadImg.Images.SetKeyName(21, "22.bmp");
            this.listHeadImg.Images.SetKeyName(22, "23.bmp");
            this.listHeadImg.Images.SetKeyName(23, "24.bmp");
            this.listHeadImg.Images.SetKeyName(24, "25.bmp");
            this.listHeadImg.Images.SetKeyName(25, "26.bmp");
            this.listHeadImg.Images.SetKeyName(26, "27.bmp");
            this.listHeadImg.Images.SetKeyName(27, "28.bmp");
            this.listHeadImg.Images.SetKeyName(28, "29.bmp");
            this.listHeadImg.Images.SetKeyName(29, "30.bmp");
            this.listHeadImg.Images.SetKeyName(30, "31.bmp");
            this.listHeadImg.Images.SetKeyName(31, "32.bmp");
            this.listHeadImg.Images.SetKeyName(32, "33.bmp");
            this.listHeadImg.Images.SetKeyName(33, "34.bmp");
            this.listHeadImg.Images.SetKeyName(34, "35.bmp");
            this.listHeadImg.Images.SetKeyName(35, "36.bmp");
            this.listHeadImg.Images.SetKeyName(36, "37.bmp");
            this.listHeadImg.Images.SetKeyName(37, "38.bmp");
            this.listHeadImg.Images.SetKeyName(38, "39.bmp");
            this.listHeadImg.Images.SetKeyName(39, "40.bmp");
            this.listHeadImg.Images.SetKeyName(40, "41.bmp");
            this.listHeadImg.Images.SetKeyName(41, "42.bmp");
            this.listHeadImg.Images.SetKeyName(42, "43.bmp");
            this.listHeadImg.Images.SetKeyName(43, "44.bmp");
            this.listHeadImg.Images.SetKeyName(44, "45.bmp");
            this.listHeadImg.Images.SetKeyName(45, "46.bmp");
            this.listHeadImg.Images.SetKeyName(46, "47.bmp");
            this.listHeadImg.Images.SetKeyName(47, "48.bmp");
            this.listHeadImg.Images.SetKeyName(48, "49.bmp");
            this.listHeadImg.Images.SetKeyName(49, "50.bmp");
            this.listHeadImg.Images.SetKeyName(50, "51.bmp");
            this.listHeadImg.Images.SetKeyName(51, "52.bmp");
            this.listHeadImg.Images.SetKeyName(52, "53.bmp");
            this.listHeadImg.Images.SetKeyName(53, "54.bmp");
            this.listHeadImg.Images.SetKeyName(54, "55.bmp");
            this.listHeadImg.Images.SetKeyName(55, "56.bmp");
            this.listHeadImg.Images.SetKeyName(56, "57.bmp");
            this.listHeadImg.Images.SetKeyName(57, "58.bmp");
            this.listHeadImg.Images.SetKeyName(58, "59.bmp");
            this.listHeadImg.Images.SetKeyName(59, "60.bmp");
            this.listHeadImg.Images.SetKeyName(60, "61.bmp");
            this.listHeadImg.Images.SetKeyName(61, "62.bmp");
            this.listHeadImg.Images.SetKeyName(62, "63.bmp");
            this.listHeadImg.Images.SetKeyName(63, "64.bmp");
            this.listHeadImg.Images.SetKeyName(64, "65.bmp");
            this.listHeadImg.Images.SetKeyName(65, "66.bmp");
            this.listHeadImg.Images.SetKeyName(66, "67.bmp");
            this.listHeadImg.Images.SetKeyName(67, "68.bmp");
            this.listHeadImg.Images.SetKeyName(68, "69.bmp");
            this.listHeadImg.Images.SetKeyName(69, "70.bmp");
            this.listHeadImg.Images.SetKeyName(70, "71.bmp");
            this.listHeadImg.Images.SetKeyName(71, "72.bmp");
            this.listHeadImg.Images.SetKeyName(72, "73.bmp");
            this.listHeadImg.Images.SetKeyName(73, "74.bmp");
            this.listHeadImg.Images.SetKeyName(74, "75.bmp");
            this.listHeadImg.Images.SetKeyName(75, "76.bmp");
            this.listHeadImg.Images.SetKeyName(76, "77.bmp");
            this.listHeadImg.Images.SetKeyName(77, "78.bmp");
            this.listHeadImg.Images.SetKeyName(78, "79.bmp");
            this.listHeadImg.Images.SetKeyName(79, "80.bmp");
            this.listHeadImg.Images.SetKeyName(80, "81.bmp");
            this.listHeadImg.Images.SetKeyName(81, "82.bmp");
            this.listHeadImg.Images.SetKeyName(82, "83.bmp");
            this.listHeadImg.Images.SetKeyName(83, "84.bmp");
            this.listHeadImg.Images.SetKeyName(84, "85.bmp");
            this.listHeadImg.Images.SetKeyName(85, "86.bmp");
            this.listHeadImg.Images.SetKeyName(86, "87.bmp");
            this.listHeadImg.Images.SetKeyName(87, "88.bmp");
            this.listHeadImg.Images.SetKeyName(88, "89.bmp");
            this.listHeadImg.Images.SetKeyName(89, "90.bmp");
            this.listHeadImg.Images.SetKeyName(90, "91.bmp");
            this.listHeadImg.Images.SetKeyName(91, "92.bmp");
            this.listHeadImg.Images.SetKeyName(92, "93.bmp");
            this.listHeadImg.Images.SetKeyName(93, "94.bmp");
            this.listHeadImg.Images.SetKeyName(94, "95.bmp");
            this.listHeadImg.Images.SetKeyName(95, "96.bmp");
            this.listHeadImg.Images.SetKeyName(96, "97.bmp");
            this.listHeadImg.Images.SetKeyName(97, "98.bmp");
            this.listHeadImg.Images.SetKeyName(98, "99.bmp");
            this.listHeadImg.Images.SetKeyName(99, "100.bmp");
            this.listHeadImg.Images.SetKeyName(100, "back.bmp");
            // 
            // listSmallHeadImg
            // 
            this.listSmallHeadImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listSmallHeadImg.ImageStream")));
            this.listSmallHeadImg.TransparentColor = System.Drawing.Color.Transparent;
            this.listSmallHeadImg.Images.SetKeyName(0, "1-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(1, "2-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(2, "3-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(3, "4-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(4, "5-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(5, "6-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(6, "7-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(7, "8-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(8, "9-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(9, "10-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(10, "11-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(11, "12-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(12, "13-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(13, "14-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(14, "15-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(15, "16-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(16, "17-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(17, "18-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(18, "19-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(19, "20-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(20, "21-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(21, "22-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(22, "23-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(23, "24-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(24, "25-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(25, "26-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(26, "27-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(27, "28-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(28, "29-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(29, "30-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(30, "31-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(31, "32-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(32, "33-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(33, "34-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(34, "35-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(35, "36-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(36, "37-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(37, "38-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(38, "39-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(39, "40-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(40, "41-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(41, "42-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(42, "43-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(43, "44-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(44, "45-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(45, "46-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(46, "47-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(47, "48-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(48, "49-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(49, "50-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(50, "51-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(51, "52-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(52, "53-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(53, "54-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(54, "55-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(55, "56-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(56, "57-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(57, "58-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(58, "59-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(59, "60-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(60, "61-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(61, "62-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(62, "63-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(63, "64-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(64, "65-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(65, "66-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(66, "67-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(67, "68-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(68, "69-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(69, "70-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(70, "71-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(71, "72-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(72, "73-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(73, "74-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(74, "75-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(75, "76-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(76, "77-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(77, "78-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(78, "79-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(79, "80-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(80, "81-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(81, "82-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(82, "83-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(83, "84-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(84, "85-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(85, "86-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(86, "87-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(87, "88-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(88, "89-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(89, "90-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(90, "91-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(91, "92-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(92, "93-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(93, "94-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(94, "95-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(95, "96-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(96, "97-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(97, "98-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(98, "99-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(99, "100-1.bmp");
            this.listSmallHeadImg.Images.SetKeyName(100, "back.bmp");
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.SystemColors.Control;
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBtnInfo,
            this.tbBtnSearch,
            this.tbBtnUpFriend,
            this.tbBtnSysMsg,
            this.tbBtnExit});
            this.toolBar.Location = new System.Drawing.Point(1, 508);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolBar.Size = new System.Drawing.Size(308, 27);
            this.toolBar.TabIndex = 6;
            this.toolBar.Text = "toolStrip1";
            // 
            // tbBtnInfo
            // 
            this.tbBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbBtnInfo.Image = global::MyQQ.Properties.Resources.user;
            this.tbBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnInfo.Name = "tbBtnInfo";
            this.tbBtnInfo.Size = new System.Drawing.Size(24, 24);
            this.tbBtnInfo.Text = "个人信息";
            this.tbBtnInfo.Click += new System.EventHandler(this.tbBtnInfo_Click);
            // 
            // tbBtnSearch
            // 
            this.tbBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbBtnSearch.Image = global::MyQQ.Properties.Resources.search;
            this.tbBtnSearch.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.tbBtnSearch.Name = "tbBtnSearch";
            this.tbBtnSearch.Size = new System.Drawing.Size(62, 24);
            this.tbBtnSearch.Text = "查找";
            this.tbBtnSearch.Click += new System.EventHandler(this.tbBtnSearch_Click);
            // 
            // tbBtnUpFriend
            // 
            this.tbBtnUpFriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnUpFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbBtnUpFriend.Image = global::MyQQ.Properties.Resources.up;
            this.tbBtnUpFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnUpFriend.Name = "tbBtnUpFriend";
            this.tbBtnUpFriend.Size = new System.Drawing.Size(24, 24);
            this.tbBtnUpFriend.Text = "更新好友列表";
            this.tbBtnUpFriend.Click += new System.EventHandler(this.tbBtnUpFriend_Click);
            // 
            // tbBtnSysMsg
            // 
            this.tbBtnSysMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnSysMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbBtnSysMsg.Image = global::MyQQ.Properties.Resources.message;
            this.tbBtnSysMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnSysMsg.Name = "tbBtnSysMsg";
            this.tbBtnSysMsg.Size = new System.Drawing.Size(24, 24);
            this.tbBtnSysMsg.Text = "系统消息";
            this.tbBtnSysMsg.Click += new System.EventHandler(this.tbBtnSysMsg_Click);
            // 
            // tbBtnExit
            // 
            this.tbBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbBtnExit.Image = global::MyQQ.Properties.Resources.exit;
            this.tbBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBtnExit.Name = "tbBtnExit";
            this.tbBtnExit.Size = new System.Drawing.Size(24, 24);
            this.tbBtnExit.Text = "退出";
            this.tbBtnExit.Click += new System.EventHandler(this.tbBtnExit_Click);
            // 
            // friendListCms
            // 
            this.friendListCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuView,
            this.tsMenuAdd,
            this.tsMenuDel});
            this.friendListCms.Name = "friendListCms";
            this.friendListCms.Size = new System.Drawing.Size(125, 70);
            // 
            // tsMenuView
            // 
            this.tsMenuView.Name = "tsMenuView";
            this.tsMenuView.Size = new System.Drawing.Size(124, 22);
            this.tsMenuView.Text = "小头像";
            // 
            // tsMenuAdd
            // 
            this.tsMenuAdd.Name = "tsMenuAdd";
            this.tsMenuAdd.Size = new System.Drawing.Size(124, 22);
            this.tsMenuAdd.Text = "加为好友";
            // 
            // tsMenuDel
            // 
            this.tsMenuDel.Name = "tsMenuDel";
            this.tsMenuDel.Size = new System.Drawing.Size(124, 22);
            this.tsMenuDel.Text = "删除";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 536);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.friendLv);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 0);
            this.Name = "Main_Frm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Main_Frm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Frm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPBox)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.friendListCms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minPBox;
        private System.Windows.Forms.PictureBox closePBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ListView friendLv;
        private System.Windows.Forms.ImageList listSmallHeadImg;
        private System.Windows.Forms.ImageList listHeadImg;
        private System.Windows.Forms.PictureBox headPBox;
        private System.Windows.Forms.Label signLab;
        private System.Windows.Forms.TextBox signTBox;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tbBtnInfo;
        private System.Windows.Forms.ToolStripButton tbBtnSearch;
        private System.Windows.Forms.ToolStripButton tbBtnUpFriend;
        private System.Windows.Forms.ToolStripButton tbBtnSysMsg;
        private System.Windows.Forms.ToolStripButton tbBtnExit;
        private System.Windows.Forms.ContextMenuStrip friendListCms;
        private System.Windows.Forms.ToolStripMenuItem tsMenuView;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
    }
}