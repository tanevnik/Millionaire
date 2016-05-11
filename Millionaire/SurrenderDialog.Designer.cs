namespace Millionaire
{
    partial class SurrenderDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurrenderDialog));
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.doubleBufferedPanel3 = new Millionaire.DoubleBufferedPanel();
            this.noLabel = new System.Windows.Forms.Label();
            this.doubleBufferedPanel2 = new Millionaire.DoubleBufferedPanel();
            this.yesLabel = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.doubleBufferedPanel1.SuspendLayout();
            this.doubleBufferedPanel3.SuspendLayout();
            this.doubleBufferedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel3);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel2);
            this.doubleBufferedPanel1.Controls.Add(this.text);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(296, 120);
            this.doubleBufferedPanel1.TabIndex = 5;
            this.doubleBufferedPanel1.MouseHover += new System.EventHandler(this.reset_hover);
            // 
            // doubleBufferedPanel3
            // 
            this.doubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.doubleBufferedPanel3.Controls.Add(this.noLabel);
            this.doubleBufferedPanel3.Location = new System.Drawing.Point(154, 80);
            this.doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            this.doubleBufferedPanel3.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel3.TabIndex = 4;
            this.doubleBufferedPanel3.Click += new System.EventHandler(this.no_Click);
            this.doubleBufferedPanel3.MouseEnter += new System.EventHandler(this.doubleBufferedPanel3_MouseEnter);
            this.doubleBufferedPanel3.MouseLeave += new System.EventHandler(this.doubleBufferedPanel3_MouseLeave);
            // 
            // noLabel
            // 
            this.noLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(2, 2);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(128, 26);
            this.noLabel.TabIndex = 0;
            this.noLabel.Text = "Не";
            this.noLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noLabel.Click += new System.EventHandler(this.no_Click);
            this.noLabel.MouseEnter += new System.EventHandler(this.doubleBufferedPanel3_MouseEnter);
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.doubleBufferedPanel2.Controls.Add(this.yesLabel);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(10, 80);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel2.TabIndex = 3;
            this.doubleBufferedPanel2.Click += new System.EventHandler(this.yes_Click);
            this.doubleBufferedPanel2.MouseEnter += new System.EventHandler(this.doubleBufferedPanel2_MouseEnter);
            this.doubleBufferedPanel2.MouseLeave += new System.EventHandler(this.doubleBufferedPanel2_MouseLeave);
            // 
            // yesLabel
            // 
            this.yesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.yesLabel.ForeColor = System.Drawing.Color.White;
            this.yesLabel.Location = new System.Drawing.Point(2, 2);
            this.yesLabel.Name = "yesLabel";
            this.yesLabel.Size = new System.Drawing.Size(128, 26);
            this.yesLabel.TabIndex = 0;
            this.yesLabel.Text = "Да";
            this.yesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesLabel.Click += new System.EventHandler(this.yes_Click);
            this.yesLabel.MouseEnter += new System.EventHandler(this.doubleBufferedPanel2_MouseEnter);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(10, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(276, 67);
            this.text.TabIndex = 0;
            this.text.Text = "Дали навистина сакате да се откажете?";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.text.MouseEnter += new System.EventHandler(this.reset_hover);
            // 
            // SurrenderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(300, 124);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SurrenderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Се откажувате?";
            this.MouseLeave += new System.EventHandler(this.reset_hover);
            this.MouseHover += new System.EventHandler(this.reset_hover);
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel3.ResumeLayout(false);
            this.doubleBufferedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private DoubleBufferedPanel doubleBufferedPanel3;
        private System.Windows.Forms.Label noLabel;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private System.Windows.Forms.Label yesLabel;
        private System.Windows.Forms.Label text;
    }
}