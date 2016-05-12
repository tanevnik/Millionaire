using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class View : Form
    {
        private Model model;

        //moneyPanel components
        private Panel[] moneyPanels;
        private Label[] moneyLevelLabels;
        private Label[] moneyLabels;
        private Label[] circles;

        //studio images
        Bitmap[] images = { Properties.Resources.studio1, Properties.Resources.studio2, Properties.Resources.studio3 };
        int currentImage;

        //animation variables
        private int timerTicks;
        private int correctIndex;
        private bool correctAnswer;

        //hover variables
        bool blockHover;
        bool insideHover;

        //sound player
        SoundPlayer snd;

        public View()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            Random r = new Random();
            pictureBox.BackgroundImage = images[r.Next(images.Length)];

            initializeMoneyPanel();

            blockHover = false;
            insideHover = false;
        }

        private void initializeMoneyPanel()
        {
            moneyPanels = new Panel[15];
            moneyPanels[0] = moneyPanel0;
            moneyPanels[1] = moneyPanel1;
            moneyPanels[2] = moneyPanel2;
            moneyPanels[3] = moneyPanel3;
            moneyPanels[4] = moneyPanel4;
            moneyPanels[5] = moneyPanel5;
            moneyPanels[6] = moneyPanel6;
            moneyPanels[7] = moneyPanel7;
            moneyPanels[8] = moneyPanel8;
            moneyPanels[9] = moneyPanel9;
            moneyPanels[10] = moneyPanel10;
            moneyPanels[11] = moneyPanel11;
            moneyPanels[12] = moneyPanel12;
            moneyPanels[13] = moneyPanel13;
            moneyPanels[14] = moneyPanel14;

            moneyLevelLabels = new Label[15];
            moneyLevelLabels[0] = moneyLevelLabel0;
            moneyLevelLabels[1] = moneyLevelLabel1;
            moneyLevelLabels[2] = moneyLevelLabel2;
            moneyLevelLabels[3] = moneyLevelLabel3;
            moneyLevelLabels[4] = moneyLevelLabel4;
            moneyLevelLabels[5] = moneyLevelLabel5;
            moneyLevelLabels[6] = moneyLevelLabel6;
            moneyLevelLabels[7] = moneyLevelLabel7;
            moneyLevelLabels[8] = moneyLevelLabel8;
            moneyLevelLabels[9] = moneyLevelLabel9;
            moneyLevelLabels[10] = moneyLevelLabel10;
            moneyLevelLabels[11] = moneyLevelLabel11;
            moneyLevelLabels[12] = moneyLevelLabel12;
            moneyLevelLabels[13] = moneyLevelLabel13;
            moneyLevelLabels[14] = moneyLevelLabel14;

            moneyLabels = new Label[15];
            moneyLabels[0] = moneyLabel0;
            moneyLabels[1] = moneyLabel1;
            moneyLabels[2] = moneyLabel2;
            moneyLabels[3] = moneyLabel3;
            moneyLabels[4] = moneyLabel4;
            moneyLabels[5] = moneyLabel5;
            moneyLabels[6] = moneyLabel6;
            moneyLabels[7] = moneyLabel7;
            moneyLabels[8] = moneyLabel8;
            moneyLabels[9] = moneyLabel9;
            moneyLabels[10] = moneyLabel10;
            moneyLabels[11] = moneyLabel11;
            moneyLabels[12] = moneyLabel12;
            moneyLabels[13] = moneyLabel13;
            moneyLabels[14] = moneyLabel14;

            circles = new Label[14];
            circles[0] = circle0;
            circles[1] = circle1;
            circles[2] = circle2;
            circles[3] = circle3;
            circles[4] = circle4;
            circles[5] = circle5;
            circles[6] = circle6;
            circles[7] = circle7;
            circles[8] = circle8;
            circles[9] = circle9;
            circles[10] = circle10;
            circles[11] = circle11;
            circles[12] = circle12;
            circles[13] = circle13;
        }

        //MAIN MENU BUTTONS
        private void newGame_btn_Click(object sender, EventArgs e)
        {
            newGame();
            hover_animation_off(newGameLabel, newGameButtonBackg); //remove hover
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Info window = new Info();
            window.ShowDialog();
            hover_animation_off(infoLabel, infoButtonBackg); //remove hover
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //STARTING A NEW GAME
        private void newGame()
        {
            //Starts a new game
            model = new Model();
            animationTimer.Enabled = false; //stop any animation running
            hover_animation_off(surrender_label, doubleBufferedPanel1); //remove hover on surrender button
            playMusic();
            updateView();
            playPanel.Show();
            imageTimer.Enabled = true;

            //reset the used jokers from previous game
            fifty_joker.Enabled = true;
            fifty_joker.BackgroundImage = Properties.Resources._5050;
            audience_joker.Enabled = true;
            audience_joker.BackgroundImage = Properties.Resources.audience;
            phone_joker.Enabled = true;
            phone_joker.BackgroundImage = Properties.Resources.phone;
            switch_joker.Enabled = true;
            switch_joker.BackgroundImage = Properties.Resources._switch;
        }

        //METHOD USED TO START PLAYING BACKGROUND MUSIC
        private void playMusic()
        {
            snd = new SoundPlayer(Properties.Resources.Atmosphere);
            snd.PlayLooping();
        }

        //UPDATE ALL ELEMENTS OF THE GAME (called every time there's a change of the game state)
        private void updateView()
        {
            //update question
            enableAllButtons();
            Question q = model.currentQuestion;
            questionLabel.Text = q.question;
            for (int i = 0; i < 4; i++) getAnswerTextLabel(i).Text = q.answer[i];

            //update jokers
            if (model.fifty_spent) fifty_joker.Enabled = false;
            if (model.audience_spent) audience_joker.Enabled = false;
            if (model.phone_spent) phone_joker.Enabled = false;
            if (model.switch_spent) switch_joker.Enabled = false;

            //update money panel
            updateMoneyPanel();

            //check for joker 50-50
            if (model.fifty_active)
            {
                //joker 50-50 is active
                for(int i = 0; i<4; i++)
                {
                    //disable answers
                    if (model.fifty_wrong1 == i || model.fifty_wrong2 == i) disableButton(i);
                }
            }

            //update level
            levelLabel.Text = "" + (model.level + 1);
        }

        //UPDATES THE MONEYPANEL ACCORDING TO THE GAME STATE
        private void updateMoneyPanel()
        {
            for (int i = 0; i < 15; i++)
            {
                //reset all fields to default
                moneyPanels[i].BackColor = Color.FromArgb(35, 31, 32);
                moneyLabels[i].BackColor = Color.FromArgb(35, 31, 32);
                moneyLevelLabels[i].BackColor = Color.FromArgb(35, 31, 32);
                if(i<14) circles[i].BackColor = Color.FromArgb(35, 31, 32);
                moneyLevelLabels[i].ForeColor = Color.FromArgb(248, 155, 28);
                moneyLabels[i].ForeColor = Color.FromArgb(248, 155, 28);
            }
            moneyLevelLabels[4].ForeColor = Color.White;
            moneyLabels[4].ForeColor = Color.White;
            moneyLevelLabels[9].ForeColor = Color.White;
            moneyLabels[9].ForeColor = Color.White;
            moneyLevelLabels[14].ForeColor = Color.White;
            moneyLabels[14].ForeColor = Color.White;

            //highlight the current question
            moneyPanels[model.level].BackColor = Color.FromArgb(248, 155, 28);
            moneyLabels[model.level].BackColor = Color.FromArgb(248, 155, 28);
            moneyLevelLabels[model.level].BackColor = Color.FromArgb(248, 155, 28);
            if (model.level < 14) circles[model.level].BackColor = Color.FromArgb(248, 155, 28);
            if ((model.level + 1) % 5 != 0) // checks if the current level is 5, 10 or 15
            {
                moneyLevelLabels[model.level].ForeColor = Color.Black;
                moneyLabels[model.level].ForeColor = Color.Black;
            }

            //show circles for answered questions
            for(int i = 0; i<=13; i++)
            {
                if (i < model.level) circles[i].Text = "●";
                else circles[i].Text = "";
            }
        }

        //HELPER FUNCTIONS FOR FAST ACCESS OF THE ANSWER COMPONENTS
        private Label getLetterLabel(int index)
        {
            //returns the letter label for the given index
            if(index == 0) return labelA;
            else if(index == 1) return labelB;
            else if(index == 2) return labelV;
            else return labelG;
        }

        private Label getAnswerTextLabel(int index)
        {
            //returns the answerText label for the given index
            if (index == 0) return answerTextA;
            else if (index == 1) return answerTextB;
            else if (index == 2) return answerTextV;
            else return answerTextG;
        }

        private Panel getPanel(int index)
        {
            //returns the button panel for the given index
            if (index == 0) return panelA;
            else if (index == 1) return panelB;
            else if (index == 2) return panelV;
            else return panelG;
        }

        //DISABLE BUTTON FUNCTION USED FOR 50-50 JOKER
        private void disableButton(int index)
        {
            //disables the button with the given index (from 0 to 3 inclusive)
            if(index == 0 || index == 2) getPanel(index).BackgroundImage = Properties.Resources.leftAnswerDisabled;
            else getPanel(index).BackgroundImage = Properties.Resources.rightAnswerDisabled;
            getLetterLabel(index).Text = "";
            getAnswerTextLabel(index).Text = "";
            getPanel(index).Enabled = false;
        }

        //ENABLE ALL BUTTONS FUNCTION USED FOR RESETING THE ANSWERS AFTER THE USE OF 50-50 JOKER
        private void enableAllButtons()
        {
            //enables all answers
            panelA.Enabled = panelB.Enabled = panelV.Enabled = panelG.Enabled = true;
            for(int i = 0; i<4; i++) changeBackgroundNormal(i);
            labelA.Text = "А:";
            labelB.Text = "Б:";
            labelV.Text = "В:";
            labelG.Text = "Г:";
        }

        //ANSWER BACKGROUND CHANGING FUNCTIONS USED FOR ANSWER ANIMATIONS
        private void changeBackgroundNormal(int index)
        {
            //change backround of answer to normal (unselected)
            if (index == 0 || index == 2) getPanel(index).BackgroundImage = Properties.Resources.leftAnswer;
            else getPanel(index).BackgroundImage = Properties.Resources.rightAnswer;
            getLetterLabel(index).BackColor = Color.FromArgb(35, 31, 32);
            getLetterLabel(index).ForeColor = Color.FromArgb(248, 155, 28); //orange;
            getAnswerTextLabel(index).BackColor = Color.FromArgb(35, 31, 32);
            getAnswerTextLabel(index).ForeColor = Color.White;
        }

        private void changeBackgroundSelected(int index)
        {
            //change backround of answer to selected
            if (index == 0 || index == 2) getPanel(index).BackgroundImage = Properties.Resources.leftAnswerSelect;
            else getPanel(index).BackgroundImage = Properties.Resources.rightAnswerSelect;
            getLetterLabel(index).BackColor = Color.FromArgb(248, 155, 28);
            getLetterLabel(index).ForeColor = Color.White;
            getAnswerTextLabel(index).BackColor = Color.FromArgb(248, 155, 28);
            getAnswerTextLabel(index).ForeColor = Color.Black;
        }

        private void changeBackgroundCorrect(int index)
        {
            //change backround of answer to correct
            if (index == 0 || index == 2) getPanel(index).BackgroundImage = Properties.Resources.leftAnswerCorrect;
            else getPanel(index).BackgroundImage = Properties.Resources.rightAnswerCorrect;
            getLetterLabel(index).BackColor = Color.FromArgb(83, 187, 97);
            getLetterLabel(index).ForeColor = Color.White;
            getAnswerTextLabel(index).BackColor = Color.FromArgb(83, 187, 97);
            getAnswerTextLabel(index).ForeColor = Color.Black;
        }

        //ON CLICK EVENTS FOR CHOOSING AN ANSWER
        private void answerA_Click(object sender, EventArgs e)
        {
            tryAnswer(0);
        }

        private void panelA_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 55 && e.X <= 379) tryAnswer(0);
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            tryAnswer(1);
        }

        private void panelB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 14 && e.X <= 337) tryAnswer(1);
        }

        private void answerV_Click(object sender, EventArgs e)
        {
            tryAnswer(2);
        }

        private void panelV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 55 && e.X <= 379) tryAnswer(2);
        }

        private void answerG_Click(object sender, EventArgs e)
        {
            tryAnswer(3);
        }

        private void panelG_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 14 && e.X <= 337) tryAnswer(3);
        }

        //DIALOG BOX USED TO TELL THE PLAYER THAT THEIR ANSWER IS CORRECT
        private void showCorrectAnswerMessage(string prize, int level)
        {
            CorrectAnswerMessageForm form = new CorrectAnswerMessageForm(prize, level);
            form.ShowDialog();
        }

        //ANIMATION FUNCTIONS USED TO ANIMATE THE RIGHT ANSWER AFTER CHOOSING AN ANSWER
        private void animateCorrect(int index)
        {
            correctIndex = index;
            correctAnswer = true;
            timerTicks = 5; //needs to be set to odd number
            animationTimer.Start(); //starts the animation
        }

        private void animateWrong(int index)
        {
            correctIndex = index;
            correctAnswer = false;
            timerTicks = 5; //needs to be set to odd number
            animationTimer.Start(); //starts the animation
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //animates the correct answer with green flickering
            if(timerTicks % 2 == 1)
            {
                //green flicker
                changeBackgroundCorrect(correctIndex);
            }
            else
            {
                //default color flicker
                if(correctAnswer) changeBackgroundSelected(correctIndex);
                else changeBackgroundNormal(correctIndex);       
            }

            timerTicks--;
            if (timerTicks == 0) animationTimer.Stop();
        }

        //FUNCTION FOR DETERMINING IF THE ANSWER IS RIGHT, AND DISPLAYING IT TO THE PLAYER
        public void tryAnswer(int index)
        {
            Cursor = Cursors.Default;
            blockHover = true;
            changeBackgroundSelected(index);
            string answer = model.currentQuestion.answer[index];

            if (finalAnswer(answer))
            {
                if (model.tryAnswer(index))
                {
                    //correct answer
                    animateCorrect(index);
                    if (model.level < 15)
                    {
                        snd = new SoundPlayer(Properties.Resources.Correct_ans);
                        snd.Play();
                        showCorrectAnswerMessage(model.getMoney(false), model.level);
                        playMusic();
                        updateView();
                    }
                    else
                    {
                        //win the game
                        snd = new SoundPlayer(Properties.Resources.Win_game);
                        snd.Play();
                        if (winGameMessage()) newGame(); //player wants new game
                        else {
                            snd.Stop();
                            playPanel.Hide(); //player doesn't want new game, return to main menu
                        }
                    }
                }
                else
                {
                    //wrong answer
                    animateWrong(model.correct);
                    snd = new SoundPlayer(Properties.Resources.Incorrect_ans);
                    snd.Play();

                    if (wrongAnswerMessage(answer, model.currentQuestion.answer[model.correct])) newGame(); //player wants new game
                    else {
                        snd.Stop();
                        playPanel.Hide(); //player doesn't want new game, return to main menu
                    }
                }
            }
            else
            {
                //reset music
                playMusic();
            }
            changeBackgroundNormal(index);
            blockHover = false;
        }

        //DIALOG BOXES
        private bool wrongAnswerMessage(string answer, string correct)
        {
            //dialog box shown when the chosen answer is wrong
            WrongAnswerDialog form = new WrongAnswerDialog(answer, correct, model.getMoney(true));
            form.ShowDialog();
            return form.newGame;
        }

        private bool winGameMessage()
        {
            //dialog box shown when the player answers all 15 questions correct
            CustomDialog message = new CustomDialog("", "", true);
            message.ShowDialog();
            return message.newGame;
        }

        private bool serrenderAnswerMessage(string correct)
        {
            //dialog box shown after the player surrenders
            CustomDialog message = new CustomDialog(correct, model.getMoney(false), false);
            message.ShowDialog();
            return message.newGame;
        }

        private bool finalAnswer(string answer)
        {
            //dialog box asking the player to confirm their answer
            //change audio
            snd = new SoundPlayer(Properties.Resources.Final_ans);
            snd.Play();
            Konecen form = new Konecen(answer);
            form.ShowDialog();
            return form.finalAnswer;
        }

        //SURRENDER ON CLICK EVENT
        private void surrender_btn_Click(object sender, EventArgs e)
        {
            SurrenderDialog form = new SurrenderDialog();
            form.ShowDialog();
            if (form.confirm)
            {
                animateWrong(model.correct); // highlight the correct answer
                snd = new SoundPlayer(Properties.Resources.Surrender);
                snd.Play();

                if (serrenderAnswerMessage(model.currentQuestion.answer[model.correct]))
                {
                    //playere wants new game
                    newGame();
                }
                else
                {
                    //player doesn't want new game
                    playPanel.Hide();
                    snd.Stop();
                }
            }
            else hover_animation_off(surrender_label, doubleBufferedPanel1); //reset the hover
        }

        //JOKER ON CLICK EVENTS
        private void fifty_joker_Click(object sender, EventArgs e)
        {
            fifty_joker.BackgroundImage = Properties.Resources._5050inuse;
            timer5050.Start();

            snd = new SoundPlayer(Properties.Resources.Joker_fifty);
            snd.Play();
            Timer sec = new Timer(); //1 sec timer used to reset the music after the joker sound effect
            sec.Interval = 1000;
            sec.Tick += Sec_Tick;
            sec.Start();

            model.joker_fifty();
            updateView();
        }

        private void Sec_Tick(object sender, EventArgs e)
        {
            playMusic(); //reset the music
            ((Timer)sender).Dispose(); //kill the timer
        }

        private void audience_joker_Click(object sender, EventArgs e)
        {
            audience_joker.BackgroundImage = Properties.Resources.audienceinuse;
            timerAudience.Start();

            snd = new SoundPlayer(Properties.Resources.Joker_audience);
            snd.Play();
            Timer sec = new Timer(); //1 sec timer used to reset the music after the joker sound effect
            sec.Interval = 1000;
            sec.Tick += Sec_Tick1;
            sec.Start();

            int[] votes = model.joker_audience();

            Audience view = new Audience(votes);
            view.ShowDialog();
            updateView();
        }

        private void Sec_Tick1(object sender, EventArgs e)
        {
            playMusic(); //reset the music
            ((Timer)sender).Dispose(); //kill the timer
        }

        private void phone_joker_Click(object sender, EventArgs e)
        {
            phone_joker.BackgroundImage = Properties.Resources.phoneinuse;            
            timerPhone.Start();

            snd = new SoundPlayer(Properties.Resources.Joker_phone);
            snd.PlayLooping();

            int[] phone = model.joker_phone();
            Phone view = new Phone(phone[0], model.currentQuestion.answer[phone[0]], phone[1]);
            view.ShowDialog();
            updateView();
            playMusic();
        }

        private void switch_joker_Click(object sender, EventArgs e)
        {
            switch_joker.BackgroundImage = Properties.Resources.switchinuse;
            timerSwitch.Start();

            snd = new SoundPlayer(Properties.Resources.Joker_switch);
            snd.Play();
            Timer sec = new Timer(); //1 sec timer used to reset the music after the joker sound effect
            sec.Interval = 1000;
            sec.Tick += Sec_Tick2;
            sec.Start();

            model.joker_switch();
            updateView();
        }

        private void Sec_Tick2(object sender, EventArgs e)
        {
            playMusic(); //reset the music
            ((Timer)sender).Dispose(); //kill the timer
        }

        //TIMERS USED TO ANIMATE THE JOKER CLICK 
        private void timer5050_Tick(object sender, EventArgs e)
        {
            fifty_joker.BackgroundImage = Properties.Resources._5050used;
            timer5050.Stop();
        }

        private void timerPhone_Tick(object sender, EventArgs e)
        {
            phone_joker.BackgroundImage = Properties.Resources.phoneused;
            timerPhone.Stop();
        }

        private void timerAudience_Tick(object sender, EventArgs e)
        {
            audience_joker.BackgroundImage = Properties.Resources.audienceused;
            timerAudience.Stop();
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            switch_joker.BackgroundImage = Properties.Resources.switchused;
            timerSwitch.Stop();
        }

        //TIMER USED FOR SHUFFLING BETWEEN THE IMAGES IN THE IMAGE PANEL
        private void imageTimer_Tick(object sender, EventArgs e)
        {
            //changes the current image
            Random r = new Random();
            int rand = r.Next(images.Length - 1);
            if (rand >= currentImage) rand++;
            currentImage = rand;
            pictureBox.BackgroundImage = images[rand];
        }

        //HOVER ANIMATIONS ON MAIN MENU
        private void hover_animation_on(Label l, Panel p)
        {
            Cursor = Cursors.Hand;
            l.BackColor = Color.FromArgb(45, 41, 42);
            p.BackColor = Color.FromArgb(120, 153, 215);
        }

        private void hover_animation_off(Label l, Panel p)
        {
            Cursor = Cursors.Arrow;
            l.BackColor = Color.FromArgb(35, 31, 32);
            p.BackColor = Color.FromArgb(100, 133, 195);
        }

        private void newGameHoverOn(object sender, EventArgs e)
        {
            hover_animation_on(newGameLabel, newGameButtonBackg);
        }

        private void newGameHoverOff(object sender, EventArgs e)
        {
            hover_animation_off(newGameLabel, newGameButtonBackg);
        }

        private void infoHoverOn(object sender, EventArgs e)
        {
            hover_animation_on(infoLabel, infoButtonBackg);
        }

        private void infoHoverOff(object sender, EventArgs e)
        {
            hover_animation_off(infoLabel, infoButtonBackg);
        }

        private void exitHoverOn(object sender, EventArgs e)
        {
            hover_animation_on(exitLabel, exitButtonBackg);
        }

        private void exitHoverOff(object sender, EventArgs e)
        {
            hover_animation_off(exitLabel, exitButtonBackg);
        }

        //HOVER EVENTS FOR SURRENDER BUTTON
        private void surrenderHoverOn(object sender, EventArgs e)
        {
            hover_animation_on(surrender_label, doubleBufferedPanel1);
        }

        private void surrenderHoverOff(object sender, EventArgs e)
        {
            hover_animation_off(surrender_label, doubleBufferedPanel1);
        }

        //HOVER ANIMATIONS FOR THE ANSWERS
        private void answerHoverOn(Panel p, Label letter, Label text, bool left)
        {
            if (blockHover) return;
            DrawingControl.SuspendDrawing(p);
            text.BackColor = Color.FromArgb(45, 41, 42);
            letter.BackColor = Color.FromArgb(45, 41, 42);
            if(left) p.BackgroundImage = Properties.Resources.leftAnswerHover;
            else p.BackgroundImage = Properties.Resources.rightAnswerHover;
            DrawingControl.ResumeDrawing(p);
            Cursor = Cursors.Hand;
        }

        private void answerHoverOff(Panel p, Label letter, Label text, bool left)
        {
            if (blockHover) return;
            DrawingControl.SuspendDrawing(p);
            if (left) p.BackgroundImage = Properties.Resources.leftAnswer;
            else p.BackgroundImage = Properties.Resources.rightAnswer;
            text.BackColor = Color.FromArgb(35, 31, 32);
            letter.BackColor = Color.FromArgb(35, 31, 32);
            DrawingControl.ResumeDrawing(p);
            Cursor = Cursors.Default;
        }

        private void panelA_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 55 && e.X <= 379 && insideHover == false)
            {
                insideHover = true;
                answerHoverOn(panelA, labelA, answerTextA, true);
            }
            else if ((e.X < 55 || e.X > 379) && insideHover == true)
            {
                insideHover = false;
                answerHoverOff(panelA, labelA, answerTextA, true);
            }
        }

        private void panelA_MouseLeave(object sender, EventArgs e)
        {
            insideHover = false;
            answerHoverOff(panelA, labelA, answerTextA, true);
        }

        private void answerA_HoverOn(object sender, EventArgs e)
        {
            answerHoverOn(panelA, labelA, answerTextA, true);
        }

        private void panelB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 14 && e.X <= 337 && insideHover == false)
            {
                insideHover = true;
                answerHoverOn(panelB, labelB, answerTextB, false);
            }
            else if ((e.X < 14 || e.X > 337) && insideHover == true)
            {
                insideHover = false;
                answerHoverOff(panelB, labelB, answerTextB, false);
            }
        }

        private void panelB_MouseLeave(object sender, EventArgs e)
        {
            insideHover = false;
            answerHoverOff(panelB, labelB, answerTextB, false);
        }

        private void answerB_HoverOn(object sender, EventArgs e)
        {
            answerHoverOn(panelB, labelB, answerTextB, false);
        }

        private void panelV_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 55 && e.X <= 379 && insideHover == false)
            {
                insideHover = true;
                answerHoverOn(panelV, labelV, answerTextV, true);
            }
            else if ((e.X < 55 || e.X > 379) && insideHover == true)
            {
                insideHover = false;
                answerHoverOff(panelV, labelV, answerTextV, true);
            }
        }

        private void panelV_MouseLeave(object sender, EventArgs e)
        {
            insideHover = false;
            answerHoverOff(panelV, labelV, answerTextV, true);
        }

        private void answerV_HoverOn(object sender, EventArgs e)
        {
            answerHoverOn(panelV, labelV, answerTextV, true);
        }

        private void panelG_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 14 && e.X <= 337 && insideHover == false)
            {
                insideHover = true;
                answerHoverOn(panelG, labelG, answerTextG, false);
            }
            else if ((e.X < 14 || e.X > 337) && insideHover == true)
            {

                answerHoverOff(panelG, labelG, answerTextG, false);
            }
        }

        private void panelG_MouseLeave(object sender, EventArgs e)
        {
            insideHover = false;
            answerHoverOff(panelG, labelG, answerTextG, false);
        }

        private void answerG_HoverOn(object sender, EventArgs e)
        {
            answerHoverOn(panelG, labelG, answerTextG, false);
        }

        private void joker_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void joker_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }

    //HELPER CLASS USED TO SUPPRESS DRAWING OF COMPONENTS FOR SMOOTHER TRANSITIONS
    class DrawingControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
}