using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class SurrenderDialog : Form
    {
        public bool confirm;

        public SurrenderDialog()
        {
            InitializeComponent();
            confirm = false;
        }

        private void no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            confirm = true;
            Close();
        }
        
        //BUTTON HOVER
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
            p.BackColor = Color.FromArgb(90, 113, 170);
        }

        private void doubleBufferedPanel2_MouseEnter(object sender, EventArgs e)
        {
            hoverOff(noLabel, doubleBufferedPanel3);
            hoverOn(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel2_MouseLeave(object sender, EventArgs e)
        {
            hoverOff(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel3_MouseEnter(object sender, EventArgs e)
        {
            hoverOff(yesLabel, doubleBufferedPanel2);
            hoverOn(noLabel, doubleBufferedPanel3);
        }

        private void doubleBufferedPanel3_MouseLeave(object sender, EventArgs e)
        {
            hoverOff(noLabel, doubleBufferedPanel3);
        }

        private void reset_hover(object sender, EventArgs e)
        {
            hoverOff(noLabel, doubleBufferedPanel3);
            hoverOff(yesLabel, doubleBufferedPanel2);
        }
    }
}
