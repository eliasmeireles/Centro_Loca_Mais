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
    public partial class RegistraCategoria : Form
    {
        public RegistraCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            MySqlConnection conexao = database.conexaoBd();
            while (txtnomeCategoria.Text =="")
            {
                lblAviso.ForeColor = Color.Red;
                txtnomeCategoria.Focus();
                lblAviso.Text = "Informe a Categoria!";
                return;
            }
            try
            {
            MySqlCommand comando = new MySqlCommand("INSERT INTO carro_categoria(categoria_nome) values(?categoria_nome);", conexao);
            comando.Parameters.AddWithValue("?categoria_nome", txtnomeCategoria.Text);

            lblAviso.ForeColor = Color.Green;
            txtnomeCategoria.Text = "";
            txtnomeCategoria.Focus();
            lblAviso.Text = "Categoria adicionada com sucesso";
            conexao.Open();
            comando.ExecuteReader();

            }
            catch (Exception)
            {
                lblAviso.ForeColor = Color.Red;
                txtnomeCategoria.Text = "";
                txtnomeCategoria.Focus();
                lblAviso.Text = "Falha ao adicionar\n"
                    + "talvez essa categoria  já esteje cadastrada em nosso sistema!";
            }
            conexao.Close();
        }
    }
}
