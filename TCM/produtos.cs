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
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NOME' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtqt.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'QUANTIDADE' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtvalor.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'VALOR' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int qtde = Convert.ToInt32(txtqt.Text);
                string valor = txtvalor.Text;
                string preco = valor.Replace(".", "").Replace(",", ".");
                int cd = Convert.ToInt32(cmb.SelectedValue);
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_produtos2(cd_categoria,qt_produto,vl_produto,nm_produto)values('" + cd + "','" + qtde + "','" + preco + "','" + txtnome.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Novo produto cadastrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
                finally
                {
                    cn.Close();
                    carregarprod();
                    cmb.SelectedIndex = -1;
                }
            }
        }
        private void carregarprod()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_produtos2";
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

        private void limpar()
        {
            txtnome.Clear();
            txtqt.Clear();
            txtvalor.Clear();
            txtnome.Focus();
        }


        private void carregarcat()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_categoria";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtg2.DataSource = dt;
                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregaCategoria()
        {
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("select cd_categoria, nm_categoria from tbl_categoria order by nm_categoria", cn);
                SqlDataReader leitorCat = cm.ExecuteReader();
                DataTable tabelaCat = new DataTable();
                tabelaCat.Load(leitorCat);
                DataRow linha = tabelaCat.NewRow();
                linha["nm_categoria"] = "";
                tabelaCat.Rows.InsertAt(linha, 0);
                cmb.DataSource = tabelaCat;
                cmb.ValueMember = "cd_categoria";
                cmb.DisplayMember = "nm_categoria";

                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao tentar preencher o campo categoria" + erro, "Ops ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }

        }



        private void produtos_Load(object sender, EventArgs e)
        {

            carregaCategoria();
            carregarprod();
            carregarcat();
            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg2.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtg2.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.Columns[0].HeaderText =

            "Código da Categoria";



            dtg.Columns[1].HeaderText =

            "Código Produto";



            dtg.Columns[2].HeaderText =

            "Estoque";



            dtg.Columns[3].HeaderText =

            "Valor";



            dtg.Columns[4].HeaderText =

            "Nome";



            dtg2.Columns[0].HeaderText =

            "Código";



            dtg2.Columns[1].HeaderText =

            "Categoria";



        }
        private void carregaLinha()
        {
            txtalternome.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtalterqt.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtaltervl.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtcod.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
            btnalter.Enabled = true;
            txtcod.Enabled = false;
        }

        private void btnalter_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Deseja realmentente excluir este registro??", "Alteração de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.No)
            {
                limparprod();
                return;
                
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "delete from tbl_produtos2  where cd_produto = " + txtcod.Text;
                    cm.Connection = cn;
                    MessageBox.Show("Produto deletado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.ExecuteNonQuery();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();

                }

                finally
                {
                    cn.Close();
                    carregarprod();
                    limparprod();
                    cmb.SelectedIndex = -1;

                }
            }
        }
        private void limparprod()
        {
            txtcod.Clear();
            txtalternome.Clear();
            txtaltervl.Clear();
            txtalterqt.Clear();
        }
    }

}
