﻿
namespace MyQQ
{
    partial class Login_Frm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.userPWDTBox = new System.Windows.Forms.TextBox();
            this.userIDCBox = new System.Windows.Forms.ComboBox();
            this.autoLoginChkBox = new System.Windows.Forms.CheckBox();
            this.recordPwdChkBox = new System.Windows.Forms.CheckBox();
            this.findPwdLab = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.regLab = new System.Windows.Forms.Label();
            this.btnMin = new MyCtrls.BtnMMC();
            this.btnClose = new MyCtrls.BtnMMC();
            this.SuspendLayout();
            // 
            // userPWDTBox
            // 
            this.userPWDTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPWDTBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.5F);
            this.userPWDTBox.Location = new System.Drawing.Point(113, 209);
            this.userPWDTBox.Name = "userPWDTBox";
            this.userPWDTBox.PasswordChar = '●';
            this.userPWDTBox.Size = new System.Drawing.Size(221, 22);
            this.userPWDTBox.TabIndex = 2;
            this.userPWDTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userPWDTBox_KeyPress);
            // 
            // userIDCBox
            // 
            this.userIDCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIDCBox.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.userIDCBox.FormattingEnabled = true;
            this.userIDCBox.Location = new System.Drawing.Point(113, 164);
            this.userIDCBox.Name = "userIDCBox";
            this.userIDCBox.Size = new System.Drawing.Size(221, 31);
            this.userIDCBox.TabIndex = 1;
            this.userIDCBox.SelectedIndexChanged += new System.EventHandler(this.userIDCBox_SelectedIndexChanged);
            // 
            // autoLoginChkBox
            // 
            this.autoLoginChkBox.AutoSize = true;
            this.autoLoginChkBox.BackColor = System.Drawing.Color.White;
            this.autoLoginChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLoginChkBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoLoginChkBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.autoLoginChkBox.Location = new System.Drawing.Point(96, 238);
            this.autoLoginChkBox.Name = "autoLoginChkBox";
            this.autoLoginChkBox.Size = new System.Drawing.Size(81, 24);
            this.autoLoginChkBox.TabIndex = 3;
            this.autoLoginChkBox.Text = "自动登录";
            this.autoLoginChkBox.UseVisualStyleBackColor = false;
            // 
            // recordPwdChkBox
            // 
            this.recordPwdChkBox.AutoSize = true;
            this.recordPwdChkBox.BackColor = System.Drawing.Color.White;
            this.recordPwdChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordPwdChkBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recordPwdChkBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recordPwdChkBox.Location = new System.Drawing.Point(184, 238);
            this.recordPwdChkBox.Name = "recordPwdChkBox";
            this.recordPwdChkBox.Size = new System.Drawing.Size(81, 24);
            this.recordPwdChkBox.TabIndex = 4;
            this.recordPwdChkBox.Text = "记住密码";
            this.recordPwdChkBox.UseVisualStyleBackColor = false;
            this.recordPwdChkBox.CheckedChanged += new System.EventHandler(this.recordPwdChkBox_CheckedChanged);
            // 
            // findPwdLab
            // 
            this.findPwdLab.AutoSize = true;
            this.findPwdLab.BackColor = System.Drawing.Color.White;
            this.findPwdLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findPwdLab.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.findPwdLab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findPwdLab.Location = new System.Drawing.Point(269, 240);
            this.findPwdLab.Name = "findPwdLab";
            this.findPwdLab.Size = new System.Drawing.Size(65, 20);
            this.findPwdLab.TabIndex = 5;
            this.findPwdLab.Text = "找回密码";
            this.findPwdLab.Click += new System.EventHandler(this.findPwdLab_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(96, 273);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(238, 36);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regLab
            // 
            this.regLab.AutoSize = true;
            this.regLab.BackColor = System.Drawing.Color.White;
            this.regLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLab.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regLab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regLab.Location = new System.Drawing.Point(9, 303);
            this.regLab.Name = "regLab";
            this.regLab.Size = new System.Drawing.Size(56, 17);
            this.regLab.TabIndex = 6;
            this.regLab.Text = "注册账号";
            this.regLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regLab_MouseClick);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BtnType = MyCtrls.BtnType.Minimize;
            this.btnMin.LineColor = System.Drawing.Color.White;
            this.btnMin.LineWidth = 1;
            this.btnMin.Location = new System.Drawing.Point(368, 0);
            this.btnMin.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnMin.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnMin.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.btnMin.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);            
            this.btnMin.TabIndex = 7;
            this.btnMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMin_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BtnType = MyCtrls.BtnType.Close;
            this.btnClose.LineColor = System.Drawing.Color.White;
            this.btnClose.LineWidth = 1;
            this.btnClose.Location = new System.Drawing.Point(399, 0);
            this.btnClose.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.MouseLeaveColor = System.Drawing.Color.Transparent;
            this.btnClose.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);            
            this.btnClose.TabIndex = 8;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            // 
            // Login_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(427, 327);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.regLab);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.findPwdLab);
            this.Controls.Add(this.recordPwdChkBox);
            this.Controls.Add(this.autoLoginChkBox);
            this.Controls.Add(this.userIDCBox);
            this.Controls.Add(this.userPWDTBox);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox userPWDTBox;
        private System.Windows.Forms.ComboBox userIDCBox;
        private System.Windows.Forms.CheckBox autoLoginChkBox;
        private System.Windows.Forms.CheckBox recordPwdChkBox;
        private System.Windows.Forms.Label findPwdLab;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label regLab;
        private MyCtrls.BtnMMC btnMin;
        private MyCtrls.BtnMMC btnClose;
    }
}