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
            Question q = model.currentQuestion;
            answer1.Enabled = answer2.Enabled = answer3.Enabled = answer4.Enabled = true;
            questionLabel.Text = q.question;
            answer1.Text = q.answer[0];
            answer2.Text = q.answer[1];
            answer3.Text = q.answer[2];
            answer4.Text = q.answer[3];

            //update jokers
            if (model.fifty_spent) fifty_joker.Enabled = false;
            if (model.audience_spent) audience_joker.Enabled = false;
            if (model.phone_spent) phone_joker.Enabled = false;
            if (model.switch_spent) switch_joker.Enabled = false;

            //check for joker 50-50
            if (model.fifty_active)
            {
                //joker 50-50 is active
                if (model.fifty_wrong1 == 0 || model.fifty_wrong2 == 0) answer1.Enabled = false;
                if (model.fifty_wrong1 == 1 || model.fifty_wrong2 == 1) answer2.Enabled = false;
                if (model.fifty_wrong1 == 2 || model.fifty_wrong2 == 2) answer3.Enabled = false;
                if (model.fifty_wrong1 == 3 || model.fifty_wrong2 == 3) answer4.Enabled = false;
            }

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
                    updateView();
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

        private void surrender_btn_Click(object sender, EventArgs e)
        {
            //TODO: display final score
            playPanel.Hide();
            
        }

        private void fifty_joker_Click(object sender, EventArgs e)
        {
            model.joker_fifty();
            updateView();
        }

        private void audience_joker_Click(object sender, EventArgs e)
        {
            model.joker_audience();
            updateView();
        }

        private void phone_joker_Click(object sender, EventArgs e)
        {
            model.joker_phone();
            updateView();
        }

        private void switch_joker_Click(object sender, EventArgs e)
        {
            model.joker_switch();
            updateView();
        }
    }
}