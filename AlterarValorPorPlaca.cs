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
    public partial class AlterarValorPorPlaca : Form
    {
        public AlterarValorPorPlaca()
        {
            InitializeComponent();
        }

        private void tbnAlterar_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            string comando = "UPDATE carro SET valor_locacao = ?valor_locacao WHERE placa = ?placa;";

            MySqlCommand comand = database.mysqlComando(comando);
            database.addParametro("?placa", txtPlaca.Text);
                database.addParametro("?valor_locacao", double.Parse(txtValorLocacao.Text));
                database.execultaComando(comando);


                lblInformacao.ForeColor = Color.Green;

                lblInformacao.Text = "Alteração bem sucedida.";
                txtPlaca.Text = "";
                txtValorLocacao.Text = "";
                txtPlaca.Focus();

          
                txtPlaca.Text = "";
                txtValorLocacao.Text = "";
                txtPlaca.Focus();
                lblInformacao.Text = "Erro ocorrido na alteração de valor\n"
                        + "certifique de digitar valores validos e um categoria existente!";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
