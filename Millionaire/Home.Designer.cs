namespace Millionaire
{
    partial class Home
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
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newGame_img = new System.Windows.Forms.PictureBox();
            this.info_img = new System.Windows.Forms.PictureBox();
            this.exit_img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGame_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_img)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_img
            // 
            this.logo_img.Location = new System.Drawing.Point(56, 35);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(453, 344);
            this.logo_img.TabIndex = 0;
            this.logo_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGO";
            // 
            // newGame_img
            // 
            this.newGame_img.Location = new System.Drawing.Point(567, 35);
            this.newGame_img.Name = "newGame_img";
            this.newGame_img.Size = new System.Drawing.Size(100, 50);
            this.newGame_img.TabIndex = 2;
            this.newGame_img.TabStop = false;
            this.newGame_img.Click += new System.EventHandler(this.newGame_img_Click);
            // 
            // info_img
            // 
            this.info_img.Location = new System.Drawing.Point(567, 109);
            this.info_img.Name = "info_img";
            this.info_img.Size = new System.Drawing.Size(100, 50);
            this.info_img.TabIndex = 3;
            this.info_img.TabStop = false;
            this.info_img.Click += new System.EventHandler(this.info_img_Click);
            // 
            // exit_img
            // 
            this.exit_img.Location = new System.Drawing.Point(567, 425);
            this.exit_img.Name = "exit_img";
            this.exit_img.Size = new System.Drawing.Size(100, 50);
            this.exit_img.TabIndex = 4;
            this.exit_img.TabStop = false;
            this.exit_img.Click += new System.EventHandler(this.exit_img_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NEW GAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "INFO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EXIT";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_img);
            this.Controls.Add(this.info_img);
            this.Controls.Add(this.newGame_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_img);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGame_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox newGame_img;
        private System.Windows.Forms.PictureBox info_img;
        private System.Windows.Forms.PictureBox exit_img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}