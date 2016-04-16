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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newGame_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.playPanel = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.answer2 = new System.Windows.Forms.Panel();
            this.answerText2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answer0 = new System.Windows.Forms.Panel();
            this.answerText0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.focusLabel = new System.Windows.Forms.Label();
            this.surrender_btn = new System.Windows.Forms.Button();
            this.audience_joker = new System.Windows.Forms.Button();
            this.phone_joker = new System.Windows.Forms.Button();
            this.switch_joker = new System.Windows.Forms.Button();
            this.fifty_joker = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.answerText1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.answerText3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.playPanel.SuspendLayout();
            this.answer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.answer2.SuspendLayout();
            this.answer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.answer0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.playPanel.Controls.Add(this.answer1);
            this.playPanel.Controls.Add(this.panel5);
            this.playPanel.Controls.Add(this.answer3);
            this.playPanel.Controls.Add(this.panel1);
            this.playPanel.Controls.Add(this.questionLabel);
            this.playPanel.Controls.Add(this.pictureBox1);
            this.playPanel.Controls.Add(this.focusLabel);
            this.playPanel.Controls.Add(this.surrender_btn);
            this.playPanel.Controls.Add(this.audience_joker);
            this.playPanel.Controls.Add(this.phone_joker);
            this.playPanel.Controls.Add(this.switch_joker);
            this.playPanel.Controls.Add(this.fifty_joker);
            this.playPanel.Controls.Add(this.pictureBox3);
            this.playPanel.Controls.Add(this.pictureBox2);
            this.playPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPanel.Location = new System.Drawing.Point(0, 0);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(759, 555);
            this.playPanel.TabIndex = 11;
            this.playPanel.Visible = false;
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(364, 487);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(32, 23);
            this.levelLabel.TabIndex = 24;
            this.levelLabel.Text = "level";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer1
            // 
            this.answer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer1.BackgroundImage")));
            this.answer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.answer1.Controls.Add(this.panel2);
            this.answer1.Location = new System.Drawing.Point(379, 452);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(380, 44);
            this.answer1.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.answer2);
            this.panel5.Location = new System.Drawing.Point(0, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 44);
            this.panel5.TabIndex = 28;
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.Color.Transparent;
            this.answer2.Controls.Add(this.answerText2);
            this.answer2.Controls.Add(this.label3);
            this.answer2.Location = new System.Drawing.Point(50, 0);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(318, 44);
            this.answer2.TabIndex = 0;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answerText2
            // 
            this.answerText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText2.ForeColor = System.Drawing.Color.White;
            this.answerText2.Location = new System.Drawing.Point(57, -1);
            this.answerText2.Name = "answerText2";
            this.answerText2.Size = new System.Drawing.Size(237, 44);
            this.answerText2.TabIndex = 2;
            this.answerText2.Text = "odgovor 2";
            this.answerText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerText2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.label3.Location = new System.Drawing.Point(32, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "В:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer3
            // 
            this.answer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answer3.BackgroundImage")));
            this.answer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.answer3.Controls.Add(this.panel3);
            this.answer3.Location = new System.Drawing.Point(380, 502);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(380, 44);
            this.answer3.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.answer0);
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 44);
            this.panel1.TabIndex = 27;
            // 
            // answer0
            // 
            this.answer0.BackColor = System.Drawing.Color.Transparent;
            this.answer0.Controls.Add(this.answerText0);
            this.answer0.Controls.Add(this.label2);
            this.answer0.Location = new System.Drawing.Point(50, 0);
            this.answer0.Name = "answer0";
            this.answer0.Size = new System.Drawing.Size(318, 44);
            this.answer0.TabIndex = 0;
            this.answer0.Click += new System.EventHandler(this.answer0_Click);
            // 
            // answerText0
            // 
            this.answerText0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText0.ForeColor = System.Drawing.Color.White;
            this.answerText0.Location = new System.Drawing.Point(57, -1);
            this.answerText0.Name = "answerText0";
            this.answerText0.Size = new System.Drawing.Size(237, 44);
            this.answerText0.TabIndex = 1;
            this.answerText0.Text = "odgovor 0";
            this.answerText0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerText0.Click += new System.EventHandler(this.answer0_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(32, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "А:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.answer0_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(72, 371);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(610, 66);
            this.questionLabel.TabIndex = 18;
            this.questionLabel.Text = "prasanje";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 84);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // focusLabel
            // 
            this.focusLabel.AutoSize = true;
            this.focusLabel.Location = new System.Drawing.Point(735, 512);
            this.focusLabel.Name = "focusLabel";
            this.focusLabel.Size = new System.Drawing.Size(0, 13);
            this.focusLabel.TabIndex = 25;
            // 
            // surrender_btn
            // 
            this.surrender_btn.Location = new System.Drawing.Point(532, 323);
            this.surrender_btn.Name = "surrender_btn";
            this.surrender_btn.Size = new System.Drawing.Size(216, 23);
            this.surrender_btn.TabIndex = 23;
            this.surrender_btn.Text = "Се откажувам";
            this.surrender_btn.UseVisualStyleBackColor = true;
            this.surrender_btn.Click += new System.EventHandler(this.surrender_btn_Click);
            // 
            // audience_joker
            // 
            this.audience_joker.Location = new System.Drawing.Point(594, 45);
            this.audience_joker.Name = "audience_joker";
            this.audience_joker.Size = new System.Drawing.Size(46, 23);
            this.audience_joker.TabIndex = 22;
            this.audience_joker.Text = "aud";
            this.audience_joker.UseVisualStyleBackColor = true;
            this.audience_joker.Click += new System.EventHandler(this.audience_joker_Click);
            // 
            // phone_joker
            // 
            this.phone_joker.Location = new System.Drawing.Point(646, 45);
            this.phone_joker.Name = "phone_joker";
            this.phone_joker.Size = new System.Drawing.Size(46, 23);
            this.phone_joker.TabIndex = 21;
            this.phone_joker.Text = "phone";
            this.phone_joker.UseVisualStyleBackColor = true;
            this.phone_joker.Click += new System.EventHandler(this.phone_joker_Click);
            // 
            // switch_joker
            // 
            this.switch_joker.Location = new System.Drawing.Point(698, 45);
            this.switch_joker.Name = "switch_joker";
            this.switch_joker.Size = new System.Drawing.Size(46, 23);
            this.switch_joker.TabIndex = 20;
            this.switch_joker.Text = "switch";
            this.switch_joker.UseVisualStyleBackColor = true;
            this.switch_joker.Click += new System.EventHandler(this.switch_joker_Click);
            // 
            // fifty_joker
            // 
            this.fifty_joker.Location = new System.Drawing.Point(542, 45);
            this.fifty_joker.Name = "fifty_joker";
            this.fifty_joker.Size = new System.Drawing.Size(46, 23);
            this.fifty_joker.TabIndex = 19;
            this.fifty_joker.Text = "50/50";
            this.fifty_joker.UseVisualStyleBackColor = true;
            this.fifty_joker.Click += new System.EventHandler(this.fifty_joker_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(532, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 285);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.answerText1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 44);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answerText1
            // 
            this.answerText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText1.ForeColor = System.Drawing.Color.White;
            this.answerText1.Location = new System.Drawing.Point(54, -1);
            this.answerText1.Name = "answerText1";
            this.answerText1.Size = new System.Drawing.Size(237, 44);
            this.answerText1.TabIndex = 1;
            this.answerText1.Text = "odgovor 1";
            this.answerText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerText1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.label7.Location = new System.Drawing.Point(28, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 44);
            this.label7.TabIndex = 0;
            this.label7.Text = "Б:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.answer1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.answerText3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(11, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 44);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answerText3
            // 
            this.answerText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText3.ForeColor = System.Drawing.Color.White;
            this.answerText3.Location = new System.Drawing.Point(54, -1);
            this.answerText3.Name = "answerText3";
            this.answerText3.Size = new System.Drawing.Size(237, 44);
            this.answerText3.TabIndex = 1;
            this.answerText3.Text = "odgovor 3";
            this.answerText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerText3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.label5.Location = new System.Drawing.Point(28, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Г:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.answer3_Click);
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
            this.Text = "Кој сака да биде милионер";
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            this.answer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.answer2.ResumeLayout(false);
            this.answer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.answer0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button fifty_joker;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button surrender_btn;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label focusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Panel answer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel answer3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel answer2;
        private System.Windows.Forms.Panel answer0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answerText2;
        private System.Windows.Forms.Label answerText0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label answerText1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label answerText3;
        private System.Windows.Forms.Label label5;
    }
}