using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Loca_Mais
{
    public partial class RegistroDeClientes : Form
    {
        private long clienteCodigoDeRegistro;
        public RegistroDeClientes()
        {
            InitializeComponent();
        }
        Database database = new Database();


        private void btnFinalizarClienteCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mkdTxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkdTxtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkdTxtTelefoneResidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            try
            {
                registraDadosCliente();
                registraEnderecoCliente();
                LblInformaErro.ForeColor = Color.Green;
                LblInformaErro.Text = "Cliente cadastrado com sucesso";
            }
            catch (MySqlException )
            {
                LblInformaErro.ForeColor = Color.Red;
                LblInformaErro.Text = "Falha no cadastro \nCliente já cadastrado ou você está enserindo dados incorrento"
                    + "\nTente outro CPF e outro email e tente novamente";
            }
        }
        public void registraDadosCliente()
        {
            MySqlConnection conexao = database.conexaoBd();
            MySqlCommand comando = new MySqlCommand("INSERT INTO cliente(cpf, nome, sobrenome, email, telefone_residencial, celular)"
                                                     + " VALUES(?cpf, ?nome,?sobrenome, ?email, ?telefone_residencial, ?celular);", conexao);
            comando.Parameters.AddWithValue("?cpf", mkdTxtCpf.Text);
            comando.Parameters.AddWithValue("?nome", txtNome.Text);
            comando.Parameters.AddWithValue("?sobrenome", txtSobrenome.Text);
            comando.Parameters.AddWithValue("?email", txtEmail.Text);
            comando.Parameters.AddWithValue("?telefone_residencial", mkdTxtTelefoneResidencial.Text);
            comando.Parameters.AddWithValue("?celular", mkdTxtCelular.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
            clienteCodigoDeRegistro = comando.LastInsertedId;
        }
        public void registraEnderecoCliente()
        {
            mskNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MySqlConnection conexao = database.conexaoBd();
            MySqlCommand comando = new MySqlCommand("INSERT INTO endereco(cliente_id, rua, numero, complemento, bairro, cidade)"
                                                    + " VALUES(?cliente_id, ?rua, ?numero, ?complemento, ?bairro, ?cidade);", conexao);
            comando.Parameters.AddWithValue("?cliente_id", clienteCodigoDeRegistro);
            comando.Parameters.AddWithValue("?rua", txtRua.Text);
            comando.Parameters.AddWithValue("?numero", int.Parse(mskNumero.Text));
            comando.Parameters.AddWithValue("?complemento", txtComplemento.Text);
            comando.Parameters.AddWithValue("?bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("?cidade", txtCidade.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkdTxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MySqlConnection conexao = database.conexaoBd();
            MySqlCommand comando = new MySqlCommand("SELECT c.id, c.cpf, c.nome, c.sobrenome, c.email, c.telefone_residencial, c.celular, e.rua, e.numero, e.complemento, e.bairro, e.cidade FROM cliente c "
                                                     + " JOIN endereco e ON e.cliente_id = c.id WHERE c.cpf LIKE ?cpf;", conexao);
            comando.Parameters.AddWithValue("?cpf", mkdTxtCpf.Text);

            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            try
            {
                txtNome.Text = tabela.Rows[0]["nome"].ToString();
                txtSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                txtEmail.Text = tabela.Rows[0]["email"].ToString();
                mkdTxtTelefoneResidencial.Text = tabela.Rows[0]["telefone_residencial"].ToString();
                mkdTxtCelular.Text = tabela.Rows[0]["celular"].ToString();
                mskNumero.Text = tabela.Rows[0]["numero"].ToString();
                txtRua.Text = tabela.Rows[0]["rua"].ToString();
                txtComplemento.Text = tabela.Rows[0]["complemento"].ToString();
                txtBairro.Text = tabela.Rows[0]["bairro"].ToString();
                txtCidade.Text = tabela.Rows[0]["cidade"].ToString();
                lblInformaErro.ForeColor = Color.Black;
                lblInformaErro.Text = "Código de cadastro do cliente " + tabela.Rows[0]["id"].ToString();

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
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            mkdTxtTelefoneResidencial.Text = "";
            mkdTxtCelular.Text = "";
            mskNumero.Text = "";
            txtRua.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
        }
    }
}
