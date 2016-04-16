using System;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Audience : Form
    {
        public Audience(int[] votes)
        {
            InitializeComponent();
            label1.Text = votes[0] + "%";
            label2.Text = votes[1] + "%";
            label3.Text = votes[2] + "%";
            label4.Text = votes[3] + "%";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
