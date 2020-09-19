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
    public partial class banho_e_tosa : Form
    {
        public banho_e_tosa()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();

        private void banho_CheckedChanged(object sender, EventArgs e)
        {
            if (banho.Checked == true)
            {
                tosa.Enabled = false;
                ambos.Enabled = false;
                txtserv.Text = "Banho";
            }
            else
            {
                tosa.Enabled = true;
                ambos.Enabled = true;
                txtserv.Text = "";

            }
        }

        private void tosa_CheckedChanged(object sender, EventArgs e)
        {
            if (tosa.Checked == true)
            {
                banho.Enabled = false;
                ambos.Enabled = false;
                txtserv.Text = "Tosa";
            }
            else
            {
                banho.Enabled = true;
                ambos.Enabled = true;
                txtserv.Text = "";
            }
        }

        private void ambos_CheckedChanged(object sender, EventArgs e)
        {
            if (ambos.Checked == true)
            {
                banho.Enabled = false;
                tosa.Enabled = false;
                txtserv.Text = "Ambos";
            }
            else
            {
                banho.Enabled = true;
                tosa.Enabled = true;
                txtserv.Text = "";
            }
        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {
            if (txtrg.Text != "")
            {

                try
                {
                    cn.Open();
                    cm.CommandText = "select nm_cliente,rg_cliente from tbl_cliente where rg_cliente like ('%" + txtrg.Text + "%')";
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
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
            private void txtrgfunc_TextChanged(object sender, EventArgs e)
        {
            if (txtrgfunc.Text != "")
            {

                try
                {
                    cn.Open();
                    cm.CommandText = "select nm_funcionario,rg_funcionario from tbl_funcionario where rg_funcionario like ('%" + txtrgfunc.Text + "%')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtg2.DataSource = dt;
                    cn.Close();
                    dtg2.RowsDefaultCellStyle.BackColor =

                    Color.Black;


                    dtg2.DefaultCellStyle.ForeColor =
                        Color.White;

                    dtg2.Columns[0].HeaderText =

                    "Nome Cliente";



                    dtg2.Columns[1].HeaderText =

                    "RG";
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void carregarfunc()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select nm_cliente,rg_cliente from tbl_cliente ";
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
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        
        private void carregarcliente()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select nm_funcionario,rg_funcionario from tbl_funcionario ";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtg2.DataSource = dt;
                cn.Close();
                dtg2.RowsDefaultCellStyle.BackColor =

                Color.Black;


                dtg2.DefaultCellStyle.ForeColor =
                    Color.White;

                dtg2.Columns[0].HeaderText =

                "Nome Funcionario";



                dtg2.Columns[1].HeaderText =

                "RG";
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregaLinha()
        {
            txtnomecli.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtrg.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void carregaLinha2()
        {
            txtnmfunc.Text = dtg2.SelectedRows[0].Cells[0].Value.ToString();
            txtrgfunc.Text = dtg2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void limpacampos()
        {
            txnomepet.Clear();
            txtcod.Clear();
            txtdata.Clear();
            txtnmfunc.Clear();
            txtnomecli.Clear();
            txtra.Clear();
            txtrg.Clear();
            txtrgfunc.Clear();
            banho.Checked = false;
            tosa.Checked = false;
            ambos.Checked = false;
        }
        private void carregarserv()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select * from tbl_banhoetosa5";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtg3.DataSource = dt;
                cn.Close();
                dtg3.RowsDefaultCellStyle.BackColor =

                Color.Black;


                dtg3.DefaultCellStyle.ForeColor =
                    Color.White;

                dtg3.Columns[0].HeaderText =

                "Código";



                dtg3.Columns[1].HeaderText =

                "Nome Cliente";

                dtg3.Columns[2].HeaderText =

                "RG Cliente";

                dtg3.Columns[3].HeaderText =

                "Nome Animal";

                dtg3.Columns[4].HeaderText =

                "Raça";

                dtg3.Columns[5].HeaderText =

                "Tipo do serviço";

                dtg3.Columns[6].HeaderText =

                "RG Funcionario";

                dtg3.Columns[7].HeaderText =

                "Nome Funcionario";

                dtg3.Columns[8].HeaderText =

                "Data";
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void banho_e_tosa_Load(object sender, EventArgs e)
        {
            carregarserv();
            carregarfunc();
            carregarcliente();
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            carregaLinha();
            txnomepet.Focus();
        }

        private void dtg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha2();
            txnomepet.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarcliente();
            carregarfunc();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtrg.Text == "")
            {
                MessageBox.Show("Obrigatório selecionar o cliente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrg.Focus();
            }
            else if (txtrgfunc.Text == "")
            {
                MessageBox.Show("Obrigatório selecionar o funcionario", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrgfunc.Focus();
            }
            else if (txtdata.Text == "")
            {
                MessageBox.Show("Obrigatório informar o data", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdata.Focus();
            }
            else
            {
                string rgcli = txtrg.Text;
                string nmcli = txtnomecli.Text;
                string nmanimal = txnomepet.Text;
                string raça = txtra.Text;
                string rgfunc = txtrgfunc.Text;
                string nmfunc = txtnmfunc.Text;
                string cat = txtserv.Text;
                string data = txtdata.Text;
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_banhoetosa5(nm_cliente,rg_cliente,nm_animal,raça,rg_funci,nm_funci,categoria,dt)values('" + nmcli + "','" + rgcli + "','" + nmanimal + "','" + raça + "','" + rgfunc + "','" + nmfunc + "','" + cat + "','" + data + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Animal encaminhado para o serviço !!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    btnsave.Visible = false;
                    btnstart.Visible = true;
                    desabilitar();
                    limpacampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                    carregarserv();
                }
            }
        }

        private void desabilitar()
        {
            txtnomecli.Enabled = false;
            txtra.Enabled = false;
            txtrg.Enabled = false;
            txtrgfunc.Enabled = false;
            txtnmfunc.Enabled = false;
            txnomepet.Enabled = false;
            dtg.Enabled = false;
            dtg2.Enabled = false;
            txtdata.Enabled = false;
            ambos.Enabled = false;
            tosa.Enabled = false;
            banho.Enabled = false;
        }
        private void habilitar()
        {
            txnomepet.Enabled = true;
            txtnomecli.Enabled = true;
            txtrg.Enabled = true;
            txtrgfunc.Enabled = true;
            txtdata.Enabled = true;
            txtra.Enabled = true;
            txtnmfunc.Enabled = true;
            dtg.Enabled = true;
            banho.Enabled = true;
            tosa.Enabled = true;
            ambos.Enabled = true;
            dtg2.Enabled = true;
        }
        private void carregaLinhas()
        {
            lblcod.Visible = true;
            txtcod.Visible = true;
            txnomepet.Enabled = false;
            txtra.Enabled = false;
            txtrg.Text = dtg3.SelectedRows[0].Cells[2].Value.ToString();
            txtcod.Text = dtg3.SelectedRows[0].Cells[0].Value.ToString();
            txtnomecli.Text = dtg3.SelectedRows[0].Cells[1].Value.ToString();
            txnomepet.Text = dtg3.SelectedRows[0].Cells[3].Value.ToString();
            txtra.Text = dtg3.SelectedRows[0].Cells[4].Value.ToString();
            txtrgfunc.Text = dtg3.SelectedRows[0].Cells[6].Value.ToString();
            txtnmfunc.Text = dtg3.SelectedRows[0].Cells[7].Value.ToString();
            txtdata.Text = dtg3.SelectedRows[0].Cells[8].Value.ToString();
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            btnstart.Visible = false;
            lblcod.Visible = false;
            txtcod.Visible = false;
            habilitar();
            btnsave.Visible = true;
            txtrg.Focus();
            carregarcliente();
            carregarfunc();
            limpacampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para deletar um registro selecione um pedido na tabela 'Pedido' e clique novamente em 'Deletar um registro'","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnav.Visible = false;
            btndel.Visible = true;
        }

        private void dtg3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinhas();
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
                    cm.CommandText = "delete from tbl_banhoetosa5  where cd_banhoetosa = " + txtcod.Text;
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limpacampos();
                    txtrg.Focus();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }

                finally
                {
                    cn.Close();
                    lblcod.Visible = false;
                    txtcod.Visible = false;
                    carregarserv();
                }
            }
        }
    }
}
