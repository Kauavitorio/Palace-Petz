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
using System.Xml.Serialization;

namespace TCM
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();



        private void cliente_Load(object sender, EventArgs e)
        {
            txtpesquisa.Focus();
            carregardt();
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

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void limpaCampos()
        {
            txtcep.Clear();
            txtcomplemento.Clear();
            txtende.Clear();
            txtnome.Clear();
            txtnum.Clear();
            txtpesquisa.Clear();
            txtnumcasa.Clear();
            txtrg.Clear();
            txtsexo.Clear();
        }
        private void desabilitarcampos()
        {
            txtcep.Enabled = false;
            btnalter.Enabled = false;
            txtende.Enabled = false;
            txtnome.Enabled = false;
            txtcomplemento.Enabled = false;
            txtnum.Enabled = false;
            txtnumcasa.Enabled = false;
            txtrg.Enabled = false;
            txtsexo.Enabled = false;
            btnalter.Enabled = true;
            btncancel.Enabled = false;
            btndel.Enabled = false;
            btnsave.Enabled = false;
        }

        private void habilitarcampos()
        {
            txtcep.Enabled = true;
            txtende.Enabled = true;
            txtnome.Enabled = true;
            txtnum.Enabled = true;
            txtnumcasa.Enabled = true;
            txtpesquisa.Enabled = true;
            txtrg.Enabled = false;
            txtsexo.Enabled = true;
            btnalter.Enabled = false;
            btncancel.Enabled = true;
            btndel.Enabled = true;
            btnsave.Enabled = true;
            txtrg.Focus();
        }
        private void carregaLinha()
        {
            txtnumcasa.Text = dtg.SelectedRows[0].Cells[7].Value.ToString();
            txtsexo.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtnome.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtcep.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtrg.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtende.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txtcomplemento.Text = dtg.SelectedRows[0].Cells[6].Value.ToString();
            txtnum.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtpesquisa.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_cliente where rg_cliente like ('%" + txtpesquisa.Text + "%')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtg.DataSource = dt;
                    cn.Close();
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

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
            btnalter.Enabled = true;
        }

        private void btnalter_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            txtcomplemento.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtrg.Text == "") 
            {
                MessageBox.Show("Obrigatório preencher o campo 'RG'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }

            else if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NOME'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus(); 
            }

            else if (txtcep.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'CEP'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcep.Focus();
            }
            else if (txtnum.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NUMERO TELEFONE'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnum.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_cliente set nm_cliente = @nmcli,rg_cliente = @rg,sx_cliente = @sx,no_cliente = @num,cep_cliente =@cep,endereço = @end,complemento = @comple,no_casa = @numcasa where rg_cliente = " + txtrg.Text;
                    cm.Parameters.Add("@nmcli", SqlDbType.VarChar).Value = txtnome.Text;
                    cm.Parameters.Add("@rg", SqlDbType.VarChar).Value = txtrg.Text;
                    cm.Parameters.Add("@sx", SqlDbType.VarChar).Value = txtsexo.Text;
                    cm.Parameters.Add("@num", SqlDbType.VarChar).Value = txtnum.Text;
                    cm.Parameters.Add("@cep", SqlDbType.VarChar).Value = txtcep.Text;
                    cm.Parameters.Add("@end", SqlDbType.VarChar).Value = txtende.Text;
                    cm.Parameters.Add("@comple", SqlDbType.VarChar).Value = txtcomplemento.Text;
                    cm.Parameters.Add("@numcasa", SqlDbType.VarChar).Value = txtnumcasa.Text;

                    cm.Connection = cn; 
                    cm.ExecuteNonQuery();  
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();
                    desabilitarcampos();
                    txtpesquisa.Focus();
                    cm.Parameters.Clear();
                    cn.Close();
                }


                catch (Exception erro) 
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        
        
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
                    cm.CommandText = "delete from tbl_cliente  where rg_cliente = " + txtrg.Text;
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limpaCampos();
                    desabilitarcampos();
                    txtpesquisa.Focus();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }

                finally
                {
                    cn.Close();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            desabilitarcampos();
            limpaCampos();
            btnalter.Enabled = false;
            txtpesquisa.Focus();
            carregardt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpesquisa.Focus();
            carregardt();
        }
    }
}
