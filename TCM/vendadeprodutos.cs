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
    public partial class vendadeprodutos : Form
    { 
        public vendadeprodutos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;
        private void Form3_Load(object sender, EventArgs e)
        {
            carregardt();
            timer1.Start();

            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.Columns[0].HeaderText =

            "Nome Cliente";



            dtg.Columns[1].HeaderText =

            "RG";



            dtg.Columns[2].HeaderText =

            "Sexo";



            dtg.Columns[3].HeaderText =

            "Numero";



            dtg.Columns[4].HeaderText =

            "CEP";



            dtg.Columns[5].HeaderText =

            "Endereço";



            dtg.Columns[6].HeaderText =

            "Complemento";



            dtg.Columns[7].HeaderText =

            "Numero Casa";

            dtg.Columns[8].HeaderText =

            "Codigo Cliente";
        }

        private void carregardt()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select * from tbl_cliente";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        /*private void carregacliente()
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

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'CODIGO DO PRODUTO'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcod.Focus();
            }
            else if (txtquant.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher a quantidade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquant.Focus();
            }
            else if (txtpesq.Text == "")
            {
                MessageBox.Show("Obrigatorio Selecionar um cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpesquisar.Focus();
            }
            else if (txtpag.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher a forma de pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Focus();
            }
            else if (txtrgfunc.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o RG do funcionario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtrgfunc.Focus();
            }
            else if (txtnomefunc.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o nome do funcionario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Data da venda'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    string nome = txtnomeprod.Text;
                    string valor = txttotal.Text;
                    string qt = txtquant.Text;
                    string pag = txtpag.Text;
                    string nomecli = txtnomecli.Text;
                    string rg = txtpesq.Text;
                    string nomefunc = txtnomefunc.Text;
                    string dt = txtdt.Text;

                    cn.Open();
                    cm.CommandText = "insert into tbl_vendas(nm_produto,vl_total,qt_prod,forma_pag,nm_cliente,rg_cliente,nm_func,dt_venda)values('" + nome + "','" + valor + "','" + qt + "','" + pag + "','" + nomecli + "','" + rg + "','" + nomefunc + "','" + dt + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limpar();
                    MessageBox.Show("Venda realizada com sucesso\npara consultar a venda ou alterar entre na aba 'Vendas'!!!", "Vendido com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
            }
        private void limpar()
        {
            txtdt.Clear();
            txtnomefunc.Clear();
            txtrgfunc.Clear();
            txtnomecli.Clear();
            txtvalor.Clear();
            txttotal.Clear();
            txtquant.Clear();
            txtcod.Clear();
            txtnomeprod.Clear();
            txtpesquisar.Clear();
            txtpesq.Clear();
            txtnum.Clear();
            txtsexo.Clear();
            txtcep.Clear();
            txtend.Clear();
            txtcomple.Clear();
            txtnumcasa.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel1.Width += 4;
            if (panel1.Width >= 986)
            {
                timer1.Stop();
            }
            panel5.Width += 4;
            if (panel5.Width >= 986)
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtquant.Clear();
            txtvalor.Clear();
            txtnomecli.Clear();
            txtrgfunc.Clear();
            txtnomefunc.Clear();
            txtcod.Focus();
        }

        private void carregaLinha()
        {
            txtnomecli.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtpesq.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtsexo.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtnum.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtcep.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtend.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txtcomple.Text = dtg.SelectedRows[0].Cells[6].Value.ToString();
            txtnumcasa.Text = dtg.SelectedRows[0].Cells[7].Value.ToString();
        }


        private void txtpesq_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pesquisa()
        {
            label19.Visible = false;
            txtpesquisar.Visible = false;
            label6.Visible = true;
            txtpesq.Visible = true;
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pesquisa();
            txtpag.Focus();
            txtpesq.Clear();
            carregaLinha();
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtpesquisar.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_cliente where rg_cliente like ('%" + txtpesquisar.Text + "%')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtg.DataSource = dt;
                    cn.Close();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dtg.DataSource = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpesquisar.Clear();
            txtpesquisar.Visible = true;
            label19.Visible = true;
            txtpesq.Visible = false;
            label9.Visible = false;
            txtpesq.Clear();
            txtend.Clear();
            txtsexo.Clear();
            txtnomecli.Clear();
            txtnum.Clear();
            txtnumcasa.Clear();
            txtcomple.Clear();
            txtcep.Clear();
            carregardt();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtcod.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select cd_produto, nm_produto, vl_produto from tbl_produtos2 where cd_produto = " + txtcod.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader(); 
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Produto não cadadstrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcod.Clear();
                        txtcod.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtnomeprod.Text = lerdados["nm_produto"].ToString();
                        txtvalor.Text = lerdados["vl_produto"].ToString();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnomeprod.Text = txtnomeprod.Text;
                    txtvalor.Text = txtvalor.Text;
                    txtquant.Text = "";
                   
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtvalor.Clear();
                txtnomeprod.Clear();
                txtquant.Clear();
                txttotal.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtquant.Text != "")
            {
                int qtde = Convert.ToInt16(txtquant.Text);
                decimal valor = Convert.ToDecimal(txtvalor.Text);
                decimal total = qtde * valor;
                txttotal.Text = total.ToString();
            }
            else
            {
                txttotal.Text = "";
                txtquant.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpag.Text = "Dinheiro";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox2.Enabled = true;
                txtpag.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtpag.Text = "Cartão de débito";
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                txtpag.Clear();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtpag.Text = "Cartão de crédito";
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                txtpag.Clear();
            }
        }

        private void txtrgfunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Height += 2;
            if (panel2.Height >= 542)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel7.Height += 2;
            if (panel7.Height >= 541)
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel9.Width += 4;
            if (panel9.Width >= 985.8)
            {
                timer4.Stop();
            }
        }
    }
    }
