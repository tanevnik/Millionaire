using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class WrongAnswerDialog : Form
    {
        public bool newGame;

        public WrongAnswerDialog(string answer, string correct, int prize)
        {
            InitializeComponent();
            messageLable.Text = string.Format("Одговорот {0} е погрешен, точниот одговор е: {1}.\nВие освоивте {2} денари!\nНова игра?", answer, correct, prize);
            newGame = false;
        }

        private void doubleBufferedPanel2_Click(object sender, System.EventArgs e)
        {
            newGame = true;
            Close();
        }

        private void yesLabel_Click(object sender, System.EventArgs e)
        {
            newGame = true;
            Close();
        }

        private void doubleBufferedPanel3_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void noLabel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void hoverOn(Label l, Panel p)
        {
            Cursor = Cursors.Hand;
            l.BackColor = Color.FromArgb(45, 41, 42);
            p.BackColor = Color.FromArgb(120, 153, 215);
        }

        private void hoverOff(Label l, Panel p)
        {
            Cursor = Cursors.Default;
            l.BackColor = Color.FromArgb(35, 31, 32);
            p.BackColor = Color.FromArgb(70, 109, 183);
        }

        private void doubleBufferedPanel2_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel2_MouseLeave(object sender, System.EventArgs e)
        {
            hoverOff(yesLabel, doubleBufferedPanel2);
        }

        private void yesLabel_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel3_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn(noLabel, doubleBufferedPanel3);
        }

        private void doubleBufferedPanel3_MouseLeave(object sender, System.EventArgs e)
        {
            hoverOff(noLabel, doubleBufferedPanel3);
        }

        private void noLabel_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn(noLabel, doubleBufferedPanel3);
        }
    }
}
