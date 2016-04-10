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
        Model model;

        public View()
        {
            InitializeComponent();
            model = new Model();

            updateQuestion();
        }

        private void updateQuestion()
        {
            //takes the current question from model and displays it
            Question q = model.currentQuestion;
            questionLabel.Text = q.question;
            button1.Text = q.answer[0];
            button2.Text = q.answer[1];
            button3.Text = q.answer[2];
            button4.Text = q.answer[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.tryAnswer(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.tryAnswer(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.tryAnswer(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            model.tryAnswer(3);
        }
    }
}
