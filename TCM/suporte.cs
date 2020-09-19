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
    public partial class suporte : Form
    {
        public suporte()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            //MessageBox.Show("Você sera redirecionado ao nosso site", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void suporte_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(47, 9, "https://www.instagram.com/systemstrength/");
            linkLabel1.Links.Add(58, 9, "https://www.facebook.com/System-Strength-109196077475056");
            linkLabel1.Links.Add(68, 9, "https://www.linkedin.com/in/system-strength-4299731aa/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 15;
            if (panel7.Width >= 580)
            {
                timer1.Stop();
            }
            panel7.Width += 15;
            if (panel7.Width >= 610)
            {
                timer1.Stop();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Height += 5;
            if (panel4.Height >= 210)
            {
                timer2.Stop();
            }
            panel8.Height += 5;
            if (panel8.Height >= 210)
            {
                timer2.Stop();
            }


        }
    }
}
