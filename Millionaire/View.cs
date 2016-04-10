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

            //temporary (TODO: make answers on random positions)
            Question q = model.getCurrentQuestion();
            questionLabel.Text = q.question;
            button1.Text = q.correctAns;
            button2.Text = q.wrongAns1;
            button3.Text = q.wrongAns2;
            button4.Text = q.wrongAns3;
        }
    }
}
