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
    public partial class telacliente : Form
    {
        public telacliente()
        {
            InitializeComponent();
        }
        private void abrirjanela(object formvenda)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form venda = formvenda as Form;
            venda.TopLevel = false;
            venda.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(venda);
            this.panel1.Tag = venda;
            venda.Show();
        }

        private void btnserviço_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair do programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja trocar de conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                this.Hide();
                telalogin Form1 = new telalogin();
                Form1.ShowDialog();
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Height += 7;
            if (panel4.Height >= 730)
            {
                timer1.Stop();
            }
        }

        private void btnvendaprodutos_Click(object sender, EventArgs e)
        {
            abrirjanela(new telaclienteprodutos());
            submenuserviços.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirjanela(new suporte());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            abrirjanela(new inicio());
            abrirjanela(new inicio());
            abrirjanela(new inicio());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirjanela(new banho_e_tosa_cliente());
        }
    }
}
