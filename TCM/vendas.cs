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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void carregarvendacli()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_vendas";
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
        private void carregaLinha()
        {
            txtcod.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnomeprod.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtvl.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtqt.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtfmpag.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtnomecli.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txtrg.Text = dtg.SelectedRows[0].Cells[6].Value.ToString();
            txtnmfunc.Text = dtg.SelectedRows[0].Cells[7].Value.ToString();
            txtdata.Text = dtg.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void habilitarcompos()
        {
            txtcod.Enabled = false;
            txtnomecli.Enabled = true;
            txtnomeprod.Enabled = true;
            txtrg.Enabled = false;
            txtqt.Enabled = true;
            txtfmpag.Enabled = true;
            txtvl.Enabled = true;
        }

        private void habilitarbtn()
        {
            btncancel.Enabled = true;   
            btndel.Enabled = true;
            btnsave.Enabled = true;
            btncomentre.Enabled = true;
        }

        private void desabilitarcampos()
        {
            txtvl.Enabled = false;
            txtrg.Enabled = false;
            txtnomeprod.Enabled = false;
            txtnomecli.Enabled = false;
            txtfmpag.Enabled = false;
            txtqt.Enabled = false;
            txtcod.Enabled = false;
        }

        private void limparcompos()
        {
            txtcod.Clear();
            txtdata.Clear();
            txtcomple.Clear();
            txtfmpag.Clear();
            txtnmfunc.Clear();
            txtnomecli.Clear();
            txtend.Clear();
            txtcomple.Focus();
            txtno.Clear();
            txtnomeprod.Clear();
            txtqt.Clear();
            txtrg.Clear();
            txtvl.Clear();
        }

        private void desabilitarbtn()
        {
            btnalter.Enabled = false;
            btncancel.Enabled = false;
            btndel.Enabled = false;
            btnsave.Enabled = false;
        }

        private void vendas_Load(object sender, EventArgs e)
        {
            carregarvendacli();
            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.Columns[0].HeaderText =

            "Código Pedido";



            dtg.Columns[1].HeaderText =

            "Nome Produto";



            dtg.Columns[2].HeaderText =

            "Valor Total";



            dtg.Columns[3].HeaderText =

            "Quantidade";



            dtg.Columns[4].HeaderText =

            "Forma Pagamento";



            dtg.Columns[5].HeaderText =

            "Nome Cliente";



            dtg.Columns[6].HeaderText =

            "RG Cliente";



            dtg.Columns[7].HeaderText =

            "Nome Funcionario";

            dtg.Columns[8].HeaderText =

            "Data da venda";
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
            btnalter.Enabled = true;
        }

        private void btnalter_Click(object sender, EventArgs e)
        {
            habilitarcompos();
            habilitarbtn();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            desabilitarcampos();
            limparcompos();
            desabilitarbtn();
            dtg.Focus();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Deseja realmentente excluir este registro??", "Alteração de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "delete from tbl_vendas  where cd_pedido = " + txtcod.Text;
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limparcompos();
                    btncomentre.Visible = true;
                    btncomentre.Enabled = false;
                    desabilitarcampos();
                    desabilitarbtn();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }

                finally
                {
                    cn.Close();
                    carregarvendacli();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Código'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtnomeprod.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Nome do produto'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtnomecli.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Nome Cliente'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtend.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Nome Cliente'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string nome = txtnomeprod.Text;
                    string nomecli = txtnomecli.Text;
                    string rg = txtrg.Text;
                    string end = txtend.Text;
                    string no = txtno.Text;
                    string comple = txtcomple.Text;
                    string qt = txtqt.Text;
                    string dt = txtdata.Text;

                    cn.Open();
                    cm.CommandText = "insert into tbl_entregas(nm_produto,nm_cliente,rg_cliente,endereço,no_casa,comple,qt_prod,dt_venda)values('" + nome + "','" + nomecli + "','" + rg + "','" + end + "','" + no + "','" + comple + "','" + qt + "','" + dt + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Venda encaminhada para entregas!!!", "Vendido com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                try
                {
                    cn.Open();
                    cm.CommandText = "delete from tbl_vendas  where cd_pedido = " + txtcod.Text;
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limparcompos();
                    btnentrega.Visible = false;
                    btncomentre.Visible = true;
                    btncomentre.Enabled = false;
                    desabilitarcampos();
                    desabilitarbtn();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }

                finally
                {
                    cn.Close();
                    carregarvendacli();
                }
            }
        }

        private void btncomentre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confira os campos:\n-Endereço,\n-Numero da casa,\n-Complemento\nE clique em 'Encaminhar para delivery' para continuar '", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btncomentre.Visible = false;
            btnentrega.Visible = true;
            btnentrega.Enabled = true;
        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {
            if (txtrg.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select rg_cliente,endereço, no_casa, complemento from tbl_cliente where rg_cliente = " + txtrg.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Não a endereço no cadastro do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcod.Clear();
                        txtcod.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtend.Text = lerdados["endereço"].ToString();
                        txtcomple.Text = lerdados["complemento"].ToString();
                        txtno.Text = lerdados["no_casa"].ToString();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtend.Text = txtend.Text;
                    txtcomple.Text = txtcomple.Text;
                    txtno.Text = txtno.Text;

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnomeprod.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NOME DO PRODUTO'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomeprod.Focus();
            }
            else if (txtvl.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'VALOR'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvl.Focus();
            }
            else if (txtqt.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'QUANTIDADE'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtqt.Focus();
            }
            else if (txtfmpag.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'FORMA DE PAGAMENTO'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfmpag.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_vendas set nm_produto = @nmprd,vl_total = @vl,qt_prod = @qt,forma_pag = @fm where cd_pedido = " + txtcod.Text;
                    cm.Parameters.Add("@nmprd", SqlDbType.VarChar).Value = txtnomeprod.Text;
                    cm.Parameters.Add("@vl", SqlDbType.VarChar).Value = txtvl.Text;
                    cm.Parameters.Add("@qt", SqlDbType.VarChar).Value = txtqt.Text;
                    cm.Parameters.Add("@fm", SqlDbType.VarChar).Value = txtfmpag.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    btnalter.Visible = true;
                    limparcompos();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Parameters.Clear();
                    cn.Close();
                }


                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    carregarvendacli();
                }

            }
        }
    }
}