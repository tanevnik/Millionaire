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
    }
}
