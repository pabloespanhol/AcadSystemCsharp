namespace Academia
{
    partial class PagCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagCli));
            this.label1 = new System.Windows.Forms.Label();
            this.btConf = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.mtxtPag = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPagar = new System.Windows.Forms.TabPage();
            this.txtconfirmarpg = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.cbPesq = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPesq = new System.Windows.Forms.DataGridView();
            this.txtsair = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPagar.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btConf
            // 
            this.btConf.Image = ((System.Drawing.Image)(resources.GetObject("btConf.Image")));
            this.btConf.Location = new System.Drawing.Point(213, 137);
            this.btConf.Name = "btConf";
            this.btConf.Size = new System.Drawing.Size(75, 41);
            this.btConf.TabIndex = 47;
            this.btConf.UseVisualStyleBackColor = true;
            this.btConf.Click += new System.EventHandler(this.btConf_Click);
            // 
            // btSair
            // 
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(443, 233);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 41);
            this.btSair.TabIndex = 49;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nome:";
            // 
            // cbNome
            // 
            this.cbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(61, 46);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(429, 22);
            this.cbNome.TabIndex = 51;
            // 
            // mtxtPag
            // 
            this.mtxtPag.Location = new System.Drawing.Point(328, 73);
            this.mtxtPag.Mask = "00/00/0000";
            this.mtxtPag.Name = "mtxtPag";
            this.mtxtPag.Size = new System.Drawing.Size(67, 22);
            this.mtxtPag.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 14);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 56;
            this.label5.Text = "Valor: ";
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(61, 73);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(129, 22);
            this.txtPag.TabIndex = 57;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPagar);
            this.tabControl1.Controls.Add(this.tbConsulta);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 207);
            this.tabControl1.TabIndex = 58;
            // 
            // tbPagar
            // 
            this.tbPagar.Controls.Add(this.txtconfirmarpg);
            this.tbPagar.Controls.Add(this.txtPag);
            this.tbPagar.Controls.Add(this.label1);
            this.tbPagar.Controls.Add(this.btConf);
            this.tbPagar.Controls.Add(this.label5);
            this.tbPagar.Controls.Add(this.mtxtPag);
            this.tbPagar.Controls.Add(this.label2);
            this.tbPagar.Controls.Add(this.label4);
            this.tbPagar.Controls.Add(this.cbNome);
            this.tbPagar.Location = new System.Drawing.Point(4, 23);
            this.tbPagar.Name = "tbPagar";
            this.tbPagar.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagar.Size = new System.Drawing.Size(513, 180);
            this.tbPagar.TabIndex = 0;
            this.tbPagar.Text = "Pagar";
            this.tbPagar.UseVisualStyleBackColor = true;
            // 
            // txtconfirmarpg
            // 
            this.txtconfirmarpg.AutoSize = true;
            this.txtconfirmarpg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmarpg.Location = new System.Drawing.Point(210, 120);
            this.txtconfirmarpg.Name = "txtconfirmarpg";
            this.txtconfirmarpg.Size = new System.Drawing.Size(68, 14);
            this.txtconfirmarpg.TabIndex = 58;
            this.txtconfirmarpg.Text = "Confirmar";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.button1);
            this.tbConsulta.Controls.Add(this.txtPesq);
            this.tbConsulta.Controls.Add(this.cbPesq);
            this.tbConsulta.Controls.Add(this.label6);
            this.tbConsulta.Controls.Add(this.dgvPesq);
            this.tbConsulta.Location = new System.Drawing.Point(4, 23);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(513, 180);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(196, 16);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(218, 22);
            this.txtPesq.TabIndex = 3;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // cbPesq
            // 
            this.cbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesq.FormattingEnabled = true;
            this.cbPesq.Items.AddRange(new object[] {
            "NOME"});
            this.cbPesq.Location = new System.Drawing.Point(88, 17);
            this.cbPesq.Name = "cbPesq";
            this.cbPesq.Size = new System.Drawing.Size(88, 22);
            this.cbPesq.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pesq. por: ";
            // 
            // dgvPesq
            // 
            this.dgvPesq.AllowUserToAddRows = false;
            this.dgvPesq.AllowUserToDeleteRows = false;
            this.dgvPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesq.Location = new System.Drawing.Point(6, 44);
            this.dgvPesq.Name = "dgvPesq";
            this.dgvPesq.ReadOnly = true;
            this.dgvPesq.Size = new System.Drawing.Size(501, 131);
            this.dgvPesq.TabIndex = 0;
            // 
            // txtsair
            // 
            this.txtsair.AutoSize = true;
            this.txtsair.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsair.Location = new System.Drawing.Point(465, 214);
            this.txtsair.Name = "txtsair";
            this.txtsair.Size = new System.Drawing.Size(31, 14);
            this.txtsair.TabIndex = 59;
            this.txtsair.Text = "Sair";
            // 
            // PagCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 275);
            this.Controls.Add(this.txtsair);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tbPagar.ResumeLayout(false);
            this.tbPagar.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.MaskedTextBox mtxtPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPagar;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.DataGridView dgvPesq;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.ComboBox cbPesq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtconfirmarpg;
        private System.Windows.Forms.Label txtsair;
    }
}