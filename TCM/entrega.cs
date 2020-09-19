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
    public partial class entrega : Form
    {
        public entrega()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void carregarentregas()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_entregas";
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
        private void entrega_Load(object sender, EventArgs e)
        {
            txtcod.Focus();
            carregarentregas();
            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.Columns[0].HeaderText =

            "Código Pedio";



            dtg.Columns[1].HeaderText =

            "Nome Produto";



            dtg.Columns[2].HeaderText =

            "Nome Cliente";



            dtg.Columns[3].HeaderText =

            "RG Cliente";



            dtg.Columns[4].HeaderText =

            "Endereço";



            dtg.Columns[5].HeaderText =

            "Numero Casa";



            dtg.Columns[6].HeaderText =

            "Complemento";



            dtg.Columns[7].HeaderText =

            "Quantidade";

            dtg.Columns[8].HeaderText =

            "Data da Venda";
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            if (txtcod.Text.Length >= 3)
            {
                try
                {
                    cn.Open();

                    string strsql = "select cd_pedido, nm_cliente, endereço, qt_prod, no_casa from tbl_entregas where cd_pedido = " + txtcod.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Pedido não cadadstrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcod.Clear();
                        txtcod.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtnome.Text = lerdados["nm_cliente"].ToString();
                        txtend.Text = lerdados["endereço"].ToString();
                        txtqt.Text = lerdados["qt_prod"].ToString();
                        txtno.Text = lerdados["no_casa"].ToString();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtqt.Text = txtqt.Text;
                    txtnome.Text = txtnome.Text;
                    txtend.Text = txtend.Text;
                    txtno.Text = txtno.Text;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void carregaLinha()
        {
            txtcod.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnome.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtend.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtno.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txtqt.Text = dtg.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void limpar()
        {
            txtcod.Clear();
            txtend.Clear();
            txtnome.Clear();
            txtqt.Clear();
            txtno.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (txtnome.Text == "")
                {
                    MessageBox.Show("Pedido não reconheico ou invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcod.Focus();

                }
                else
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "delete from tbl_entregas  where cd_pedido = " + txtcod.Text;
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Pedido entregue/encaminhado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcod.Focus();
                    }


                    catch (Exception erro)
                    {
                        MessageBox.Show("Digite o código do pedido", erro.Message);

                    }


                    finally
                    {
                        cn.Close();
                        carregarentregas();
                        limpar();
                        txtcod.Focus();
                    }

                }
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
        }
    }
}
