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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet dataset;
        
       

        public class Pesquisa
        {
            public string Nome { get; set; }
        }

        private void mostraResultados()
        {
            dataset = new DataSet();
            String config = "server = localhost; userid = root; database = acadsystem; pwd= 'etec-2014' ";
            MySqlConnection Conexao = new MySqlConnection(config);
            MySqlCommand Query = new MySqlCommand();
            Conexao.Open();

            //cria um adapter utilizando a instrução SQL para aceder a tabela
            adaptador = new MySqlDataAdapter("SELECT * FROM cadfuncionario", Conexao);

            //preenche o dataset através do adapter
           adaptador.Fill(dataset, "Pedido");

            //atribui o resultado à propriedade DataSource da dataGridView
            dvgPesq.DataSource = dataset;
            dvgPesq.DataMember = "Pedido";
            dvgPesq.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            Conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nome.Text == "" ||
                  cpf.Text == "" ||
                  rg.Text == "" ||
          telefone.Text == "" ||
          endereco.Text == "" ||
          funcao.Text == "" ||
           horaentrada.Text == "" ||
           horasaida.Text == "" ||
           salario.Text == "" ||
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

                string insertSQL = "insert tbcadcli(nome, cpf, rg, endereco, telefone, funcao, horaentrada, horasaida, salario, saude, obs) values ('" + nome.Text +
                                            "', '" + cpf.Text +
                                            "', '" + rg.Text +
                                            "', '" + endereco.Text +
                                            "', '" + telefone.Text +
                                            "', '" + funcao.Text +
                                            "', '" + horaentrada.Text +
                                            "', '" + horasaida.Text +
                                            "', '" + salario.Text +
                                            "', '" + saude.Text +
                                            "', '" + obs1.Text + "')";

                MySqlCommand command = new MySqlCommand(insertSQL, Conexao);

                command.ExecuteNonQuery();


                {
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    mostraResultados();
                }

                Conexao.Close();
                mostraResultados();
            }
            nome.Clear();
            cpf.Clear();
            rg.Clear();
            endereco.Clear();
            telefone.Clear();
            funcao.Clear();
            horaentrada.Clear();
            horasaida.Clear();
            salario.Clear();
            saude.Clear();
            obs1.Clear();
            nome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Persist Security Info = False; server=localhost;database=acadsystem;uid=root;password=etec-2014");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("DELETE FROM cadfuncionario WHERE id = " + Convert.ToInt32(textDelete.Text), conexao);

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Deletado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostraResultados();
        }

        private void bttpesq_Click(object sender, EventArgs e)
        {
            string pesq = "";

            if (cbPesq.Text == "NOME")
                pesq = "Nome";


            ObterLista(txtPesq.Text, pesq);
        }
        private List<Pesquisa> ObterLista(string Pedd, string termo)
        {
            dataset = new DataSet();
            //Instância da conexão
            string config = "server = localhost; userid = root; database = acadsystem; pwd = etec-2014";
            MySqlConnection Conexao = new MySqlConnection(config);
            //Instancia da lista que será retornada
            List<Pesquisa> lista = new List<Pesquisa>();
            //query do Comando utilizando o parametro recebido pelo método
            string query = "SELECT * FROM cadfuncionario WHERE " + termo + " LIKE '%" + Pedd + "%' ";

            adaptador = new MySqlDataAdapter(query, Conexao);
            adaptador.Fill(dataset, "tbcadcli");

            //Abro conexão
            Conexao.Open();
            //Instancia do comando
            MySqlCommand cmd = new MySqlCommand(query, Conexao);
            //instancia do leitor
            MySqlDataReader leitor = cmd.ExecuteReader();
            //Se há linhas

            if (leitor.HasRows)
            {
                dvgPesq.DataSource = dataset;
                dvgPesq.DataMember = "cadfuncionario";
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



    }
}
