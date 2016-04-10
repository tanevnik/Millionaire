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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            Hide();
            View view = new View();
            view.Show();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Кој сака да биде милионер ?\nИзработија:\nДавид Симеоновски\nНикола Танев"), "Кој сака да биде милионер ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
