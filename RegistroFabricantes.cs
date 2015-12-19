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
    public partial class RegistroFabricantes : Form
    {
        public RegistroFabricantes()
        {
            InitializeComponent();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            MySqlConnection conexao = database.conexaoBd();
            while (txtNomeFabrincate.Text == "")
            {
                txtNomeFabrincate.Focus();
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "Informe o nome to fabricante!";
                return;
            }
            try
            {
                MySqlCommand comando = new MySqlCommand("INSERT INTO carro_fabricante(nome_fabricante) values(?nome_fabricante);", conexao);
                comando.Parameters.AddWithValue("?nome_fabricante", txtNomeFabrincate.Text);
                txtNomeFabrincate.Text = "";
                lblAviso.ForeColor = Color.Green;
                lblAviso.Text = "Adicionado com sucesso";
                txtNomeFabrincate.Focus();
                conexao.Open();
                comando.ExecuteReader();

            }
            catch (Exception)
            {
                txtNomeFabrincate.Focus();
                txtNomeFabrincate.Text = "";
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "Falha ao adicionar o nome do Fabricante\n"
                    + "Talvez esse nome já esta cadastrdo no sistema!";
            }
            conexao.Close();
        }
    }
}
