using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Audience : Form
    {
        public Audience(int[] votes)
        {
            int maxBarHeight = 150;

            InitializeComponent();
            label0.Text = votes[0] + "%";
            label1.Text = votes[1] + "%";
            label2.Text = votes[2] + "%";
            label3.Text = votes[3] + "%";

            //TODO add animation of bars rising!

            //Calculating the heights of the bars
            int[] barHeight = new int[4];
            for(int i = 0; i<4; i++) barHeight[i] = votes[i] * maxBarHeight / 100;

            //Setting the height of the bars
            bar0.Height = barHeight[0];
            bar1.Height = barHeight[1];
            bar2.Height = barHeight[2];
            bar3.Height = barHeight[3];

            //Setting the Y location of the bars
            bar0.Location = new Point(bar0.Location.X, bar0.Location.Y + (maxBarHeight - votes[0] * maxBarHeight / 100));
            bar1.Location = new Point(bar1.Location.X, bar1.Location.Y + (maxBarHeight - votes[1] * maxBarHeight / 100));
            bar2.Location = new Point(bar2.Location.X, bar2.Location.Y + (maxBarHeight - votes[2] * maxBarHeight / 100));
            bar3.Location = new Point(bar3.Location.X, bar3.Location.Y + (maxBarHeight - votes[3] * maxBarHeight / 100));
        }

        private void close_Click(object sender, EventArgs e)
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

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            hoverOn();
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            hoverOff();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            hoverOn();
        }
    }
}
