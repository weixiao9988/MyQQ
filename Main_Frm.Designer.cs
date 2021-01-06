
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
            this.minPBox = new System.Windows.Forms.PictureBox();
            this.closePBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // minPBox
            // 
            this.minPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minPBox.BackColor = System.Drawing.Color.Transparent;
            this.minPBox.BackgroundImage = global::MyQQ.Properties.Resources.min;
            this.minPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minPBox.Location = new System.Drawing.Point(238, 0);
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
            this.closePBox.BackColor = System.Drawing.Color.Transparent;
            this.closePBox.BackgroundImage = global::MyQQ.Properties.Resources.close;
            this.closePBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closePBox.Location = new System.Drawing.Point(268, 0);
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
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(296, 521);
            this.Controls.Add(this.minPBox);
            this.Controls.Add(this.closePBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main_Frm";
            this.Text = "Main_Frm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Frm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minPBox;
        private System.Windows.Forms.PictureBox closePBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}