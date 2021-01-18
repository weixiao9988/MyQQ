
namespace MyQQ
{
    partial class EditInfo_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfo_Frm));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPg_Info = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.bldTypeCBox = new System.Windows.Forms.ComboBox();
            this.starCBox = new System.Windows.Forms.ComboBox();
            this.sexCBox = new System.Windows.Forms.ComboBox();
            this.chgHeadBtn = new System.Windows.Forms.Button();
            this.headPBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ageTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nickNameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPg_Set = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nobodyRBtn = new System.Windows.Forms.RadioButton();
            this.validationRBtn = new System.Windows.Forms.RadioButton();
            this.anybodyRBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPwdTBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.newPwdTBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.oldPwdTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            this.tabCtrl.SuspendLayout();
            this.tabPg_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPBox)).BeginInit();
            this.tabPg_Set.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPg_Info);
            this.tabCtrl.Controls.Add(this.tabPg_Set);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(358, 212);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPg_Info
            // 
            this.tabPg_Info.Controls.Add(this.label7);
            this.tabPg_Info.Controls.Add(this.bldTypeCBox);
            this.tabPg_Info.Controls.Add(this.starCBox);
            this.tabPg_Info.Controls.Add(this.sexCBox);
            this.tabPg_Info.Controls.Add(this.chgHeadBtn);
            this.tabPg_Info.Controls.Add(this.headPBox);
            this.tabPg_Info.Controls.Add(this.label6);
            this.tabPg_Info.Controls.Add(this.ageTBox);
            this.tabPg_Info.Controls.Add(this.label5);
            this.tabPg_Info.Controls.Add(this.nameTBox);
            this.tabPg_Info.Controls.Add(this.label4);
            this.tabPg_Info.Controls.Add(this.label3);
            this.tabPg_Info.Controls.Add(this.nickNameTBox);
            this.tabPg_Info.Controls.Add(this.label2);
            this.tabPg_Info.Controls.Add(this.userIDTBox);
            this.tabPg_Info.Controls.Add(this.label1);
            this.tabPg_Info.Location = new System.Drawing.Point(4, 22);
            this.tabPg_Info.Margin = new System.Windows.Forms.Padding(0);
            this.tabPg_Info.Name = "tabPg_Info";
            this.tabPg_Info.Size = new System.Drawing.Size(350, 186);
            this.tabPg_Info.TabIndex = 0;
            this.tabPg_Info.Text = "个人信息";
            this.tabPg_Info.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "年龄：";
            // 
            // bldTypeCBox
            // 
            this.bldTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bldTypeCBox.FormattingEnabled = true;
            this.bldTypeCBox.Items.AddRange(new object[] {
            "A型 ",
            "B型 ",
            "O型 ",
            "AB型"});
            this.bldTypeCBox.Location = new System.Drawing.Point(245, 149);
            this.bldTypeCBox.Name = "bldTypeCBox";
            this.bldTypeCBox.Size = new System.Drawing.Size(95, 20);
            this.bldTypeCBox.TabIndex = 18;
            // 
            // starCBox
            // 
            this.starCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starCBox.FormattingEnabled = true;
            this.starCBox.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.starCBox.Location = new System.Drawing.Point(74, 149);
            this.starCBox.Name = "starCBox";
            this.starCBox.Size = new System.Drawing.Size(95, 20);
            this.starCBox.TabIndex = 17;
            // 
            // sexCBox
            // 
            this.sexCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCBox.FormattingEnabled = true;
            this.sexCBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexCBox.Location = new System.Drawing.Point(74, 82);
            this.sexCBox.Name = "sexCBox";
            this.sexCBox.Size = new System.Drawing.Size(95, 20);
            this.sexCBox.TabIndex = 16;
            // 
            // chgHeadBtn
            // 
            this.chgHeadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chgHeadBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chgHeadBtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.chgHeadBtn.Location = new System.Drawing.Point(290, 81);
            this.chgHeadBtn.Name = "chgHeadBtn";
            this.chgHeadBtn.Size = new System.Drawing.Size(30, 20);
            this.chgHeadBtn.TabIndex = 15;
            this.chgHeadBtn.Text = ">>";
            this.chgHeadBtn.UseVisualStyleBackColor = true;
            this.chgHeadBtn.Click += new System.EventHandler(this.chgHeadBtn_Click);
            // 
            // headPBox
            // 
            this.headPBox.Location = new System.Drawing.Point(204, 20);
            this.headPBox.Name = "headPBox";
            this.headPBox.Size = new System.Drawing.Size(80, 80);
            this.headPBox.TabIndex = 14;
            this.headPBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "血型：";
            // 
            // ageTBox
            // 
            this.ageTBox.Location = new System.Drawing.Point(245, 116);
            this.ageTBox.Name = "ageTBox";
            this.ageTBox.Size = new System.Drawing.Size(95, 21);
            this.ageTBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "星    座：";
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(74, 115);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(95, 21);
            this.nameTBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "真实姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性    别：";
            // 
            // nickNameTBox
            // 
            this.nickNameTBox.Location = new System.Drawing.Point(74, 49);
            this.nickNameTBox.Name = "nickNameTBox";
            this.nickNameTBox.Size = new System.Drawing.Size(95, 21);
            this.nickNameTBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户昵称：";
            // 
            // userIDTBox
            // 
            this.userIDTBox.Location = new System.Drawing.Point(74, 16);
            this.userIDTBox.Name = "userIDTBox";
            this.userIDTBox.ReadOnly = true;
            this.userIDTBox.Size = new System.Drawing.Size(95, 21);
            this.userIDTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户号码：";
            // 
            // tabPg_Set
            // 
            this.tabPg_Set.Controls.Add(this.groupBox2);
            this.tabPg_Set.Controls.Add(this.groupBox1);
            this.tabPg_Set.Location = new System.Drawing.Point(4, 22);
            this.tabPg_Set.Margin = new System.Windows.Forms.Padding(0);
            this.tabPg_Set.Name = "tabPg_Set";
            this.tabPg_Set.Size = new System.Drawing.Size(350, 186);
            this.tabPg_Set.TabIndex = 1;
            this.tabPg_Set.Text = "安全设置";
            this.tabPg_Set.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nobodyRBtn);
            this.groupBox2.Controls.Add(this.validationRBtn);
            this.groupBox2.Controls.Add(this.anybodyRBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "身份验证";
            // 
            // nobodyRBtn
            // 
            this.nobodyRBtn.AutoSize = true;
            this.nobodyRBtn.Location = new System.Drawing.Point(41, 64);
            this.nobodyRBtn.Name = "nobodyRBtn";
            this.nobodyRBtn.Size = new System.Drawing.Size(155, 16);
            this.nobodyRBtn.TabIndex = 2;
            this.nobodyRBtn.Text = "不允许任何人加我为好友";
            this.nobodyRBtn.UseVisualStyleBackColor = true;
            // 
            // validationRBtn
            // 
            this.validationRBtn.AutoSize = true;
            this.validationRBtn.Location = new System.Drawing.Point(41, 42);
            this.validationRBtn.Name = "validationRBtn";
            this.validationRBtn.Size = new System.Drawing.Size(179, 16);
            this.validationRBtn.TabIndex = 1;
            this.validationRBtn.Text = "需要身份验证才能加我为好友";
            this.validationRBtn.UseVisualStyleBackColor = true;
            // 
            // anybodyRBtn
            // 
            this.anybodyRBtn.AutoSize = true;
            this.anybodyRBtn.Checked = true;
            this.anybodyRBtn.Location = new System.Drawing.Point(41, 20);
            this.anybodyRBtn.Name = "anybodyRBtn";
            this.anybodyRBtn.Size = new System.Drawing.Size(143, 16);
            this.anybodyRBtn.TabIndex = 0;
            this.anybodyRBtn.TabStop = true;
            this.anybodyRBtn.Text = "允许任何人加我为好友";
            this.anybodyRBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newPwdTBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.newPwdTBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.oldPwdTBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // newPwdTBox2
            // 
            this.newPwdTBox2.Location = new System.Drawing.Point(94, 59);
            this.newPwdTBox2.Name = "newPwdTBox2";
            this.newPwdTBox2.PasswordChar = '*';
            this.newPwdTBox2.Size = new System.Drawing.Size(225, 21);
            this.newPwdTBox2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "新密码确认：";
            // 
            // newPwdTBox
            // 
            this.newPwdTBox.Location = new System.Drawing.Point(94, 37);
            this.newPwdTBox.Name = "newPwdTBox";
            this.newPwdTBox.PasswordChar = '*';
            this.newPwdTBox.Size = new System.Drawing.Size(225, 21);
            this.newPwdTBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "新密码：";
            // 
            // oldPwdTBox
            // 
            this.oldPwdTBox.Location = new System.Drawing.Point(94, 15);
            this.oldPwdTBox.Name = "oldPwdTBox";
            this.oldPwdTBox.PasswordChar = '*';
            this.oldPwdTBox.Size = new System.Drawing.Size(225, 21);
            this.oldPwdTBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "原密码：";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(194, 218);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(60, 25);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(284, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 25);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Empty;
            this.imglistHead.Images.SetKeyName(0, "1");
            this.imglistHead.Images.SetKeyName(1, "2");
            this.imglistHead.Images.SetKeyName(2, "3");
            this.imglistHead.Images.SetKeyName(3, "4");
            this.imglistHead.Images.SetKeyName(4, "5");
            this.imglistHead.Images.SetKeyName(5, "6");
            this.imglistHead.Images.SetKeyName(6, "7");
            this.imglistHead.Images.SetKeyName(7, "8");
            this.imglistHead.Images.SetKeyName(8, "9");
            this.imglistHead.Images.SetKeyName(9, "10");
            this.imglistHead.Images.SetKeyName(10, "11");
            this.imglistHead.Images.SetKeyName(11, "12");
            this.imglistHead.Images.SetKeyName(12, "13");
            this.imglistHead.Images.SetKeyName(13, "14");
            this.imglistHead.Images.SetKeyName(14, "15");
            this.imglistHead.Images.SetKeyName(15, "16");
            this.imglistHead.Images.SetKeyName(16, "17");
            this.imglistHead.Images.SetKeyName(17, "18");
            this.imglistHead.Images.SetKeyName(18, "19");
            this.imglistHead.Images.SetKeyName(19, "20");
            this.imglistHead.Images.SetKeyName(20, "21");
            this.imglistHead.Images.SetKeyName(21, "22");
            this.imglistHead.Images.SetKeyName(22, "23");
            this.imglistHead.Images.SetKeyName(23, "24");
            this.imglistHead.Images.SetKeyName(24, "25");
            this.imglistHead.Images.SetKeyName(25, "26");
            this.imglistHead.Images.SetKeyName(26, "27");
            this.imglistHead.Images.SetKeyName(27, "28");
            this.imglistHead.Images.SetKeyName(28, "29");
            this.imglistHead.Images.SetKeyName(29, "30");
            this.imglistHead.Images.SetKeyName(30, "31");
            this.imglistHead.Images.SetKeyName(31, "32");
            this.imglistHead.Images.SetKeyName(32, "33");
            this.imglistHead.Images.SetKeyName(33, "34");
            this.imglistHead.Images.SetKeyName(34, "35");
            this.imglistHead.Images.SetKeyName(35, "36");
            this.imglistHead.Images.SetKeyName(36, "37");
            this.imglistHead.Images.SetKeyName(37, "38");
            this.imglistHead.Images.SetKeyName(38, "39");
            this.imglistHead.Images.SetKeyName(39, "40");
            this.imglistHead.Images.SetKeyName(40, "41");
            this.imglistHead.Images.SetKeyName(41, "42");
            this.imglistHead.Images.SetKeyName(42, "43");
            this.imglistHead.Images.SetKeyName(43, "44");
            this.imglistHead.Images.SetKeyName(44, "45");
            this.imglistHead.Images.SetKeyName(45, "46");
            this.imglistHead.Images.SetKeyName(46, "47");
            this.imglistHead.Images.SetKeyName(47, "48");
            this.imglistHead.Images.SetKeyName(48, "49");
            this.imglistHead.Images.SetKeyName(49, "50");
            this.imglistHead.Images.SetKeyName(50, "51");
            this.imglistHead.Images.SetKeyName(51, "52");
            this.imglistHead.Images.SetKeyName(52, "53");
            this.imglistHead.Images.SetKeyName(53, "54");
            this.imglistHead.Images.SetKeyName(54, "55");
            this.imglistHead.Images.SetKeyName(55, "56");
            this.imglistHead.Images.SetKeyName(56, "57");
            this.imglistHead.Images.SetKeyName(57, "58");
            this.imglistHead.Images.SetKeyName(58, "59");
            this.imglistHead.Images.SetKeyName(59, "60");
            this.imglistHead.Images.SetKeyName(60, "61");
            this.imglistHead.Images.SetKeyName(61, "62");
            this.imglistHead.Images.SetKeyName(62, "63");
            this.imglistHead.Images.SetKeyName(63, "64");
            this.imglistHead.Images.SetKeyName(64, "65");
            this.imglistHead.Images.SetKeyName(65, "66");
            this.imglistHead.Images.SetKeyName(66, "67");
            this.imglistHead.Images.SetKeyName(67, "68");
            this.imglistHead.Images.SetKeyName(68, "69");
            this.imglistHead.Images.SetKeyName(69, "70");
            this.imglistHead.Images.SetKeyName(70, "71");
            this.imglistHead.Images.SetKeyName(71, "72");
            this.imglistHead.Images.SetKeyName(72, "73");
            this.imglistHead.Images.SetKeyName(73, "74");
            this.imglistHead.Images.SetKeyName(74, "75");
            this.imglistHead.Images.SetKeyName(75, "76");
            this.imglistHead.Images.SetKeyName(76, "77");
            this.imglistHead.Images.SetKeyName(77, "78");
            this.imglistHead.Images.SetKeyName(78, "79");
            this.imglistHead.Images.SetKeyName(79, "80");
            this.imglistHead.Images.SetKeyName(80, "81");
            this.imglistHead.Images.SetKeyName(81, "82");
            this.imglistHead.Images.SetKeyName(82, "83");
            this.imglistHead.Images.SetKeyName(83, "84");
            this.imglistHead.Images.SetKeyName(84, "85");
            this.imglistHead.Images.SetKeyName(85, "86");
            this.imglistHead.Images.SetKeyName(86, "87");
            this.imglistHead.Images.SetKeyName(87, "88");
            this.imglistHead.Images.SetKeyName(88, "89");
            this.imglistHead.Images.SetKeyName(89, "90");
            this.imglistHead.Images.SetKeyName(90, "91");
            this.imglistHead.Images.SetKeyName(91, "92");
            this.imglistHead.Images.SetKeyName(92, "93");
            this.imglistHead.Images.SetKeyName(93, "94");
            this.imglistHead.Images.SetKeyName(94, "95");
            this.imglistHead.Images.SetKeyName(95, "96");
            this.imglistHead.Images.SetKeyName(96, "97");
            this.imglistHead.Images.SetKeyName(97, "98");
            this.imglistHead.Images.SetKeyName(98, "99");
            this.imglistHead.Images.SetKeyName(99, "100");
            this.imglistHead.Images.SetKeyName(100, "back.bmp");
            // 
            // EditInfo_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 251);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInfo_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息设置";
            this.Load += new System.EventHandler(this.EditInfo_Frm_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPg_Info.ResumeLayout(false);
            this.tabPg_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPBox)).EndInit();
            this.tabPg_Set.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPg_Info;
        private System.Windows.Forms.TabPage tabPg_Set;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button chgHeadBtn;
        private System.Windows.Forms.PictureBox headPBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ageTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nickNameTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nobodyRBtn;
        private System.Windows.Forms.RadioButton validationRBtn;
        private System.Windows.Forms.RadioButton anybodyRBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newPwdTBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newPwdTBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox oldPwdTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bldTypeCBox;
        private System.Windows.Forms.ComboBox starCBox;
        private System.Windows.Forms.ComboBox sexCBox;
        private System.Windows.Forms.ImageList imglistHead;
    }
}