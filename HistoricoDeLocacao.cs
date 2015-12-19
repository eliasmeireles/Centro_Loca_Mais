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
    public partial class HistoricoDeLocacao : Form
    {
        public HistoricoDeLocacao()
        {
            InitializeComponent();
            totalLocacao();
        }
        public void totalLocacao()
        {
            Database database = new Database();
            MySqlConnection conexao = database.conexaoBd();
            MySqlCommand comando = new MySqlCommand(@"SELECT c.nome, c.sobrenome, c.cpf, 
                                                    v.carro_nome Carro, v.placa as Placa, h.kilometragem_usada kilometregem, 
                                                    h.data_locacao  , h.data_entrega_veiculo, 
                                                    h.valor_pago FROM historico_locacao h
                                                    JOIN cliente c ON c.id = h.cliente_id
                                                    JOIN carro v ON v.id = h.carro_id ORDER BY data_locacao;", conexao);
            conexao.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            dlwHistoricoLocacao.DataSource = tabela;


            comando = new MySqlCommand("SELECT count(id) FROM historico_locacao;", conexao);

            DataTable tabela2 = new DataTable();
            conexao.Open();
            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela2);
            int quantidadeNoHistorico = 0;
            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                quantidadeNoHistorico++;
            }
            lblTotalLocacao.Text = quantidadeNoHistorico.ToString();

        }
    }
}
