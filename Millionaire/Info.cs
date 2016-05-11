using System;
using System.Drawing;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            label1.Text = "Кој сака да биде милионер\nПроектна задача по предметот визуелно програмирање на ФИНКИ изработена од студентите:\nДавид Симеоновски\nНикола Танев\nИзработено: април и мај 2016";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //HOVER
        private void hoverOn(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            okLabel.BackColor = Color.FromArgb(45, 41, 42);
            okBorder.BackColor = Color.FromArgb(120, 153, 215);
        }

        private void hoverOff(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            okLabel.BackColor = Color.FromArgb(35, 31, 32);
            okBorder.BackColor = Color.FromArgb(90, 113, 170);
        }
    }
}
