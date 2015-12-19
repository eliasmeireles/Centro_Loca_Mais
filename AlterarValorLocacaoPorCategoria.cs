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
    public partial class AlterarValorLocacaoPorCategoria : Form
    {
        public AlterarValorLocacaoPorCategoria()
        {
            InitializeComponent();
            lblinformacao.ForeColor = Color.Red;
            lblinformacao.Text = "Se você alterar um valor por categoria,\n"
                + "todos os veiculos dessa mesma categoria teram o mesmo valor de locação!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Database database = new Database();
            MySqlConnection conexao = database.conexaoBd();
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT id FROM carro_categoria WHERE categoria_nome = ?categoria_nome;", conexao);
                comando.Parameters.AddWithValue("?categoria_nome", txtCategoria.Text);
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                comando.ExecuteReader();
                conexao.Close();
                adapter.Fill(tabela);
                int codigo_categoria = int.Parse(tabela.Rows[0]["id"].ToString());


                comando = new MySqlCommand("UPDATE carro SET valor_locacao = ?valor_locacao WHERE id_carro_categoria = ?id_carro_categoria;", conexao);
                comando.Parameters.AddWithValue("?id_carro_categoria", codigo_categoria);
                comando.Parameters.AddWithValue("?valor_locacao", txtValorLocacao.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                lblinformacao.ForeColor = Color.Green;
                txtCategoria.Text = "";
                txtValorLocacao.Text = "";
                txtCategoria.Focus();
                lblinformacao.Text = "Alteração bem sucedida.";
            }
            catch (Exception)
            {
                txtCategoria.Text = "";
                txtValorLocacao.Text = "";
                txtCategoria.Focus();
                lblinformacao.Text = "Erro ocorrido na alteração de valor\n"
                    + "certifique de digitar valores validos e um categoria existente!"; ;
            }
           
            conexao.Close();


        }
    }
}
        

