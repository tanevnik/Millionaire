namespace Millionaire
{
    partial class CustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog));
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.doubleBufferedPanel3 = new Millionaire.DoubleBufferedPanel();
            this.noLabel = new System.Windows.Forms.Label();
            this.doubleBufferedPanel2 = new Millionaire.DoubleBufferedPanel();
            this.yesLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doubleBufferedPanel1.SuspendLayout();
            this.doubleBufferedPanel3.SuspendLayout();
            this.doubleBufferedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel3);
            this.doubleBufferedPanel1.Controls.Add(this.doubleBufferedPanel2);
            this.doubleBufferedPanel1.Controls.Add(this.messageLabel);
            this.doubleBufferedPanel1.Controls.Add(this.label1);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(294, 159);
            this.doubleBufferedPanel1.TabIndex = 5;
            this.doubleBufferedPanel1.MouseEnter += new System.EventHandler(this.reset_hover);
            this.doubleBufferedPanel1.MouseLeave += new System.EventHandler(this.reset_hover);
            // 
            // doubleBufferedPanel3
            // 
            this.doubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.doubleBufferedPanel3.Controls.Add(this.noLabel);
            this.doubleBufferedPanel3.Location = new System.Drawing.Point(152, 120);
            this.doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            this.doubleBufferedPanel3.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel3.TabIndex = 5;
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
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.doubleBufferedPanel2.Controls.Add(this.yesLabel);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(10, 120);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel2.TabIndex = 4;
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
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(10, 39);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(274, 77);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Точниот одговор на прашањето е Х. Вие освоивте Х денари. Нова игра?";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.MouseEnter += new System.EventHandler(this.reset_hover);
            this.messageLabel.MouseLeave += new System.EventHandler(this.reset_hover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Се откажавте!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.reset_hover);
            this.label1.MouseLeave += new System.EventHandler(this.reset_hover);
            // 
            // SurrenderedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(298, 163);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SurrenderedMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Се откажавте";
            this.MouseEnter += new System.EventHandler(this.reset_hover);
            this.MouseLeave += new System.EventHandler(this.reset_hover);
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
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label1;
    }
}