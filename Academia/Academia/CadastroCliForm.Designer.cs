namespace Academia
{
    partial class CadastroCliForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliForm));
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.TabPage();
            this.bttpesq = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.cbPesq = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDelete = new System.Windows.Forms.TextBox();
            this.dvgPesq = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mskaltura = new System.Windows.Forms.TextBox();
            this.mskpeso = new System.Windows.Forms.TextBox();
            this.imc1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.saude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.obs1 = new System.Windows.Forms.TextBox();
            this.obs = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.idade = new System.Windows.Forms.Label();
            this.objetivo = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.objetivo1 = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.rg = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPesq)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(646, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 41);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(221, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Listar
            // 
            this.Listar.Controls.Add(this.bttpesq);
            this.Listar.Controls.Add(this.txtPesq);
            this.Listar.Controls.Add(this.cbPesq);
            this.Listar.Controls.Add(this.label14);
            this.Listar.Controls.Add(this.label13);
            this.Listar.Controls.Add(this.textDelete);
            this.Listar.Controls.Add(this.dvgPesq);
            this.Listar.Location = new System.Drawing.Point(4, 23);
            this.Listar.Name = "Listar";
            this.Listar.Padding = new System.Windows.Forms.Padding(3);
            this.Listar.Size = new System.Drawing.Size(717, 390);
            this.Listar.TabIndex = 2;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            // 
            // bttpesq
            // 
            this.bttpesq.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttpesq.Location = new System.Drawing.Point(582, 16);
            this.bttpesq.Name = "bttpesq";
            this.bttpesq.Size = new System.Drawing.Size(78, 32);
            this.bttpesq.TabIndex = 10;
            this.bttpesq.Text = "Pesquisar";
            this.bttpesq.UseVisualStyleBackColor = true;
            this.bttpesq.Click += new System.EventHandler(this.bttpesq_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(232, 22);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(344, 22);
            this.txtPesq.TabIndex = 9;
            // 
            // cbPesq
            // 
            this.cbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq.FormattingEnabled = true;
            this.cbPesq.Items.AddRange(new object[] {
            "NOME"});
            this.cbPesq.Location = new System.Drawing.Point(93, 23);
            this.cbPesq.Name = "cbPesq";
            this.cbPesq.Size = new System.Drawing.Size(88, 22);
            this.cbPesq.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Pesq. por: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Digite o ID a ser deletado";
            // 
            // textDelete
            // 
            this.textDelete.Location = new System.Drawing.Point(348, 362);
            this.textDelete.Name = "textDelete";
            this.textDelete.Size = new System.Drawing.Size(100, 22);
            this.textDelete.TabIndex = 1;
            this.textDelete.TextChanged += new System.EventHandler(this.textDelete_TextChanged);
            // 
            // dvgPesq
            // 
            this.dvgPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPesq.Location = new System.Drawing.Point(11, 74);
            this.dvgPesq.Name = "dvgPesq";
            this.dvgPesq.Size = new System.Drawing.Size(703, 264);
            this.dvgPesq.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mskaltura);
            this.tabPage1.Controls.Add(this.mskpeso);
            this.tabPage1.Controls.Add(this.imc1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.saude);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.obs1);
            this.tabPage1.Controls.Add(this.obs);
            this.tabPage1.Controls.Add(this.altura);
            this.tabPage1.Controls.Add(this.peso);
            this.tabPage1.Controls.Add(this.idade);
            this.tabPage1.Controls.Add(this.objetivo);
            this.tabPage1.Controls.Add(this.txtidade);
            this.tabPage1.Controls.Add(this.objetivo1);
            this.tabPage1.Controls.Add(this.endereco);
            this.tabPage1.Controls.Add(this.nome);
            this.tabPage1.Controls.Add(this.telefone);
            this.tabPage1.Controls.Add(this.rg);
            this.tabPage1.Controls.Add(this.cpf);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // mskaltura
            // 
            this.mskaltura.Location = new System.Drawing.Point(425, 160);
            this.mskaltura.Name = "mskaltura";
            this.mskaltura.Size = new System.Drawing.Size(60, 23);
            this.mskaltura.TabIndex = 8;
            this.mskaltura.TextChanged += new System.EventHandler(this.mskaltura_TextChanged_1);
            // 
            // mskpeso
            // 
            this.mskpeso.Location = new System.Drawing.Point(303, 160);
            this.mskpeso.Name = "mskpeso";
            this.mskpeso.Size = new System.Drawing.Size(55, 23);
            this.mskpeso.TabIndex = 7;
            // 
            // imc1
            // 
            this.imc1.Enabled = false;
            this.imc1.Location = new System.Drawing.Point(547, 158);
            this.imc1.Mask = "00.00";
            this.imc1.Name = "imc1";
            this.imc1.Size = new System.Drawing.Size(49, 23);
            this.imc1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "Saúde";
            // 
            // saude
            // 
            this.saude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saude.Location = new System.Drawing.Point(208, 226);
            this.saude.Name = "saude";
            this.saude.Size = new System.Drawing.Size(390, 22);
            this.saude.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "IMC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // obs1
            // 
            this.obs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obs1.Location = new System.Drawing.Point(208, 258);
            this.obs1.Multiline = true;
            this.obs1.Name = "obs1";
            this.obs1.Size = new System.Drawing.Size(390, 61);
            this.obs1.TabIndex = 12;
            // 
            // obs
            // 
            this.obs.AutoSize = true;
            this.obs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obs.Location = new System.Drawing.Point(112, 261);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(93, 16);
            this.obs.TabIndex = 62;
            this.obs.Text = "Observações";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(377, 162);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(47, 16);
            this.altura.TabIndex = 59;
            this.altura.Text = "Altura";
            this.altura.Click += new System.EventHandler(this.altura_Click);
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(257, 162);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(39, 16);
            this.peso.TabIndex = 57;
            this.peso.Text = "Peso";
            this.peso.Click += new System.EventHandler(this.peso_Click);
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idade.Location = new System.Drawing.Point(159, 164);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(45, 16);
            this.idade.TabIndex = 55;
            this.idade.Text = "Idade";
            // 
            // objetivo
            // 
            this.objetivo.AutoSize = true;
            this.objetivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objetivo.Location = new System.Drawing.Point(144, 200);
            this.objetivo.Name = "objetivo";
            this.objetivo.Size = new System.Drawing.Size(63, 16);
            this.objetivo.TabIndex = 54;
            this.objetivo.Text = "Objetivo";
            this.objetivo.Click += new System.EventHandler(this.objetivo_Click);
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(208, 159);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(33, 22);
            this.txtidade.TabIndex = 6;
            // 
            // objetivo1
            // 
            this.objetivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objetivo1.Location = new System.Drawing.Point(208, 197);
            this.objetivo1.Name = "objetivo1";
            this.objetivo1.Size = new System.Drawing.Size(390, 22);
            this.objetivo1.TabIndex = 10;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(208, 133);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(390, 23);
            this.endereco.TabIndex = 5;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(208, 70);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(390, 23);
            this.nome.TabIndex = 1;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(503, 101);
            this.telefone.Mask = "(00)00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(95, 23);
            this.telefone.TabIndex = 4;
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(348, 101);
            this.rg.Mask = "00.000.000-0";
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(74, 23);
            this.rg.TabIndex = 3;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(208, 101);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(84, 23);
            this.cpf.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cadastro de Clientes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nome";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.tabPage1);
            this.Cadastro.Controls.Add(this.Listar);
            this.Cadastro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(0, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.SelectedIndex = 0;
            this.Cadastro.Size = new System.Drawing.Size(725, 417);
            this.Cadastro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(321, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // confirmar
            // 
            this.confirmar.AutoSize = true;
            this.confirmar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.Location = new System.Drawing.Point(219, 421);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(70, 16);
            this.confirmar.TabIndex = 56;
            this.confirmar.Text = "Confirmar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Alterar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Sair";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(424, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Deletar";
            // 
            // CadastroCliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 483);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroCliForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Listar.ResumeLayout(false);
            this.Listar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPesq)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cadastro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Listar;
        private System.Windows.Forms.DataGridView dvgPesq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox rg;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Cadastro;
        private System.Windows.Forms.Label objetivo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox objetivo1;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.TextBox obs1;
        private System.Windows.Forms.Label obs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label confirmar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox saude;
        private System.Windows.Forms.MaskedTextBox imc1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textDelete;
        private System.Windows.Forms.Button bttpesq;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.ComboBox cbPesq;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox mskaltura;
        private System.Windows.Forms.TextBox mskpeso;
    }
}