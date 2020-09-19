using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Data.SqlClient;

namespace TCM
{
    public partial class telalogin : Form
    {
        public telalogin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" && txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo usuário e senha !!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            /*if (txtlogin.Text == "cliente" && txtsenha.Text == "cliente")
            {
                MessageBox.Show("Seu acesso foi liberado, você será redirecionado para a interface de cliente", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Hide();
                 telacliente telacliente = new telacliente();
                 telacliente.ShowDialog();
                txtlogin.Clear();
                txtsenha.Clear();
            }*/
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_funcionario where login_funcionario = ('" + txtlogin.Text + "') and senha_funcionario = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalidos!!\nTente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogin.Clear();
                        txtsenha.Clear();
                        txtlogin.Focus();
                    }
                }
                finally
                {
                    cn.Close();
                }
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Você é um cliente da loja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
            {
                if (DialogResult.Yes == MessageBox.Show("Precisa de Ajuda?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    MessageBox.Show("Solicite um atendente em nossa loja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login: 'RG'\nSenha: 'Numero de Celular'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Visible = false;
                    button2.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Solicite um atendente em nossa loja para lhe cadastrar e dar suporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtlogin.Clear();
            txtsenha.Clear();
            txtlogin.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" && txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo usuário e senha !!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_cliente where rg_cliente = ('" + txtlogin.Text + "') and no_cliente = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        this.Hide();
                        telacliente telacliente = new telacliente();
                        telacliente.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalidos!!\nTente novamente","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogin.Clear();
                        txtsenha.Clear();
                        txtlogin.Focus();
                    }
                }
                finally
                {
                    cn.Close();
                }
            }

        }
    }
}