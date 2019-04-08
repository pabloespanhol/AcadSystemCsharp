using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academia
{
    public partial class CadastroCliForm : Form
    {
        public CadastroCliForm()
        {

            InitializeComponent();

        }
        private MySqlConnection conexao;
        private DataSet mDataSet;
        private MySqlDataAdapter mAdapter;

        public class Pesquisa
        {
            public string Nome { get; set; }
        }
        
        public void setImc()
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(mskpeso.Text);
            altura = Convert.ToDouble(mskaltura.Text);
            peso = peso / 1000;
            altura = altura / 100;
            imc = peso / (altura * altura);
            imc1.Text = Convert.ToString(imc);

        }
        private void mostraResultado()
        {
            mDataSet = new DataSet();
            String config = "server = localhost; userid = root; database = acadsystem; pwd= 'etec-2014' ";
            MySqlConnection Conexao = new MySqlConnection(config);
            MySqlCommand Query = new MySqlCommand();
            Conexao.Open();

            //cria um adapter utilizando a instrução SQL para aceder a tabela
            mAdapter = new MySqlDataAdapter("SELECT * FROM tbcadcli", Conexao);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "Pedido");

            //atribui o resultado à propriedade DataSource da dataGridView
            dvgPesq.DataSource = mDataSet;
            dvgPesq.DataMember = "Pedido";
            dvgPesq.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            Conexao.Close();
        
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nome.Text == "" ||
                  cpf.Text == "" ||
                  rg.Text == "" ||
          telefone.Text == "" ||
          endereco.Text == "" ||
          objetivo1.Text == "" ||
           txtidade.Text == "" ||
           mskpeso.Text == "" ||
           mskaltura.Text == "" ||
           saude.Text == "" ||
           obs1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.");
            }
            else
            {
                string config = "server = localhost;userid=root;database=acadsystem;pwd=etec-2014";
                MySqlConnection Conexao = new MySqlConnection(config);
                MySqlCommand Query = new MySqlCommand();

                Conexao.Open();

                string insertSQL = "insert tbcadcli(nome, cpf, rg, endereco, telefone, objetivo, idade, peso, altura, imc, saude, obs) values ('" + nome.Text +
                                            "', '" + cpf.Text +
                                            "', '" + rg.Text +
                                            "', '" + endereco.Text +
                                            "', '" + telefone.Text +
                                            "', '" + objetivo1.Text +
                                            "', '" + txtidade.Text +
                                            "', '" + mskpeso.Text +
                                            "', '" + mskaltura.Text +
                                            "', '" + imc1.Text +
                                            "', '" + saude.Text +
                                            "', '" + obs1.Text + "')";

                MySqlCommand command = new MySqlCommand(insertSQL, Conexao);

                command.ExecuteNonQuery();


                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    mostraResultado();

                }

                Conexao.Close();
                mostraResultado();
            }
            nome.Clear();
            cpf.Clear();
            rg.Clear();
            endereco.Clear();
            telefone.Clear();
            objetivo1.Clear();
            txtidade.Clear();
            mskpeso.Clear();
            mskaltura.Clear();
            imc1.Clear();
            saude.Clear();
            obs1.Clear();

        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mskaltura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mskaltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskpeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private List<Pesquisa> ObterLista(string Pedd, string termo)
        {
            mDataSet = new DataSet();
            //Instância da conexão
            string config = "server = localhost; userid = root; database = acadsystem; pwd = etec-2014";
            MySqlConnection Conexao = new MySqlConnection(config);
            //Instancia da lista que será retornada
            List<Pesquisa> lista = new List<Pesquisa>();
            //query do Comando utilizando o parametro recebido pelo método
            string query = "SELECT * FROM tbcadcli WHERE " + termo + " LIKE '%" + Pedd + "%' ";

            mAdapter = new MySqlDataAdapter(query, Conexao);
            mAdapter.Fill(mDataSet, "tbcadcli");

            //Abro conexão
            Conexao.Open();
            //Instancia do comando
            MySqlCommand cmd = new MySqlCommand(query, Conexao);
            //instancia do leitor
            MySqlDataReader leitor = cmd.ExecuteReader();
            //Se há linhas

            if (leitor.HasRows)
            {
                dvgPesq.DataSource = mDataSet;
                dvgPesq.DataMember = "tbcadcli";
            }
            else
            {
                MessageBox.Show("Este dado não consta no banco de dados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Fecha conexão
            Conexao.Close();

            //Retorno da lista
            return lista;
        }

        private void bttpesq_Click(object sender, EventArgs e)
        {
            string pesq = "";

            if (cbPesq.Text == "NOME")
                pesq = "Nome";


            ObterLista(txtPesq.Text, pesq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Persist Security Info = False; server=localhost;database=acadsystem;uid=root;password=etec-2014");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("DELETE FROM tbcadcli WHERE id = " + Convert.ToInt32(textDelete.Text), conexao);

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Deletado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostraResultado();
        }

        private void mskaltura_TextChanged_1(object sender, EventArgs e)
        {
            if (mskpeso.Text != "" && mskaltura.Text != "")
            {
                setImc();
            }
        }

        private void textDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void objetivo_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void peso_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void altura_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
    

