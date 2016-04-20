using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class View : Form
    {
        private Model model;

        //animation variables
        private int timerTicks;
        private int correctIndex;
        private bool correctAnswer;

        public View()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            playPanel.Show();
            model = new Model();
            updateView();

            //reset the used jokers from previous game
            fifty_joker.Enabled = true;
            audience_joker.Enabled = true;
            phone_joker.Enabled = true;
            switch_joker.Enabled = true;
        }

        private void updateView()
        {
            //updates all elements in the view.

            //update question
            enableAllButtons();
            Question q = model.currentQuestion;
            questionLabel.Text = q.question;
            answerTextA.Text = q.answer[0];
            answerTextB.Text = q.answer[1];
            answerTextV.Text = q.answer[2];
            answerTextG.Text = q.answer[3];

            //update jokers
            if (model.fifty_spent) fifty_joker.Enabled = false;
            if (model.audience_spent) audience_joker.Enabled = false;
            if (model.phone_spent) phone_joker.Enabled = false;
            if (model.switch_spent) switch_joker.Enabled = false;

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

        private void disableButton(int index)
        {
            //disables the button with the given index (from 0 to 3 inclusive)
            switch (index)
            {
                case 0:
                    panelA.BackgroundImage = Properties.Resources.leftAnswerDisabled;
                    labelA.Text = "";
                    answerTextA.Text = "";
                    panelA.Enabled = false;
                    break;
                case 1:
                    panelB.BackgroundImage = Properties.Resources.rightAnswerDisabled;
                    labelB.Text = "";
                    answerTextB.Text = "";
                    panelB.Enabled = false;
                    break;
                case 2:
                    panelV.BackgroundImage = Properties.Resources.leftAnswerDisabled;
                    labelV.Text = "";
                    answerTextV.Text = "";
                    panelV.Enabled = false;
                    break;
                case 3:
                    panelG.BackgroundImage = Properties.Resources.rightAnswerDisabled;
                    labelG.Text = "";
                    answerTextG.Text = "";
                    panelG.Enabled = false;
                    break;
            }
        }

        private void enableAllButtons()
        {
            //enables all answers
            panelA.Enabled = panelB.Enabled = panelV.Enabled = panelG.Enabled = true;
            panelA.BackgroundImage = panelV.BackgroundImage = Properties.Resources.leftAnswer;
            panelB.BackgroundImage = panelG.BackgroundImage = Properties.Resources.rightAnswer;
            labelA.Text = "А:";
            labelB.Text = "Б:";
            labelV.Text = "В:";
            labelG.Text = "Г:";
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Кој сака да биде милионер ?\nИзработија:\nДавид Симеоновски\nНикола Танев"), "Кој сака да биде милионер ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //change backround of answer to normal (unselected)
        private void changeBackgroundNormal(Panel backgorund, Label letter, Label answerText, bool isLeft)
        {
            if (isLeft)
            {
                backgorund.BackgroundImage = Properties.Resources.leftAnswer;
            }
            else
            {
                backgorund.BackgroundImage = Properties.Resources.rightAnswer;
            }
            letter.ForeColor = Color.FromArgb(248, 155, 28); //orange;
            answerText.ForeColor = Color.White;
        }

        private void changeBackgroundNormal(int index)
        {
            //helper method
            switch (index)
            {
                case 0:
                    changeBackgroundNormal(panelA, labelA, answerTextA, true);
                    break;
                case 1:
                    changeBackgroundNormal(panelB, labelB, answerTextB, false);
                    break;
                case 2:
                    changeBackgroundNormal(panelV, labelV, answerTextV, true);
                    break;
                case 3:
                    changeBackgroundNormal(panelG, labelG, answerTextG, false);
                    break;
            }
        }

        //change backround of answer to selected
        private void changeBackgroundSelected(Panel backgorund, Label letter, Label answerText, bool isLeft)
        {
            if (isLeft)
            {
                backgorund.BackgroundImage = Properties.Resources.leftAnswerSelect;
            }
            else
            {
                backgorund.BackgroundImage = Properties.Resources.rightAnswerSelect;
            }
            letter.ForeColor = Color.White;
            answerText.ForeColor = Color.Black;
        }

        private void changeBackgroundSelected(int index)
        {
            //helper method
            switch (index)
            {
                case 0:
                    changeBackgroundSelected(panelA, labelA, answerTextA, true);
                    break;
                case 1:
                    changeBackgroundSelected(panelB, labelB, answerTextB, false);
                    break;
                case 2:
                    changeBackgroundSelected(panelV, labelV, answerTextV, true);
                    break;
                case 3:
                    changeBackgroundSelected(panelG, labelG, answerTextG, false);
                    break;
            }
        }

        //change backround of answer to correct
        private void changeBackgroundCorrect(Panel backgorund, Label letter, Label answerText, bool isLeft)
        {
            if (isLeft)
            {
                backgorund.BackgroundImage = Properties.Resources.leftAnswerCorrect;
            }
            else
            {
                backgorund.BackgroundImage = Properties.Resources.rightAnswerCorrect;
            }
            letter.ForeColor = Color.White;
            answerText.ForeColor = Color.Black;
        }

        private void changeBackgroundCorrect(int index)
        {
            //helper method
            switch (index)
            {
                case 0:
                    changeBackgroundCorrect(panelA, labelA, answerTextA, true);
                    break;
                case 1:
                    changeBackgroundCorrect(panelB, labelB, answerTextB, false);
                    break;
                case 2:
                    changeBackgroundCorrect(panelV, labelV, answerTextV, true);
                    break;
                case 3:
                    changeBackgroundCorrect(panelG, labelG, answerTextG, false);
                    break;
            }
        }

        private void answer0_Click(object sender, EventArgs e)
        {
            tryAnswer(0);

            //removing focus of button
            focusLabel.Focus();
        }


        private void answer1_Click(object sender, EventArgs e)
        {
            tryAnswer(1);

            //removing focus of button
            focusLabel.Focus();

        }

        private void answer2_Click(object sender, EventArgs e)
        {
            tryAnswer(2);

            //removing focus of button
            focusLabel.Focus();
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            tryAnswer(3);

            //removing focus of button
            focusLabel.Focus();
        }

        private void showCorrectAnswereMessage(int price, int level)
        {
            CorrectAnswerMessageForm form = new CorrectAnswerMessageForm();
            form.showMessage(price, level);
            form.ShowDialog();
        }

        private void animateCorrect(int index)
        {
            correctIndex = index;
            correctAnswer = true;
            timerTicks = 9; //needs to be set to odd number
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

        public void tryAnswer(int index)
        {
            changeBackgroundSelected(index);
            string answer = model.currentQuestion.answer[index];

            if (finalAnswer(answer))
            {
                if (model.tryAnswer(index))
                {
                    //correct answer
                    animateCorrect(index);
                    showCorrectAnswereMessage(model.getMoney(false), model.level);
                    updateView();
                }
                else
                {
                    //wrong answer
                    animateWrong(model.correct);

                    bool newGameBool = false;
                    if (wrongAnswerMessage(answer, model.currentQuestion.answer[model.correct]))
                    {
                        //player wants new game
                        newGameBool = true;
                        
                    }

                    //reset the correct button first
                    changeBackgroundNormal(model.correct);
                    
                    if(newGameBool) newGame();
                    else playPanel.Hide();
                }
            }
            changeBackgroundNormal(index);
        }

        private bool wrongAnswerMessage(string answer, string correct)
        {
            return MessageBox.Show(string.Format("Одговорот „{0}“ е грешен! Точниот одговор е „{1}“.\n\nВие освоивте {2} денари.\n\nНова игра?", answer, correct, model.getMoney(true)), "Грешен одговор", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private bool serrenderAnswerMessage(string correct)
        {
            return MessageBox.Show(
                string.Format("Точниот одговор на прашањето е „{0}“.\n\nВие освоивте {1} денари.\n\nНова игра ?", correct, model.getMoney(false)), 
                "Се откажавте !", 
                MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private bool finalAnswer(string answer)
        {
            return MessageBox.Show(string.Format("Дали „{0}“ е вашиот конечен одговор ?", answer),"Конечен одговор ?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void surrender_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали навистина сакате да се откажете ?", 
                "Се откажувате ?", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.Yes)
            {

                //TODO: display final score
                if (serrenderAnswerMessage(model.currentQuestion.answer[model.correct]))
                {
                    //playere wants new game
                    newGame();
                }
                else
                {
                    //player doesn't want new game
                    playPanel.Hide();
                }
            }

        }

        private void fifty_joker_Click(object sender, EventArgs e)
        {
            model.joker_fifty();

            //removing focus
            focusLabel.Focus();

            updateView();

        }

        private void audience_joker_Click(object sender, EventArgs e)
        {
            int[] votes = model.joker_audience();

            Audience view = new Audience(votes);
            view.ShowDialog();

            //removing focus
            focusLabel.Focus();

            updateView();
        }

        private void phone_joker_Click(object sender, EventArgs e)
        {
            model.joker_phone();

            //removing focus
            focusLabel.Focus();

            updateView();
        }

        private void switch_joker_Click(object sender, EventArgs e)
        {
            model.joker_switch();

            //removing focus
            focusLabel.Focus();

            updateView();
        }
    }
}