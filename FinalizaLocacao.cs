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
    public partial class FinalizaLocacao : Form
    {
        Database database = new Database();
        double valorAPagar;
        int codigoCliente;
        public FinalizaLocacao()
        {
            InitializeComponent();
            txtEmail.Enabled = false;
            txtKilometragemLocacao.Enabled = false;
            txtKilometragemLocacao.Enabled = false;
            txtKilometragemUtilizada.Enabled = false;
            txtNome.Enabled = false;
            txtPlaca.Enabled = false;
            txtValorLocacao.Enabled = false;
            txtVeiculoNome.Enabled = false;
            txtDataLocacao.Enabled = false;
            txtApagar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mkdTxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MySqlConnection conexao = database.conexaoBd();
            MySqlCommand comando = new MySqlCommand("SELECT c.id, c.nome, c.sobrenome, c.email, v.carro_nome, v.placa, v.kilometragem, v.valor_locacao, r.data_locacao FROM registro_locacao r"
                + " JOIN cliente c ON c.id = r.cliente_id JOIN carro v ON v.id =  r.carro_id WHERE cpf = ?cpf;", conexao);
            comando.Parameters.AddWithValue("?cpf", mkdTxtCpf.Text);

            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            string campoOK = "?";
            while (campoOK != "ok")
            {
                if (mkdTxtCpf.Text == "")
                {

                    lblInformaErro.ForeColor = Color.Red;
                    lblInformaErro.Text = "Insira o CPF do cliente!";
                    mkdTxtCpf.Focus();
                    return;
                }
                if (txtKilometragemEntrega.Text == "")
                {
                    lblInformaErro.ForeColor = Color.Red;
                    lblInformaErro.Text = "Insira a kilometragem total do veiculo com apenas números inteiros!";
                    txtKilometragemEntrega.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        int kilometragemDeEntrega = int.Parse(txtKilometragemEntrega.Text);
                        campoOK = "ok";
                    }
                    catch (Exception)
                    {
                        lblInformaErro.ForeColor = Color.Red;
                        txtKilometragemEntrega.Focus();
                        txtKilometragemEntrega.Text = "";

                    }
                }
            }

            try
            {
                lblInformaErro.Text = "";
                txtNome.Text = tabela.Rows[0]["nome"].ToString() + " " + tabela.Rows[0]["sobrenome"].ToString();
                txtEmail.Text = tabela.Rows[0]["email"].ToString();
                txtVeiculoNome.Text = tabela.Rows[0]["carro_nome"].ToString();
                txtDataLocacao.Text = tabela.Rows[0]["data_locacao"].ToString();
                txtKilometragemLocacao.Text = tabela.Rows[0]["kilometragem"].ToString();
                txtPlaca.Text = tabela.Rows[0]["placa"].ToString();
                txtValorLocacao.Text = tabela.Rows[0]["valor_locacao"].ToString();
                txtKilometragemUtilizada.Text = (int.Parse(txtKilometragemEntrega.Text) - int.Parse(txtKilometragemLocacao.Text)).ToString();
                valorAPagar = (double.Parse(txtKilometragemUtilizada.Text) / 100) * double.Parse(txtValorLocacao.Text);
                txtApagar.Text = valorAPagar.ToString("C");
                codigoCliente = int.Parse(tabela.Rows[0]["id"].ToString());
            }
            catch (Exception)
            {
                limparCaixas();
                lblInformaErro.ForeColor = Color.Red;
                lblInformaErro.Text = "Cliente não encontrado, digite um CPF já cadastrado!";
            }
        }
        public void limparCaixas()
        {
            mkdTxtCpf.Text = "";
            txtNome.Text = "";
            txtValorLocacao.Text = "";
            txtVeiculoNome.Text = "";
            txtPlaca.Text = "";
            txtKilometragemUtilizada.Text = "";
            txtEmail.Text = " ";
            txtApagar.Text = "";
            txtDataLocacao.Text = "";
            txtKilometragemLocacao.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkdTxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MySqlConnection conexao = database.conexaoBd();
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT carro_id, data_locacao FROM registro_locacao WHERE cliente_id = ?codigoCliente;", conexao);
                comando.Parameters.AddWithValue("?codigoCliente", codigoCliente);

                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                comando.ExecuteReader();
                conexao.Close();
                adapter.Fill(tabela);

                int codigoCarro = int.Parse(tabela.Rows[0]["carro_id"].ToString());
                DateTime data = DateTime.Parse(tabela.Rows[0]["data_locacao"].ToString());
                string data_locacao = data.ToString("yyyy-MM-dd HH:mm:ss");
                string data_entrega = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("es-US"));


                comando = new MySqlCommand("INSERT INTO historico_locacao(cliente_id, carro_id, data_locacao, kilometragem_usada, valor_pago, data_entrega_veiculo)"
                    + " VALUES(?cliente_id, ?carro_id, ?data_locacao, ?kilometragem_usada, ?valor_pago, ?data_entrega_veiculo);", conexao);
                comando.Parameters.AddWithValue("?cliente_id", codigoCliente);
                comando.Parameters.AddWithValue("?carro_id", codigoCarro);
                comando.Parameters.AddWithValue("?data_locacao", data_locacao);
                comando.Parameters.AddWithValue("?kilometragem_usada", txtKilometragemUtilizada.Text);
                comando.Parameters.AddWithValue("?valor_pago", valorAPagar);
                comando.Parameters.AddWithValue("?data_entrega_veiculo", data_entrega.ToString());

                conexao.Open();
                comando.ExecuteReader();
                conexao.Close();

                comando = new MySqlCommand("DELETE FROM registro_locacao WHERE cliente_id = ?cliente_id AND carro_id = ?carro_id;", conexao);
                comando.Parameters.AddWithValue("?cliente_id", codigoCliente);
                comando.Parameters.AddWithValue("?carro_id", codigoCarro);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                
                comando = new MySqlCommand("UPDATE carro SET kilometragem = ?kilometragen_update WHERE id = ?id;", conexao);
                comando.Parameters.AddWithValue("?id", codigoCarro);
                comando.Parameters.AddWithValue("?kilometragen_update", txtKilometragemEntrega.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                lblInformaErro.Text = "Erro...\n"
                    + "certifique-se de enserir todos os dados corretos!";
            }
           
            conexao.Close();
        }

        private void mkdTxtCpf_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtKilometragemEntrega_Leave(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
