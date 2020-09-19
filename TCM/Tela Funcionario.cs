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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbboxtipopesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(cbboxtipopesquisa.Text == "Codigo")
            {
                labelcoigobuscar.Visible = true;
                txtcprod.Visible = true;
            }
            else
            {
                labelcoigobuscar.Visible = false;
                txtcprod.Visible = false;
            }*/
        }

        private void btnserviço_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = true;
        }

        private void btnbanho_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = false;
        }

        private void btntosa_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = false;
        }

        private void btnprodutos_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = false;
            abrirjanela(new vendadeprodutos());
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

        private void btninicio_Click(object sender, EventArgs e)
        {
            abrirjanela(new inicio());
            abrirjanela(new inicio());
            abrirjanela(new inicio());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirjanela(new novocliente());
            abrirjanela(new novocliente());
            abrirjanela(new novocliente());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            submenuserviços.Visible = false;
            abrirjanela(new banho_e_tosa());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnaron_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair do programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void relogio_Click(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.relogio.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void button7_Click(object sender, EventArgs e)
        {
            abrirjanela(new funcionario());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirjanela(new entrega());
            submenuserviços.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirjanela(new cliente());
        }

        private void btnproutos_Click(object sender, EventArgs e)
        {
            abrirjanela(new produtos());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            abrirjanela(new inicio());
            abrirjanela(new inicio());
            abrirjanela(new inicio());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            abrirjanela(new vendas());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirjanela(new suporte());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        }
}
