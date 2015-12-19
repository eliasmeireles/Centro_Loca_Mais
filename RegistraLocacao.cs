using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Loca_Mais
{
    public partial class RegistraLocacao : Form
    {
        public RegistraLocacao()
        {
            InitializeComponent();
            lblInformaErro.ForeColor = Color.Red;
            lblInformaErro.Text = "Click no botão Lista de Veiculos para ver todos cadastrados!";
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            mkdTxtCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MySqlConnection conexao = database.conexaoBd();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT id, nome, sobrenome, email From cliente  WHERE cpf = ?cpf;", conexao);
                comando.Parameters.AddWithValue("?cpf", mkdTxtCpfCliente.Text);

                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                comando.ExecuteReader();
                conexao.Close();
                adapter.Fill(tabela);
                int id = int.Parse(tabela.Rows[0]["id"].ToString());
                lblNomeCliente.Text = tabela.Rows[0]["nome"].ToString() + " " + tabela.Rows[0]["sobrenome"].ToString();
                lblEmailCliente.Text = tabela.Rows[0]["email"].ToString();
                comando = new MySqlCommand("SELECT carro_nome, placa, valor_locacao From carro  WHERE id= ?id;", conexao);
                comando.Parameters.AddWithValue("?id", int.Parse(txtcarroId.Text));

                conexao.Open();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(comando);
                DataTable tabelaC = new DataTable();

                comando.ExecuteReader();
                conexao.Close();
                adapter2.Fill(tabelaC);

                lblCarroNome.Text = tabelaC.Rows[0]["carro_nome"].ToString();
                lblcarroPlaca.Text = tabelaC.Rows[0]["placa"].ToString();
                lblCarroValorlocacao.Text = tabelaC.Rows[0]["valor_locacao"].ToString();

                string data_locacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("es-US"));

                comando = new MySqlCommand("INSERT INTO registro_locacao(cliente_id, carro_id, data_locacao) values(?cliente_id, ?carro_id, ?data_locacao);", conexao);
                comando.Parameters.AddWithValue("?cliente_id", id);
                comando.Parameters.AddWithValue("?carro_id", txtcarroId.Text);
                comando.Parameters.AddWithValue("?data_locacao", data_locacao);

                conexao.Open();
                comando.ExecuteReader();
                conexao.Close();
                lblDataLocacao.Text = data_locacao;
                lblInformaErro.ForeColor = Color.Green;
                lblInformaErro.Text = "Cdastro efetuado com sucesso";

            }
            catch (Exception)
            {
                lblInformaErro.ForeColor = Color.Red;
                lblInformaErro.Text = "Erro inesperado!";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeLocacao cadastroLocacao = new CadastroDeLocacao();
            cadastroLocacao.Show();
        }
    }
}
