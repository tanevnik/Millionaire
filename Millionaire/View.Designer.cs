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
            this.playPanel = new Millionaire.DoubleBufferedPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.panelB = new DoubleBufferedPanel();
            this.answer1 = new DoubleBufferedPanel();
            this.answerTextB = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.panelV = new DoubleBufferedPanel();
            this.answer2 = new DoubleBufferedPanel();
            this.answerTextV = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.panelG = new DoubleBufferedPanel();
            this.answer3 = new DoubleBufferedPanel();
            this.answerTextG = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.panelA = new DoubleBufferedPanel();
            this.answer0 = new DoubleBufferedPanel();
            this.answerTextA = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.playPanel.SuspendLayout();
            this.panelB.SuspendLayout();
            this.answer1.SuspendLayout();
            this.panelV.SuspendLayout();
            this.answer2.SuspendLayout();
            this.panelG.SuspendLayout();
            this.answer3.SuspendLayout();
            this.panelA.SuspendLayout();
            this.answer0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.playPanel.Controls.Add(this.panelB);
            this.playPanel.Controls.Add(this.panelV);
            this.playPanel.Controls.Add(this.panelG);
            this.playPanel.Controls.Add(this.panelA);
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
            this.playPanel.Size = new System.Drawing.Size(759, 618);
            this.playPanel.TabIndex = 11;
            this.playPanel.Visible = false;
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(363, 545);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(32, 23);
            this.levelLabel.TabIndex = 39;
            this.levelLabel.Text = "level";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelB
            // 
            this.panelB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelB.BackgroundImage")));
            this.panelB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelB.Controls.Add(this.answer1);
            this.panelB.Location = new System.Drawing.Point(378, 510);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(380, 44);
            this.panelB.TabIndex = 43;
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.Color.Transparent;
            this.answer1.Controls.Add(this.answerTextB);
            this.answer1.Controls.Add(this.labelB);
            this.answer1.Location = new System.Drawing.Point(12, 0);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(316, 44);
            this.answer1.TabIndex = 2;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answerTextB
            // 
            this.answerTextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextB.ForeColor = System.Drawing.Color.White;
            this.answerTextB.Location = new System.Drawing.Point(54, -1);
            this.answerTextB.Name = "answerTextB";
            this.answerTextB.Size = new System.Drawing.Size(237, 44);
            this.answerTextB.TabIndex = 1;
            this.answerTextB.Text = "odgovor 1";
            this.answerTextB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerTextB.Click += new System.EventHandler(this.answer1_Click);
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.labelB.Location = new System.Drawing.Point(28, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(30, 44);
            this.labelB.TabIndex = 0;
            this.labelB.Text = "Б:";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelB.Click += new System.EventHandler(this.answer1_Click);
            // 
            // panelV
            // 
            this.panelV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelV.BackgroundImage")));
            this.panelV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelV.Controls.Add(this.answer2);
            this.panelV.Location = new System.Drawing.Point(-1, 560);
            this.panelV.Name = "panelV";
            this.panelV.Size = new System.Drawing.Size(380, 44);
            this.panelV.TabIndex = 44;
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.Color.Transparent;
            this.answer2.Controls.Add(this.answerTextV);
            this.answer2.Controls.Add(this.labelV);
            this.answer2.Location = new System.Drawing.Point(50, 0);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(318, 44);
            this.answer2.TabIndex = 0;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answerTextV
            // 
            this.answerTextV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextV.ForeColor = System.Drawing.Color.White;
            this.answerTextV.Location = new System.Drawing.Point(57, -1);
            this.answerTextV.Name = "answerTextV";
            this.answerTextV.Size = new System.Drawing.Size(237, 44);
            this.answerTextV.TabIndex = 2;
            this.answerTextV.Text = "odgovor 2";
            this.answerTextV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerTextV.Click += new System.EventHandler(this.answer2_Click);
            // 
            // labelV
            // 
            this.labelV.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.labelV.Location = new System.Drawing.Point(32, 0);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(30, 44);
            this.labelV.TabIndex = 1;
            this.labelV.Text = "В:";
            this.labelV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelV.Click += new System.EventHandler(this.answer2_Click);
            // 
            // panelG
            // 
            this.panelG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelG.BackgroundImage")));
            this.panelG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelG.Controls.Add(this.answer3);
            this.panelG.Location = new System.Drawing.Point(379, 560);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(380, 44);
            this.panelG.TabIndex = 45;
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.Color.Transparent;
            this.answer3.Controls.Add(this.answerTextG);
            this.answer3.Controls.Add(this.labelG);
            this.answer3.Location = new System.Drawing.Point(11, 0);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(316, 44);
            this.answer3.TabIndex = 3;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answerTextG
            // 
            this.answerTextG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextG.ForeColor = System.Drawing.Color.White;
            this.answerTextG.Location = new System.Drawing.Point(54, -1);
            this.answerTextG.Name = "answerTextG";
            this.answerTextG.Size = new System.Drawing.Size(237, 44);
            this.answerTextG.TabIndex = 1;
            this.answerTextG.Text = "odgovor 3";
            this.answerTextG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerTextG.Click += new System.EventHandler(this.answer3_Click);
            // 
            // labelG
            // 
            this.labelG.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.labelG.Location = new System.Drawing.Point(28, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(30, 44);
            this.labelG.TabIndex = 0;
            this.labelG.Text = "Г:";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelG.Click += new System.EventHandler(this.answer3_Click);
            // 
            // panelA
            // 
            this.panelA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelA.BackgroundImage")));
            this.panelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelA.Controls.Add(this.answer0);
            this.panelA.Location = new System.Drawing.Point(-1, 510);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(380, 44);
            this.panelA.TabIndex = 42;
            // 
            // answer0
            // 
            this.answer0.BackColor = System.Drawing.Color.Transparent;
            this.answer0.Controls.Add(this.answerTextA);
            this.answer0.Controls.Add(this.labelA);
            this.answer0.Location = new System.Drawing.Point(50, 0);
            this.answer0.Name = "answer0";
            this.answer0.Size = new System.Drawing.Size(318, 44);
            this.answer0.TabIndex = 0;
            this.answer0.Click += new System.EventHandler(this.answer0_Click);
            // 
            // answerTextA
            // 
            this.answerTextA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextA.ForeColor = System.Drawing.Color.White;
            this.answerTextA.Location = new System.Drawing.Point(57, -1);
            this.answerTextA.Name = "answerTextA";
            this.answerTextA.Size = new System.Drawing.Size(237, 44);
            this.answerTextA.TabIndex = 1;
            this.answerTextA.Text = "odgovor 0";
            this.answerTextA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answerTextA.Click += new System.EventHandler(this.answer0_Click);
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(155)))), ((int)(((byte)(28)))));
            this.labelA.Location = new System.Drawing.Point(32, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(30, 44);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "А:";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA.Click += new System.EventHandler(this.answer0_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(71, 429);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(610, 66);
            this.questionLabel.TabIndex = 33;
            this.questionLabel.Text = "prasanje";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 84);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // focusLabel
            // 
            this.focusLabel.AutoSize = true;
            this.focusLabel.Location = new System.Drawing.Point(734, 499);
            this.focusLabel.Name = "focusLabel";
            this.focusLabel.Size = new System.Drawing.Size(0, 13);
            this.focusLabel.TabIndex = 40;
            // 
            // surrender_btn
            // 
            this.surrender_btn.Location = new System.Drawing.Point(531, 382);
            this.surrender_btn.Name = "surrender_btn";
            this.surrender_btn.Size = new System.Drawing.Size(216, 23);
            this.surrender_btn.TabIndex = 38;
            this.surrender_btn.Text = "Се откажувам";
            this.surrender_btn.UseVisualStyleBackColor = true;
            this.surrender_btn.Click += new System.EventHandler(this.surrender_btn_Click);
            // 
            // audience_joker
            // 
            this.audience_joker.Location = new System.Drawing.Point(584, 15);
            this.audience_joker.Name = "audience_joker";
            this.audience_joker.Size = new System.Drawing.Size(46, 23);
            this.audience_joker.TabIndex = 37;
            this.audience_joker.Text = "aud";
            this.audience_joker.UseVisualStyleBackColor = true;
            this.audience_joker.Click += new System.EventHandler(this.audience_joker_Click);
            // 
            // phone_joker
            // 
            this.phone_joker.Location = new System.Drawing.Point(636, 15);
            this.phone_joker.Name = "phone_joker";
            this.phone_joker.Size = new System.Drawing.Size(46, 23);
            this.phone_joker.TabIndex = 36;
            this.phone_joker.Text = "phone";
            this.phone_joker.UseVisualStyleBackColor = true;
            this.phone_joker.Click += new System.EventHandler(this.phone_joker_Click);
            // 
            // switch_joker
            // 
            this.switch_joker.Location = new System.Drawing.Point(688, 15);
            this.switch_joker.Name = "switch_joker";
            this.switch_joker.Size = new System.Drawing.Size(46, 23);
            this.switch_joker.TabIndex = 35;
            this.switch_joker.Text = "switch";
            this.switch_joker.UseVisualStyleBackColor = true;
            this.switch_joker.Click += new System.EventHandler(this.switch_joker_Click);
            // 
            // fifty_joker
            // 
            this.fifty_joker.Location = new System.Drawing.Point(532, 15);
            this.fifty_joker.Name = "fifty_joker";
            this.fifty_joker.Size = new System.Drawing.Size(46, 23);
            this.fifty_joker.TabIndex = 34;
            this.fifty_joker.Text = "50/50";
            this.fifty_joker.UseVisualStyleBackColor = true;
            this.fifty_joker.Click += new System.EventHandler(this.fifty_joker_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(531, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 332);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(74, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 274);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 618);
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
            this.panelB.ResumeLayout(false);
            this.answer1.ResumeLayout(false);
            this.panelV.ResumeLayout(false);
            this.answer2.ResumeLayout(false);
            this.panelG.ResumeLayout(false);
            this.answer3.ResumeLayout(false);
            this.panelA.ResumeLayout(false);
            this.answer0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private DoubleBufferedPanel playPanel;
        private System.Windows.Forms.Label levelLabel;
        private DoubleBufferedPanel answer1;
        private System.Windows.Forms.Label answerTextB;
        private System.Windows.Forms.Label labelB;
        private DoubleBufferedPanel answer2;
        private System.Windows.Forms.Label answerTextV;
        private System.Windows.Forms.Label labelV;
        private DoubleBufferedPanel answer3;
        private System.Windows.Forms.Label answerTextG;
        private System.Windows.Forms.Label labelG;
        private DoubleBufferedPanel answer0;
        private System.Windows.Forms.Label answerTextA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label focusLabel;
        private System.Windows.Forms.Button surrender_btn;
        private System.Windows.Forms.Button audience_joker;
        private System.Windows.Forms.Button phone_joker;
        private System.Windows.Forms.Button switch_joker;
        private System.Windows.Forms.Button fifty_joker;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DoubleBufferedPanel panelB;
        private DoubleBufferedPanel panelV;
        private DoubleBufferedPanel panelG;
        private DoubleBufferedPanel panelA;
    }
}