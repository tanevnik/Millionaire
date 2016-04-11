using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            playPanel.Show();

            model = new Model();
            updateQuestion();
        }

        private void updateQuestion()
        {
            //takes the current question from model and displays it

            answer1.Enabled = true;
            answer2.Enabled = true;
            answer3.Enabled = true;
            answer4.Enabled = true;

            Question q = model.currentQuestion;
            questionLabel.Text = q.question;
            answer1.Text = q.answer[0];
            answer2.Text = q.answer[1];
            answer3.Text = q.answer[2];
            answer4.Text = q.answer[3];
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
            if (finalAnswer(answer1.Text))
            {
                if (model.tryAnswer(0))
                {
                    updateQuestion();
                }
            }
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (finalAnswer(answer2.Text))
            {
                if (model.tryAnswer(1))
                {
                    updateQuestion();
                }
            }
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            if (finalAnswer(answer3.Text))
            {
                if (model.tryAnswer(2))
                {
                    updateQuestion();
                }
            }
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            if (finalAnswer(answer4.Text))
            {
                if (model.tryAnswer(3))
                {
                    updateQuestion();
                }
            }
        }
        
        private bool finalAnswer(string answer)
        {
            return MessageBox.Show(string.Format("Дали „{0}“ е вашиот конечен одговор ?", answer),"Конечен одговор ?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void serrender_btn_Click(object sender, EventArgs e)
        {
            //TODO: dysplay final score
            playPanel.Hide();
            
        }

        private void split_joker_Click(object sender, EventArgs e)
        {
            int indexOfCorrectAnswer = model.correct;
            Random random = new Random();

            int wrongAnswers = 0;
            int tmpIndex = 0;
            while(wrongAnswers < 2)
            {
                tmpIndex = random.Next(4);
                if(tmpIndex != model.correct)
                {
                    wrongAnswers++;
                    disable2WrongAnswers(tmpIndex);
                }
            }
            split_joker.Enabled = false;
        }

        private void disable2WrongAnswers(int index)
        {
            if (index == 0)
            {
                answer1.Enabled = false;
            }
            else if (index == 1)
            {
                answer2.Enabled = false;
            }
            else if (index == 2)
            {
                answer3.Enabled = false;
            }
            else if (index == 4)
            {
                answer4.Enabled = false;
            }
        }
    }
}
