namespace Millionaire
{
    partial class Phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phone));
            this.text = new System.Windows.Forms.Label();
            this.panel = new Millionaire.DoubleBufferedPanel();
            this.label = new System.Windows.Forms.Label();
            this.doubleBufferedPanel1 = new Millionaire.DoubleBufferedPanel();
            this.panel.SuspendLayout();
            this.doubleBufferedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(10, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(208, 67);
            this.text.TabIndex = 0;
            this.text.Text = "text";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.panel.Controls.Add(this.label);
            this.panel.Location = new System.Drawing.Point(8, 77);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(212, 25);
            this.panel.TabIndex = 2;
            this.panel.Click += new System.EventHandler(this.close_Click);
            this.panel.MouseEnter += new System.EventHandler(this.doubleBufferedPanel1_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.doubleBufferedPanel1_MouseLeave);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(2, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(208, 21);
            this.label.TabIndex = 0;
            this.label.Text = "Затвори";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.close_Click);
            this.label.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.doubleBufferedPanel1.Controls.Add(this.text);
            this.doubleBufferedPanel1.Controls.Add(this.panel);
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(228, 110);
            this.doubleBufferedPanel1.TabIndex = 3;
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(232, 114);
            this.ControlBox = false;
            this.Controls.Add(this.doubleBufferedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Phone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пријател";
            this.panel.ResumeLayout(false);
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label text;
        private DoubleBufferedPanel panel;
        private System.Windows.Forms.Label label;
        private DoubleBufferedPanel doubleBufferedPanel1;
    }
}