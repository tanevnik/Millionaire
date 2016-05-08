namespace Millionaire
{
    partial class WrongAnswerDialog
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
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.doubleBufferedPanel3 = new Millionaire.DoubleBufferedPanel();
            this.noLabel = new System.Windows.Forms.Label();
            this.doubleBufferedPanel2 = new Millionaire.DoubleBufferedPanel();
            this.yesLabel = new System.Windows.Forms.Label();
            this.messageLable = new System.Windows.Forms.Label();
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
            this.doubleBufferedPanel1.Controls.Add(this.messageLable);
            this.doubleBufferedPanel1.Controls.Add(this.label1);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(294, 170);
            this.doubleBufferedPanel1.TabIndex = 4;
            // 
            // doubleBufferedPanel3
            // 
            this.doubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.doubleBufferedPanel3.Controls.Add(this.noLabel);
            this.doubleBufferedPanel3.Location = new System.Drawing.Point(152, 127);
            this.doubleBufferedPanel3.Name = "doubleBufferedPanel3";
            this.doubleBufferedPanel3.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel3.TabIndex = 5;
            this.doubleBufferedPanel3.Click += new System.EventHandler(this.doubleBufferedPanel3_Click);
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
            this.noLabel.Click += new System.EventHandler(this.noLabel_Click);
            this.noLabel.MouseEnter += new System.EventHandler(this.noLabel_MouseEnter);
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.doubleBufferedPanel2.Controls.Add(this.yesLabel);
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(10, 127);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(132, 30);
            this.doubleBufferedPanel2.TabIndex = 4;
            this.doubleBufferedPanel2.Click += new System.EventHandler(this.doubleBufferedPanel2_Click);
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
            this.yesLabel.Click += new System.EventHandler(this.yesLabel_Click);
            this.yesLabel.MouseEnter += new System.EventHandler(this.yesLabel_MouseEnter);
            // 
            // messageLable
            // 
            this.messageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLable.ForeColor = System.Drawing.Color.White;
            this.messageLable.Location = new System.Drawing.Point(10, 39);
            this.messageLable.Name = "messageLable";
            this.messageLable.Size = new System.Drawing.Size(274, 78);
            this.messageLable.TabIndex = 1;
            this.messageLable.Text = "Одговорот Х е погрешен, точниот одговор е: Х. Вие освоивте Х денари! Нова игра?";
            this.messageLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Грешен одговор!";
            // 
            // WrongAnswerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(298, 174);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WrongAnswerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Грешен одговор";
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel1.PerformLayout();
            this.doubleBufferedPanel3.ResumeLayout(false);
            this.doubleBufferedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Label messageLable;
        private System.Windows.Forms.Label label1;
        private DoubleBufferedPanel doubleBufferedPanel3;
        private System.Windows.Forms.Label noLabel;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private System.Windows.Forms.Label yesLabel;
    }
}