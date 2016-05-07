using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Audience : Form
    {
        double[] increment;
        double[] current;
        double maxBarHeight;
        int tickCounter;
        int defaultY;
        int[] votes;

        public Audience(int[] v)
        {
            votes = v;
            InitializeComponent();
            maxBarHeight = 150;
            tickCounter = 0;
            defaultY = bar0.Location.Y + 2;

            label0.Text = votes[0] + "%";
            label1.Text = votes[1] + "%";
            label2.Text = votes[2] + "%";
            label3.Text = votes[3] + "%";

            //Calculating the heights of the bars
            double[] barHeight = new double[4];
            current = new double[4];
            increment = new double[4];
            for (int i = 0; i<4; i++) barHeight[i] = votes[i] * maxBarHeight / 100;

            for (int i = 0; i < 4; i++) current[i] = 0;
            for (int i = 0; i < 4; i++) increment[i] = barHeight[i] / 30;

            timer.Start();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tickCounter == 30) ((Timer)sender).Dispose();

            Console.WriteLine(tickCounter);
            tickCounter++;

            for (int i = 0; i < 4; i++) current[i] += increment[i];

            Console.WriteLine(current[0] + " " + current[1] + " " + current[2] + " " + current[3]);

            DrawingControl.SuspendDrawing(panel1);
            bar0.Location = new Point(bar0.Location.X, defaultY + (int)(maxBarHeight - current[0]));
            bar0.Height = (int) current[0];
            bar1.Location = new Point(bar1.Location.X, defaultY + (int)(maxBarHeight - current[1]));
            bar1.Height = (int) current[1];
            bar2.Location = new Point(bar2.Location.X, defaultY + (int)(maxBarHeight - current[2]));
            bar2.Height = (int) current[2];
            bar3.Location = new Point(bar3.Location.X, defaultY + (int)(maxBarHeight - current[3]));
            bar3.Height = (int) current[3];
            DrawingControl.ResumeDrawing(panel1);
            Invalidate();

        }
    }
}
