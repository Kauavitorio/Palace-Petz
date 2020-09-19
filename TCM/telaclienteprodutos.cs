using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCM
{
    public partial class telaclienteprodutos : Form
    {
        public telaclienteprodutos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Height += 5;
            if (panel4.Height >= 609)
            {
                timer1.Stop();
            }
            panel3.Height += 5;
            if (panel3.Height >= 258)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel8.Width += 7;
            if (panel8.Left >= 316)
            {
                timer2.Stop();
            }
            panel7.Width += 7;
            if (panel7.Width >= 309)
            {
                timer2.Stop();
            }
        }
        private void carregaprod()
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("select cd_produto, nm_produto from tbl_produtos2 order by nm_produto", cn);
                SqlDataReader leitorCat = cm.ExecuteReader();
                DataTable tabelaCat = new DataTable();
                tabelaCat.Load(leitorCat);
                DataRow linha = tabelaCat.NewRow();
                linha["nm_produto"] = "";
                tabelaCat.Rows.InsertAt(linha, 0);
                comboBox1.DataSource = tabelaCat;
                comboBox1.ValueMember = "cd_produto";
                comboBox1.DisplayMember = "nm_produto";

                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher o campo categoria" + erro, "Ops ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }

        }

        private void limparcampos()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            txtnome.Clear();
            txtqt.Clear();
            txtvl.Clear();
        }

        private void carregacliente()
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("select cd_cliente, rg_cliente from tbl_cliente order by rg_cliente", cn);
                SqlDataReader leitorCat = cm.ExecuteReader();
                DataTable tabelaCat = new DataTable();
                tabelaCat.Load(leitorCat);
                DataRow linha = tabelaCat.NewRow();
                linha["rg_cliente"] = "";
                tabelaCat.Rows.InsertAt(linha, 0);
                comboBox2.DataSource = tabelaCat;
                comboBox2.ValueMember = "rg_cliente";
                comboBox2.DisplayMember = "nm_cliente";

                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher o campo categoria" + erro, "Ops ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }

        }
        /*private void carreganmcliente()
        {
            int cd = Convert.ToInt32(comboBox2.SelectedValue);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("select from tbl_cliente where nm_clientel like ('%" + cd + "%')", cn);

                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher o campo categoria" + erro, "Ops ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }

        }*/

        private void telaclienteprodutos_Load(object sender, EventArgs e)
        {
            carregaprod();
            carregacliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtqt.Text == "")
            {
                MessageBox.Show("É necessario prencher o campo 'QUANTIDADE'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int qtde = Convert.ToInt32(txtqt.Text);
                string valor = txtvl.Text;
                string preco = valor.Replace(".", "").Replace(",", ".");
                int cd = Convert.ToInt32(comboBox2.SelectedValue);
                int nmprod = Convert.ToInt32(comboBox1.SelectedValue);
                int pag = Convert.ToInt32(comboBox3.SelectedValue);
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_pedidocliente(nm_cliente,rg_cliente,vl_compra,nm_produto,fm_pagamaneto)values('" + txtnome.Text + "','" + cd + "','" + preco + "','" + nmprod + "','" + pag + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cn.Close();
                    limparcampos();
                    MessageBox.Show("Seu pedido foi realizado com sucesso!!\nProcure um atendente em nossa loja para retirar seu produto!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
        }
    }
}
