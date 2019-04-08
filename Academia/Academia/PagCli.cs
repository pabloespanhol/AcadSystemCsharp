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
    public partial class PagCli : Form
    {
        public PagCli()
        {
            InitializeComponent();
            setCliente();
            mostraResultados();
            mtxtPag.Text = Convert.ToString(DateTime.Now);
        }

        private DataSet mDataSet;
        private MySqlDataAdapter mAdapter;

        public class Pesquisa
        {
            public string Nome { get; set; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setCliente()
        {
            String config = "server = localhost;userid=root;database=acadsystem;pwd=etec-2014";
            DataTable dtTabela = new DataTable();
            MySqlConnection Conexao = new MySqlConnection(config);
            Conexao.Open();

            //cria o comando para preencher o DataAdapter
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome FROM tbcadcli", Conexao);

            //executa o comando para preencher a Tabela com o DataAdapter
            da.Fill(dtTabela);

            //utiliza como base a tabela
            cbNome.DataSource = dtTabela;
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "Nome";

            //Muda a seleção para vazia
            cbNome.SelectedIndex = -1;
            
            Conexao.Close();
        }

        private void btConf_Click(object sender, EventArgs e)
        {
            if (cbNome.Text == "" ||
                mtxtPag.Text == "" ||
                txtPag.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.");
            }
            else
            {
                string config = "server = localhost;userid=root;database=acadsystem;pwd=etec-2014";
                MySqlConnection Conexao = new MySqlConnection(config);
                MySqlCommand Query = new MySqlCommand();

                Conexao.Open();

                string insertSQL = "insert tbpagamento(Nome, Valor, data_Pagamento) values ('" + cbNome.Text +
                                            "', '" + txtPag.Text +
                                            "', '" + Convert.ToDateTime(mtxtPag.Text).ToString("yyyy/MM/dd") + "')";

                MySqlCommand command = new MySqlCommand(insertSQL, Conexao);

                command.ExecuteNonQuery();

                
                {
                    MessageBox.Show("Pagamento efetuado com sucesso!");
                    mostraResultados();
                }

                Conexao.Close();
                mostraResultados();            
            }
            txtPag.Clear();
            mtxtPag.Clear();
        }


        private void mostraResultados()
        {
            mDataSet = new DataSet();
            String config = "server = localhost; userid = root; database = acadsystem; pwd= 'etec-2014' ";
            MySqlConnection Conexao = new MySqlConnection(config);
            MySqlCommand Query = new MySqlCommand();
            Conexao.Open();

            //cria um adapter utilizando a instrução SQL para aceder a tabela
            mAdapter = new MySqlDataAdapter("SELECT * FROM tbpagamento", Conexao);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "Pedido");

            //atribui o resultado à propriedade DataSource da dataGridView
            dgvPesq.DataSource = mDataSet;
            dgvPesq.DataMember = "Pedido";
            dgvPesq.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            Conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesq = "";

            if (cbPesq.Text == "NOME")
                pesq = "Nome";
  

            ObterLista(txtPesq.Text, pesq);

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
            string query = "SELECT * FROM tbpagamento WHERE " + termo + " LIKE '%" + Pedd + "%' ";

            mAdapter = new MySqlDataAdapter(query, Conexao);
            mAdapter.Fill(mDataSet, "tbpagamento");

            //Abro conexão
            Conexao.Open();
            //Instancia do comando
            MySqlCommand cmd = new MySqlCommand(query, Conexao);
            //instancia do leitor
            MySqlDataReader leitor = cmd.ExecuteReader();
            //Se há linhas

            if (leitor.HasRows)
            {
                dgvPesq.DataSource = mDataSet;
                dgvPesq.DataMember = "tbpagamento";
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

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
