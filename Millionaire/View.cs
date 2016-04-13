using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class View : Form
    {
        private Model model;

        public View()
        {
            InitializeComponent();
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            playPanel.Show();
            model = new Model();
            updateQuestion();

            //reset the used jokers from previous game
            split_joker.Enabled = true;
            audience_joker.Enabled = true;
            phone_joker.Enabled = true;
            switch_joker.Enabled = true;
        }

        private void updateQuestion()
        {
            //takes the current question from model and displays it

            answer1.Enabled = true;
            answer2.Enabled = true;
            answer3.Enabled = true;
            answer4.Enabled = true;

            //update question
            Question q = model.currentQuestion;
            questionLabel.Text = q.question;
            answer1.Text = q.answer[0];
            answer2.Text = q.answer[1];
            answer3.Text = q.answer[2];
            answer4.Text = q.answer[3];

            //update level
            levelLabel.Text = "" + (model.level + 1);
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Кој сака да биде милионер ?\nИзработија:\nДавид Симеоновски\nНикола Танев"), "Кој сака да биде милионер ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            tryAnswer(0);
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            tryAnswer(1);
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            tryAnswer(2);
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            tryAnswer(3);
        }

        public void tryAnswer(int index)
        {
            String answer = "";
            if (index == 0) answer = answer1.Text;
            else if (index == 1) answer = answer2.Text;
            else if (index == 2) answer = answer3.Text;
            else if (index == 3) answer = answer4.Text;

            if (finalAnswer(answer))
            {
                if (model.tryAnswer(index))
                {
                    //correct answer
                    updateQuestion();
                }
                else
                {
                    //wrong answer
                    if (wrongAnswerMessage(answer, model.currentQuestion.answer[model.correct]))
                    {
                        //player wants new game
                        newGame();
                    }
                    else
                    {
                        //player doesn't want new game
                        playPanel.Hide();
                    }

                    //TODO animations
                }
            }
        }

        private bool wrongAnswerMessage(string answer, string correct)
        {
            return MessageBox.Show(string.Format("Одговорот „{0}“ е грешен! Точниот одговор е „{1}“.\n\nВие освоивте {2} денари.\n\nНова игра?", answer, correct, model.getMoney(true)), "Грешен одговор", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private bool finalAnswer(string answer)
        {
            return MessageBox.Show(string.Format("Дали „{0}“ е вашиот конечен одговор ?", answer),"Конечен одговор ?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void serrender_btn_Click(object sender, EventArgs e)
        {
            //TODO: display final score
            playPanel.Hide();
            
        }

        private void split_joker_Click(object sender, EventArgs e)
        {
            //disables 2 wrong answers by random
            int indexOfCorrectAnswer = model.correct;
            Random random = new Random();

            //disable the first wrong answer
            int first = random.Next(3);
            if (first >= indexOfCorrectAnswer) first++;
            disableAnswer(first);

            //disable the second wrong answer
            int second = random.Next(2);
            if(second >= indexOfCorrectAnswer)
            {
                second++;
                if (second >= first) second++;
            }
            else if(second >= first)
            {
                second++;
                if (second >= indexOfCorrectAnswer) second++;
            }
            disableAnswer(second);

            //disable the joker for next questions
            split_joker.Enabled = false;
        }

        private void disableAnswer(int index)
        {
            if (index == 0) answer1.Enabled = false;
            else if (index == 1) answer2.Enabled = false;
            else if (index == 2) answer3.Enabled = false;
            else if (index == 3) answer4.Enabled = false;
        }
    }
}
