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
    public partial class novocliente : Form
    {
        public novocliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-U53EHF2\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_palace_petz");
        SqlCommand cm = new SqlCommand();

        public string F { get; private set; }
        public string M { get; private set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }

        private void limparcampos()
        {
            txtnome.Clear();
            txtrg.Clear();
            txtno.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtnum.Clear();
            textBox7.Clear();
            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            limparcampos();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NOME'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }
            else if (txtrg.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'RG'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrg.Focus();
            }
            else if (txtno.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'Numero'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtno.Focus();
            }
            else if (txtcep.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'CEP'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcep.Focus();
            }
            else if (txtnum.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'Numero'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnum.Focus();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'Numero'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_cliente(endereço,nm_cliente,rg_cliente,no_cliente,cep_cliente,sx_cliente,no_casa,complemento)values('" + txtendereco.Text + "','" + txtnome.Text + "','" + txtrg.Text + "','" + txtno.Text + "','" + txtcep.Text + "','" + textBox1.Text + "','" + txtnum.Text + "','"+ textBox7.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cliente foi cadastrado com sucesso !!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparcampos();
                    txtnome.Focus();
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                /*limparcampos();
                MessageBox.Show("Cliente cadastrado com sucesso!!!! \nPara alterar dados do cliente entre na aba 'Clientes' e faça a alteração", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            }
        }
    }
}
