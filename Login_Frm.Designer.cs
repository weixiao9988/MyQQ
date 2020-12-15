
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
            this.closePBox = new System.Windows.Forms.PictureBox();
            this.minPBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.findPwdLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.regLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closePBox
            // 
            this.closePBox.BackColor = System.Drawing.Color.Transparent;
            this.closePBox.BackgroundImage = global::MyQQ.Properties.Resources.close;
            this.closePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePBox.Location = new System.Drawing.Point(397, 4);
            this.closePBox.Margin = new System.Windows.Forms.Padding(0);
            this.closePBox.Name = "closePBox";
            this.closePBox.Size = new System.Drawing.Size(28, 28);
            this.closePBox.TabIndex = 0;
            this.closePBox.TabStop = false;
            this.toolTip1.SetToolTip(this.closePBox, "关闭");
            this.closePBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closePBox_MouseClick);
            this.closePBox.MouseLeave += new System.EventHandler(this.closePBox_MouseLeave);
            this.closePBox.MouseHover += new System.EventHandler(this.closePBox_MouseHover);
            // 
            // minPBox
            // 
            this.minPBox.BackColor = System.Drawing.Color.Transparent;
            this.minPBox.BackgroundImage = global::MyQQ.Properties.Resources.min;
            this.minPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minPBox.Location = new System.Drawing.Point(366, 4);
            this.minPBox.Margin = new System.Windows.Forms.Padding(0);
            this.minPBox.Name = "minPBox";
            this.minPBox.Size = new System.Drawing.Size(28, 28);
            this.minPBox.TabIndex = 1;
            this.minPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.minPBox, "最小化");
            this.minPBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minPBox_MouseClick);
            this.minPBox.MouseLeave += new System.EventHandler(this.minPBox_MouseLeave);
            this.minPBox.MouseHover += new System.EventHandler(this.minPBox_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(221, 21);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(96, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "自动登录";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox2.Location = new System.Drawing.Point(184, 238);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "记住密码";
            this.checkBox2.UseVisualStyleBackColor = false;
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
            this.findPwdLab.TabIndex = 6;
            this.findPwdLab.Text = "找回密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // regLab
            // 
            this.regLab.AutoSize = true;
            this.regLab.BackColor = System.Drawing.Color.White;
            this.regLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLab.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regLab.Location = new System.Drawing.Point(9, 303);
            this.regLab.Name = "regLab";
            this.regLab.Size = new System.Drawing.Size(56, 17);
            this.regLab.TabIndex = 8;
            this.regLab.Text = "注册账号";
            this.regLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(427, 327);
            this.Controls.Add(this.regLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findPwdLab);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minPBox);
            this.Controls.Add(this.closePBox);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePBox;
        private System.Windows.Forms.PictureBox minPBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label findPwdLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label regLab;
    }
}