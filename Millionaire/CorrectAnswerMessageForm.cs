using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class CorrectAnswerMessageForm : Form
    {
        public CorrectAnswerMessageForm(int prize, int level)
        {
            InitializeComponent();
            if (level == 5 || level == 10)
            {
                messageLabel.Text = string.Format("Освоивте загарантирана сума од {0} денари!", prize);
            }
            else
            {
                messageLabel.Text = string.Format("Освоивте {0} денари!", prize);
            }
            closeTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            Close();
        }
    }
}
