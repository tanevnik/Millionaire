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
    public partial class CorrectAnswerMessageForm : Form
    {
        public CorrectAnswerMessageForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeButton.PerformClick();
            closeTimer.Stop();
        }

        public void showMessage(int price, int level)
        {
            if(level == 5 || level == 10)
            {
                messageLabel.Text = string.Format("Загарантирана сума од {0} денари !", price);
            }
            else
            {
                messageLabel.Text = string.Format("Освоивте {0} денари !", price);
            }
            closeTimer.Start();
        }
    }
}
