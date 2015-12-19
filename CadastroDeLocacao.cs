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
    public partial class CadastroDeLocacao : Form
    {
        Database data = new Database();
        public CadastroDeLocacao()
        {
            InitializeComponent();
            carrosRegistrados();
        }
        public void carrosRegistrados()
        {
            MySqlConnection conexao = data.conexaoBd();
            MySqlCommand comando = new MySqlCommand("SELECT c.id, c.carro_nome, c.placa, c.kilometragem, c.ano_fabricacao, f.nome_fabricante, cc.categoria_nome, c.valor_locacao FROM carro c"
                                                    + " JOIN carro_categoria cc ON cc.id = c.id_carro_categoria"
                                                    + " JOIN carro_fabricante f on f.id = c.id_carro_fabricante ORDER BY id;", conexao);
            conexao.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            dtwListaCarro.DataSource = tabela;
            
            
        }
    }
}
