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
            model.tryAnswer(0);
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            model.tryAnswer(1);
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            model.tryAnswer(2);
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            model.tryAnswer(3);
        }
    }
}
