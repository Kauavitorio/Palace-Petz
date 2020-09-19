namespace TCM
{
    partial class funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlogincadas = new System.Windows.Forms.TextBox();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.btndeletar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf2 = new System.Windows.Forms.MaskedTextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnalter = new System.Windows.Forms.Button();
            this.txtsenhacadas = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar novo funcionario";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero:";
            this.label6.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(115, 92);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(227, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.Visible = false;
            // 
            // txtidade
            // 
            this.txtidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidade.ForeColor = System.Drawing.Color.White;
            this.txtidade.Location = new System.Drawing.Point(115, 167);
            this.txtidade.MaxLength = 2;
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 4;
            this.txtidade.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(368, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(522, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Esta é a aba sobre os funcionarios";
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(359, 57);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(291, 44);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Visible = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Login:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Senha:";
            this.label9.Visible = false;
            // 
            // txtlogincadas
            // 
            this.txtlogincadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtlogincadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlogincadas.ForeColor = System.Drawing.Color.White;
            this.txtlogincadas.Location = new System.Drawing.Point(115, 118);
            this.txtlogincadas.MaxLength = 15;
            this.txtlogincadas.Name = "txtlogincadas";
            this.txtlogincadas.Size = new System.Drawing.Size(100, 20);
            this.txtlogincadas.TabIndex = 2;
            this.txtlogincadas.Visible = false;
            // 
            // dtgDados
            // 
            this.dtgDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(153)))));
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(50, 286);
            this.dtgDados.MultiSelect = false;
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados.Size = new System.Drawing.Size(846, 264);
            this.dtgDados.TabIndex = 10;
            this.dtgDados.Visible = false;
            this.dtgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellContentClick);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btndeletar.FlatAppearance.BorderSize = 0;
            this.btndeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.ForeColor = System.Drawing.Color.White;
            this.btndeletar.Location = new System.Drawing.Point(359, 157);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(291, 44);
            this.btndeletar.TabIndex = 10;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Visible = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtpesquisa.ForeColor = System.Drawing.Color.White;
            this.txtpesquisa.Location = new System.Drawing.Point(450, 263);
            this.txtpesquisa.MaxLength = 9;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(164, 20);
            this.txtpesquisa.TabIndex = 11;
            this.txtpesquisa.Visible = false;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(237, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pesquisar o funcionario: ";
            this.label10.Visible = false;
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtno.ForeColor = System.Drawing.Color.White;
            this.txtno.Location = new System.Drawing.Point(115, 241);
            this.txtno.Mask = "(00) 00000-0000";
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 7;
            this.txtno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtno.Visible = false;
            // 
            // txtcpf2
            // 
            this.txtcpf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtcpf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcpf2.ForeColor = System.Drawing.Color.White;
            this.txtcpf2.Location = new System.Drawing.Point(115, 189);
            this.txtcpf2.Mask = "000.000.000-00";
            this.txtcpf2.Name = "txtcpf2";
            this.txtcpf2.Size = new System.Drawing.Size(100, 20);
            this.txtcpf2.TabIndex = 5;
            this.txtcpf2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcpf2.Visible = false;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.White;
            this.labellogin.Location = new System.Drawing.Point(48, 64);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(42, 13);
            this.labellogin.TabIndex = 23;
            this.labellogin.Text = "Login:";
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.ForeColor = System.Drawing.Color.White;
            this.labelsenha.Location = new System.Drawing.Point(48, 89);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(47, 13);
            this.labelsenha.TabIndex = 24;
            this.labelsenha.Text = "Senha:";
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(96, 57);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(152, 20);
            this.txtlogin.TabIndex = 25;
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(96, 82);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '•';
            this.txtsenha.Size = new System.Drawing.Size(152, 20);
            this.txtsenha.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(620, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "(Insira o rg)";
            this.label11.Visible = false;
            // 
            // btnalter
            // 
            this.btnalter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btnalter.FlatAppearance.BorderSize = 0;
            this.btnalter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalter.ForeColor = System.Drawing.Color.White;
            this.btnalter.Location = new System.Drawing.Point(359, 107);
            this.btnalter.Name = "btnalter";
            this.btnalter.Size = new System.Drawing.Size(291, 44);
            this.btnalter.TabIndex = 9;
            this.btnalter.Text = "Alterar";
            this.btnalter.UseVisualStyleBackColor = false;
            this.btnalter.Visible = false;
            this.btnalter.Click += new System.EventHandler(this.btnalter_Click);
            // 
            // txtsenhacadas
            // 
            this.txtsenhacadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtsenhacadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenhacadas.ForeColor = System.Drawing.Color.White;
            this.txtsenhacadas.Location = new System.Drawing.Point(115, 140);
            this.txtsenhacadas.Name = "txtsenhacadas";
            this.txtsenhacadas.Size = new System.Drawing.Size(100, 20);
            this.txtsenhacadas.TabIndex = 3;
            this.txtsenhacadas.Visible = false;
            // 
            // txtrg
            // 
            this.txtrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrg.ForeColor = System.Drawing.Color.White;
            this.txtrg.Location = new System.Drawing.Point(115, 215);
            this.txtrg.Mask = "00.000.000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 20);
            this.txtrg.TabIndex = 6;
            this.txtrg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtrg.Visible = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(360, 207);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(291, 44);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar os campos/Ativar RG";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Visible = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtsenhacadas);
            this.Controls.Add(this.btnalter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.txtcpf2);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.txtlogincadas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "funcionario";
            this.Text = "funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtlogincadas;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtno;
        private System.Windows.Forms.MaskedTextBox txtcpf2;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnalter;
        private System.Windows.Forms.TextBox txtsenhacadas;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Button btnlimpar;
    }
}