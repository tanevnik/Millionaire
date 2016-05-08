﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Konecen : Form
    {
        public bool finalAnswer;
        public Konecen(string answer)
        {
            InitializeComponent();
            text.Text = "Дали " + answer + " е вашиот конечен одговор?";
            finalAnswer = false;
        }

        private void yesLabel_Click(object sender, EventArgs e)
        {
            finalAnswer = true;
            Close();
        }

        private void doubleBufferedPanel2_Click(object sender, EventArgs e)
        {
            finalAnswer = true;
            Close();
        }

        private void doubleBufferedPanel3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void noLabel_Click(object sender, EventArgs e)
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
            p.BackColor = Color.FromArgb(90, 113, 170);
        }

        private void doubleBufferedPanel2_MouseEnter(object sender, EventArgs e)
        {
            hoverOn(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel2_MouseLeave(object sender, EventArgs e)
        {
            hoverOff(yesLabel, doubleBufferedPanel2);
        }

        private void yesLabel_MouseEnter(object sender, EventArgs e)
        {
            hoverOn(yesLabel, doubleBufferedPanel2);
        }

        private void doubleBufferedPanel3_MouseEnter(object sender, EventArgs e)
        {
            hoverOn(noLabel, doubleBufferedPanel3);
        }

        private void doubleBufferedPanel3_MouseLeave(object sender, EventArgs e)
        {
            hoverOff(noLabel, doubleBufferedPanel3);
        }

        private void noLabel_MouseEnter(object sender, EventArgs e)
        {
            hoverOn(noLabel, doubleBufferedPanel3);
        }
    }
}
