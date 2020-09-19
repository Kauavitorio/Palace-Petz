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
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void carregarcampos()
        {
            txtnome.Text = dtgDados.SelectedRows[0].Cells[1].Value.ToString();
            txtrg.Text = dtgDados.SelectedRows[0].Cells[0].Value.ToString();
            txtlogincadas.Text = dtgDados.SelectedRows[0].Cells[2].Value.ToString();
            txtsenhacadas.Text = dtgDados.SelectedRows[0].Cells[3].Value.ToString();
            txtno.Text = dtgDados.SelectedRows[0].Cells[4].Value.ToString();
            txtcpf2.Text = dtgDados.SelectedRows[0].Cells[5].Value.ToString();
            txtidade.Text = dtgDados.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void limparcampos()
        {
           txtcpf2.Clear();
           txtidade.Clear();
           txtlogincadas.Clear();
            txtlogin.Clear();
            txtsenha.Clear();
           txtnome.Clear();
           txtno.Clear();
           txtrg.Clear();
           txtpesquisa.Clear();
           txtsenhacadas.Clear();
        }
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Nome' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtlogincadas.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Login' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsenhacadas.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'Senha' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtrg.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'RG' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_funcionario(rg_funcionario,login_funcionario,senha_funcionario,nm_funcionario,no_funcionario,cpf_funcionario,idade_funcionario)values('" + txtrg.Text + "','" + txtlogincadas.Text + "','" +txtsenhacadas.Text + "','" + txtnome.Text + "','" + txtno.Text +"','" + txtcpf2.Text +"','"+ txtidade.Text +"')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limparcampos();
                    MessageBox.Show("Novo funcionario cadastrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    carregardt();
                }
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtpesquisa.Text != "")
            {
                try
                {
                    cn.Open();

                    cm.CommandText = "select * from tbl_funcionario where rg_funcionario like ('%" + txtpesquisa.Text + "%')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtgDados.DataSource = dt;
                    cn.Close();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dtgDados.DataSource = null;
            }

        }

        private void dtgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarcampos();
            txtrg.Enabled = false;
        }


        private void btndeletar_Click(object sender, EventArgs e)
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
                    cm.CommandText = "delete from tbl_funcionario  where rg_funcionario = " + txtrg.Text;
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    limparcampos();
                    txtrg.Enabled = true;
                    txtpesquisa.Focus();
                    MessageBox.Show("Funcionario deletado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }

                finally
                {
                    cn.Close();
                    carregardt();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o 'LOGIN'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlogin.Focus();
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher a 'SENHA'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsenha.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_gerente where login_gerente = ('" + txtlogin.Text + "') and senha_gerente = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        MessageBox.Show("Acesso liberado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtlogin.Visible = false;
                        txtsenha.Visible = false;
                        txtsenhacadas.Visible = true;
                        txtrg.Visible = true;
                        txtnome.Visible = true;
                        txtno.Visible = true;
                        txtlogincadas.Visible = true;
                        txtcpf2.Visible = true;
                        btncadastrar.Visible = true;
                        btndeletar.Visible = true;
                        txtidade.Visible = true;
                        txtpesquisa.Visible = true;
                        dtgDados.Visible = true;
                        labellogin.Visible = false;
                        labelsenha.Visible = false;
                        label9.Visible = true;
                        label8.Visible = true;
                        label6.Visible = true;
                        btnlimpar.Visible = true;
                        label5.Visible = true;
                        label4.Visible = true;
                        label3.Visible = true;
                        label2.Visible = true;
                        label11.Visible = true;
                        button1.Visible = false;
                        label10.Visible = true;
                        btnalter.Visible = true;
                        label1.Visible = true;
                        txtpesquisa.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Acesso liberado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgDados.Visible = true;
                        txtpesquisa.Visible = true;
                        label10.Visible = true;
                        button1.Visible = false;
                        txtlogin.Visible = false;
                        txtsenha.Visible = false;
                        txtpesquisa.Focus();
                        labelsenha.Visible = false;
                        label11.Visible = true;
                        labellogin.Visible = false;
                    }
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnalter_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Gostaria de alterar os dados do funionario selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
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

                else if (txtcpf2.Text == "")
                {
                    MessageBox.Show("Obrigatório preencher o campo 'CPF'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcpf2.Focus();
                }
                else if (txtno.Text == "")
                {
                    MessageBox.Show("Obrigatório preencher o campo 'NUMERO'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtno.Focus();
                }
                else
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "update tbl_funcionario set nm_funcionario = @nmcli,rg_funcionario = @rg,no_funcionario = @num,cpf_funcionario =@cpf,idade_funcionario = @idade,senha_funcionario = @senha,login_funcionario = @login where rg_funcionario = " + txtrg.Text;
                        cm.Parameters.Add("@nmcli", SqlDbType.VarChar).Value = txtnome.Text;
                        cm.Parameters.Add("@rg", SqlDbType.VarChar).Value = txtrg.Text;
                        cm.Parameters.Add("@num", SqlDbType.VarChar).Value = txtno.Text;
                        cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtcpf2.Text;
                        cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtsenhacadas.Text;
                        cm.Parameters.Add("@idade", SqlDbType.VarChar).Value = txtidade.Text;
                        cm.Parameters.Add("@login", SqlDbType.VarChar).Value = txtlogincadas.Text;

                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtpesquisa.Focus();
                        limparcampos();
                        cm.Parameters.Clear();
                        cn.Close();
                        carregardt();


                    }


                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                }
            }
            else
            {

            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
            txtrg.Enabled = true;
        }

        private void carregardt()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select * from tbl_funcionario";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtgDados.DataSource = dt;
                cn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void funcionario_Load(object sender, EventArgs e)
        {

            carregardt();
            dtgDados.RowsDefaultCellStyle.BackColor =

            Color.Black;


            dtgDados.DefaultCellStyle.ForeColor =
                Color.White;

            dtgDados.Columns[0].HeaderText =

            "RG Funcionario";



            dtgDados.Columns[1].HeaderText =

            "Nome";



            dtgDados.Columns[2].HeaderText =

            "Login";



            dtgDados.Columns[3].HeaderText =

            "Senha";



            dtgDados.Columns[4].HeaderText =

            "Numero";



            dtgDados.Columns[5].HeaderText =

            "CPF";



            dtgDados.Columns[6].HeaderText =

            "Idade";



            dtgDados.Columns[7].HeaderText =

            "Código";

        }
    }
}
