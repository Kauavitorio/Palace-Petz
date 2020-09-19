namespace TCM
{
    partial class vendas
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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomecli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtvl = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.txtfmpag = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnalter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtqt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnmfunc = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnentrega = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcomple = new System.Windows.Forms.TextBox();
            this.btncomentre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(153)))));
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.dtg.Location = new System.Drawing.Point(12, 48);
            this.dtg.MultiSelect = false;
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(942, 362);
            this.dtg.TabIndex = 0;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitação dos clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alterar informações do pedido";
            // 
            // txtnomecli
            // 
            this.txtnomecli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtnomecli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomecli.Enabled = false;
            this.txtnomecli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecli.ForeColor = System.Drawing.Color.White;
            this.txtnomecli.Location = new System.Drawing.Point(111, 573);
            this.txtnomecli.Name = "txtnomecli";
            this.txtnomecli.Size = new System.Drawing.Size(183, 20);
            this.txtnomecli.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RG do cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor da compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome do Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Forma de Pagamento:";
            // 
            // txtrg
            // 
            this.txtrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrg.Enabled = false;
            this.txtrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.ForeColor = System.Drawing.Color.White;
            this.txtrg.Location = new System.Drawing.Point(111, 599);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(183, 20);
            this.txtrg.TabIndex = 9;
            this.txtrg.TextChanged += new System.EventHandler(this.txtrg_TextChanged);
            // 
            // txtvl
            // 
            this.txtvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvl.Enabled = false;
            this.txtvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvl.ForeColor = System.Drawing.Color.White;
            this.txtvl.Location = new System.Drawing.Point(111, 495);
            this.txtvl.Name = "txtvl";
            this.txtvl.Size = new System.Drawing.Size(183, 20);
            this.txtvl.TabIndex = 10;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtnomeprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeprod.Enabled = false;
            this.txtnomeprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeprod.ForeColor = System.Drawing.Color.White;
            this.txtnomeprod.Location = new System.Drawing.Point(111, 469);
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(183, 20);
            this.txtnomeprod.TabIndex = 11;
            // 
            // txtfmpag
            // 
            this.txtfmpag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtfmpag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfmpag.Enabled = false;
            this.txtfmpag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfmpag.ForeColor = System.Drawing.Color.White;
            this.txtfmpag.Location = new System.Drawing.Point(129, 547);
            this.txtfmpag.Name = "txtfmpag";
            this.txtfmpag.Size = new System.Drawing.Size(165, 20);
            this.txtfmpag.TabIndex = 12;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btndel.Enabled = false;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Location = new System.Drawing.Point(435, 506);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(110, 55);
            this.btndel.TabIndex = 30;
            this.btndel.Text = "Deletar Pedido";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btncancel.Enabled = false;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(319, 506);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 55);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btnsave.Enabled = false;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(435, 445);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 55);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Salvar";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnalter
            // 
            this.btnalter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btnalter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalter.Enabled = false;
            this.btnalter.FlatAppearance.BorderSize = 0;
            this.btnalter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalter.ForeColor = System.Drawing.Color.White;
            this.btnalter.Location = new System.Drawing.Point(319, 445);
            this.btnalter.Name = "btnalter";
            this.btnalter.Size = new System.Drawing.Size(110, 55);
            this.btnalter.TabIndex = 27;
            this.btnalter.Text = "Alterar Informaçoes";
            this.btnalter.UseVisualStyleBackColor = false;
            this.btnalter.Click += new System.EventHandler(this.btnalter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Código Pedido:";
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.White;
            this.txtcod.Location = new System.Drawing.Point(111, 443);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(183, 20);
            this.txtcod.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Quantidade:";
            // 
            // txtqt
            // 
            this.txtqt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtqt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqt.Enabled = false;
            this.txtqt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqt.ForeColor = System.Drawing.Color.White;
            this.txtqt.Location = new System.Drawing.Point(111, 521);
            this.txtqt.Name = "txtqt";
            this.txtqt.Size = new System.Drawing.Size(183, 20);
            this.txtqt.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nome Funcionario:";
            // 
            // txtnmfunc
            // 
            this.txtnmfunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtnmfunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnmfunc.Enabled = false;
            this.txtnmfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmfunc.ForeColor = System.Drawing.Color.White;
            this.txtnmfunc.Location = new System.Drawing.Point(111, 625);
            this.txtnmfunc.Name = "txtnmfunc";
            this.txtnmfunc.Size = new System.Drawing.Size(183, 20);
            this.txtnmfunc.TabIndex = 37;
            // 
            // txtdata
            // 
            this.txtdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.Enabled = false;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.Color.White;
            this.txtdata.Location = new System.Drawing.Point(111, 651);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(183, 20);
            this.txtdata.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Data da Venda:";
            // 
            // btnentrega
            // 
            this.btnentrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btnentrega.Enabled = false;
            this.btnentrega.FlatAppearance.BorderSize = 0;
            this.btnentrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btnentrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrega.ForeColor = System.Drawing.Color.White;
            this.btnentrega.Location = new System.Drawing.Point(319, 567);
            this.btnentrega.Name = "btnentrega";
            this.btnentrega.Size = new System.Drawing.Size(226, 55);
            this.btnentrega.TabIndex = 40;
            this.btnentrega.Text = "Encaminhar para delivery";
            this.btnentrega.UseVisualStyleBackColor = false;
            this.btnentrega.Visible = false;
            this.btnentrega.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 679);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Endereço:";
            // 
            // txtend
            // 
            this.txtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtend.Enabled = false;
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.ForeColor = System.Drawing.Color.White;
            this.txtend.Location = new System.Drawing.Point(111, 677);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(183, 20);
            this.txtend.TabIndex = 42;
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtno.Enabled = false;
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.ForeColor = System.Drawing.Color.White;
            this.txtno.Location = new System.Drawing.Point(409, 625);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(136, 20);
            this.txtno.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(316, 627);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Numero casa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(316, 653);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Complementos:";
            // 
            // txtcomple
            // 
            this.txtcomple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.txtcomple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomple.Enabled = false;
            this.txtcomple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomple.ForeColor = System.Drawing.Color.White;
            this.txtcomple.Location = new System.Drawing.Point(409, 651);
            this.txtcomple.Name = "txtcomple";
            this.txtcomple.Size = new System.Drawing.Size(136, 20);
            this.txtcomple.TabIndex = 46;
            // 
            // btncomentre
            // 
            this.btncomentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(141)))));
            this.btncomentre.Enabled = false;
            this.btncomentre.FlatAppearance.BorderSize = 0;
            this.btncomentre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.btncomentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomentre.ForeColor = System.Drawing.Color.White;
            this.btncomentre.Location = new System.Drawing.Point(319, 564);
            this.btncomentre.Name = "btncomentre";
            this.btncomentre.Size = new System.Drawing.Size(226, 55);
            this.btncomentre.TabIndex = 47;
            this.btncomentre.Text = "Encaminhar para delivery";
            this.btncomentre.UseVisualStyleBackColor = false;
            this.btncomentre.Click += new System.EventHandler(this.btncomentre_Click);
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btncomentre);
            this.Controls.Add(this.txtcomple);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnentrega);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtnmfunc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtqt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnalter);
            this.Controls.Add(this.txtfmpag);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.txtvl);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomecli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vendas";
            this.Text = "vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomecli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtvl;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.TextBox txtfmpag;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnalter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtqt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnmfunc;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnentrega;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcomple;
        private System.Windows.Forms.Button btncomentre;
    }
}