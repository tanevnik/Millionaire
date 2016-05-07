namespace Millionaire
{
    partial class CorrectAnswerMessageForm
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
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doubleBufferedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 1500;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.doubleBufferedPanel1.Controls.Add(this.messageLabel);
            this.doubleBufferedPanel1.Controls.Add(this.label2);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(3, 3);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(342, 198);
            this.doubleBufferedPanel1.TabIndex = 3;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.ForeColor = System.Drawing.Color.Black;
            this.messageLabel.Location = new System.Drawing.Point(0, 92);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(342, 82);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Освоивте Х денари";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Точен одговор!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectAnswerMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(109)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(348, 204);
            this.ControlBox = false;
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CorrectAnswerMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer closeTimer;
        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Label messageLabel;
    }
}