namespace Academia
{
    partial class PagCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagCliente));
            this.textBoxIDCLI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeCLI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridPAG = new System.Windows.Forms.DataGridView();
            this.Fatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPAG)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIDCLI
            // 
            this.textBoxIDCLI.Location = new System.Drawing.Point(114, 75);
            this.textBoxIDCLI.Name = "textBoxIDCLI";
            this.textBoxIDCLI.Size = new System.Drawing.Size(49, 20);
            this.textBoxIDCLI.TabIndex = 0;
            this.textBoxIDCLI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNomeCLI
            // 
            this.textBoxNomeCLI.Location = new System.Drawing.Point(220, 75);
            this.textBoxNomeCLI.Name = "textBoxNomeCLI";
            this.textBoxNomeCLI.Size = new System.Drawing.Size(410, 20);
            this.textBoxNomeCLI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(586, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 41);
            this.button6.TabIndex = 48;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(354, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(244, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Pagamentos";
            // 
            // dataGridPAG
            // 
            this.dataGridPAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPAG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fatura,
            this.Data_Vencimento,
            this.Valor});
            this.dataGridPAG.Location = new System.Drawing.Point(91, 111);
            this.dataGridPAG.Name = "dataGridPAG";
            this.dataGridPAG.Size = new System.Drawing.Size(544, 154);
            this.dataGridPAG.TabIndex = 50;
            this.dataGridPAG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fatura
            // 
            this.Fatura.HeaderText = "Fatura";
            this.Fatura.MinimumWidth = 10;
            this.Fatura.Name = "Fatura";
            this.Fatura.Width = 200;
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data_Vencimento";
            this.Data_Vencimento.MinimumWidth = 10;
            this.Data_Vencimento.Name = "Data_Vencimento";
            this.Data_Vencimento.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 10;
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // PagCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 343);
            this.Controls.Add(this.dataGridPAG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeCLI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDCLI);
            this.Name = "PagCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento de cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDCLI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeCLI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridPAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;

    }
}