using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Phone : Form
    {
        public Phone(int index, string answer, int certainty)
        {
            InitializeComponent();
            string letter = "";
            if (index == 0) letter = "А";
            else if (index == 1) letter = "Б";
            else if (index == 1) letter = "В";
            else letter = "Г";
            text.Text = string.Format("Мислам дека точниот одговор е под {0}: „{1}“ со сигурност: {2}%.", letter, answer, certainty);
        }

        private void close_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void hoverOn()
        {
            Cursor = Cursors.Hand;
            label.BackColor = Color.FromArgb(45, 41, 42);
            panel.BackColor = Color.FromArgb(120, 153, 215);
        }

        private void hoverOff()
        {
            Cursor = Cursors.Default;
            label.BackColor = Color.FromArgb(35, 31, 32);
            panel.BackColor = Color.FromArgb(100, 133, 195);
        }

        private void doubleBufferedPanel1_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn();
        }

        private void doubleBufferedPanel1_MouseLeave(object sender, System.EventArgs e)
        {
            hoverOff();
        }

        private void label1_MouseEnter(object sender, System.EventArgs e)
        {
            hoverOn();
        }
    }
}
