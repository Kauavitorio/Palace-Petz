using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void relogio_Click(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.relogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Height += 8;
            if (panel4.Height >= 430)
            {
                timer2.Stop();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel7.Width += 10;
            if (panel7.Width >= 787)
            {
                timer3.Stop();
            }
        }
    }
}
