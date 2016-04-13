namespace Millionaire
{
    partial class View
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
            this.newGame_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.playPanel = new System.Windows.Forms.Panel();
            this.serrender_btn = new System.Windows.Forms.Button();
            this.audience_joker = new System.Windows.Forms.Button();
            this.phone_joker = new System.Windows.Forms.Button();
            this.switch_joker = new System.Windows.Forms.Button();
            this.split_joker = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.answer4 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // newGame_btn
            // 
            this.newGame_btn.Location = new System.Drawing.Point(582, 35);
            this.newGame_btn.Name = "newGame_btn";
            this.newGame_btn.Size = new System.Drawing.Size(144, 44);
            this.newGame_btn.TabIndex = 8;
            this.newGame_btn.Text = "Нова игра";
            this.newGame_btn.UseVisualStyleBackColor = true;
            this.newGame_btn.Click += new System.EventHandler(this.newGame_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(582, 113);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(144, 44);
            this.info_btn.TabIndex = 9;
            this.info_btn.Text = "Инфо";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(582, 410);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(144, 47);
            this.exit_btn.TabIndex = 10;
            this.exit_btn.Text = "Излези";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.levelLabel);
            this.playPanel.Controls.Add(this.serrender_btn);
            this.playPanel.Controls.Add(this.audience_joker);
            this.playPanel.Controls.Add(this.phone_joker);
            this.playPanel.Controls.Add(this.switch_joker);
            this.playPanel.Controls.Add(this.split_joker);
            this.playPanel.Controls.Add(this.questionLabel);
            this.playPanel.Controls.Add(this.pictureBox3);
            this.playPanel.Controls.Add(this.pictureBox2);
            this.playPanel.Controls.Add(this.answer4);
            this.playPanel.Controls.Add(this.answer3);
            this.playPanel.Controls.Add(this.answer2);
            this.playPanel.Controls.Add(this.answer1);
            this.playPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPanel.Location = new System.Drawing.Point(0, 0);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(759, 555);
            this.playPanel.TabIndex = 11;
            this.playPanel.Visible = false;
            // 
            // serrender_btn
            // 
            this.serrender_btn.Location = new System.Drawing.Point(532, 341);
            this.serrender_btn.Name = "serrender_btn";
            this.serrender_btn.Size = new System.Drawing.Size(216, 23);
            this.serrender_btn.TabIndex = 23;
            this.serrender_btn.Text = "Се откажувам";
            this.serrender_btn.UseVisualStyleBackColor = true;
            this.serrender_btn.Click += new System.EventHandler(this.serrender_btn_Click);
            // 
            // audience_joker
            // 
            this.audience_joker.Location = new System.Drawing.Point(594, 45);
            this.audience_joker.Name = "audience_joker";
            this.audience_joker.Size = new System.Drawing.Size(46, 23);
            this.audience_joker.TabIndex = 22;
            this.audience_joker.Text = "aud";
            this.audience_joker.UseVisualStyleBackColor = true;
            // 
            // phone_joker
            // 
            this.phone_joker.Location = new System.Drawing.Point(646, 45);
            this.phone_joker.Name = "phone_joker";
            this.phone_joker.Size = new System.Drawing.Size(46, 23);
            this.phone_joker.TabIndex = 21;
            this.phone_joker.Text = "phone";
            this.phone_joker.UseVisualStyleBackColor = true;
            // 
            // switch_joker
            // 
            this.switch_joker.Location = new System.Drawing.Point(698, 45);
            this.switch_joker.Name = "switch_joker";
            this.switch_joker.Size = new System.Drawing.Size(46, 23);
            this.switch_joker.TabIndex = 20;
            this.switch_joker.Text = "switch";
            this.switch_joker.UseVisualStyleBackColor = true;
            // 
            // split_joker
            // 
            this.split_joker.Location = new System.Drawing.Point(542, 45);
            this.split_joker.Name = "split_joker";
            this.split_joker.Size = new System.Drawing.Size(46, 23);
            this.split_joker.TabIndex = 19;
            this.split_joker.Text = "50/50";
            this.split_joker.UseVisualStyleBackColor = true;
            this.split_joker.Click += new System.EventHandler(this.split_joker_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(53, 367);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(633, 69);
            this.questionLabel.TabIndex = 18;
            this.questionLabel.Text = "prasanje";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(532, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 303);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(37, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 303);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(413, 503);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(273, 40);
            this.answer4.TabIndex = 15;
            this.answer4.Text = "button4";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Click += new System.EventHandler(this.answer4_Click);
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(53, 503);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(273, 40);
            this.answer3.TabIndex = 14;
            this.answer3.Text = "button3";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(413, 457);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(273, 40);
            this.answer2.TabIndex = 13;
            this.answer2.Text = "button2";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(53, 457);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(273, 40);
            this.answer1.TabIndex = 12;
            this.answer1.Text = "button1";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(332, 488);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(75, 23);
            this.levelLabel.TabIndex = 24;
            this.levelLabel.Text = "level";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 555);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.newGame_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_img);
            this.Name = "View";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.playPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGame_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Button audience_joker;
        private System.Windows.Forms.Button phone_joker;
        private System.Windows.Forms.Button switch_joker;
        private System.Windows.Forms.Button split_joker;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button serrender_btn;
        private System.Windows.Forms.Label levelLabel;
    }
}