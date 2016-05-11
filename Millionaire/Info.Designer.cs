namespace Millionaire
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.okBorder = new Millionaire.DoubleBufferedPanel();
            this.okLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doubleBufferedPanel2 = new Millionaire.DoubleBufferedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doubleBufferedPanel1.SuspendLayout();
            this.okBorder.SuspendLayout();
            this.doubleBufferedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.doubleBufferedPanel1.Controls.Add(this.okBorder);
            this.doubleBufferedPanel1.Controls.Add(this.label1);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel2);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(296, 256);
            this.doubleBufferedPanel1.TabIndex = 0;
            this.doubleBufferedPanel1.MouseEnter += new System.EventHandler(this.hoverOff);
            // 
            // okBorder
            // 
            this.okBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.okBorder.Controls.Add(this.okLabel);
            this.okBorder.Location = new System.Drawing.Point(68, 217);
            this.okBorder.Name = "okBorder";
            this.okBorder.Size = new System.Drawing.Size(160, 30);
            this.okBorder.TabIndex = 4;
            this.okBorder.Click += new System.EventHandler(this.ok_Click);
            this.okBorder.MouseEnter += new System.EventHandler(this.hoverOn);
            this.okBorder.MouseLeave += new System.EventHandler(this.hoverOff);
            // 
            // okLabel
            // 
            this.okLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.okLabel.ForeColor = System.Drawing.Color.White;
            this.okLabel.Location = new System.Drawing.Point(2, 2);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(156, 26);
            this.okLabel.TabIndex = 0;
            this.okLabel.Text = "Ок";
            this.okLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okLabel.Click += new System.EventHandler(this.ok_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.hoverOn);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseEnter += new System.EventHandler(this.hoverOff);
            this.label1.MouseLeave += new System.EventHandler(this.hoverOff);
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.doubleBufferedPanel2.Controls.Add(this.pictureBox1);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(98, 7);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(100, 100);
            this.doubleBufferedPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Millionaire.Properties.Resources.logo_large_500x500_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.hoverOff);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.hoverOff);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Инфо";
            this.MouseEnter += new System.EventHandler(this.hoverOff);
            this.MouseLeave += new System.EventHandler(this.hoverOff);
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.okBorder.ResumeLayout(false);
            this.doubleBufferedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Label label1;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DoubleBufferedPanel okBorder;
        private System.Windows.Forms.Label okLabel;
    }
}