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
    public partial class RegistroVeiculo : Form
    {
        Database data = new Database();
        public RegistroVeiculo()
        {
            InitializeComponent();
            cbxFabricanteOptions("nome_fabricante", "carro_fabricante", cbxFabricanteNome);
            cbxFabricanteOptions("categoria_nome", "carro_categoria", cbxCategoria);
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conexao = data.conexaoBd();

            try
            {
                int categoriaId = pegaIdItemSelecionado(cbxCategoria.SelectedItem.ToString(), "carro_categoria", "categoria_nome");
                int fabricanteId = pegaIdItemSelecionado(cbxFabricanteNome.SelectedItem.ToString(), "carro_fabricante", "nome_fabricante");
                MySqlCommand comando = new MySqlCommand("INSERT INTO carro(carro_nome, placa, kilometragem, ano_fabricacao, id_carro_fabricante, id_carro_categoria, valor_locacao)"
                                                        + " VALUES(?carro_nome, ?placa, ?kilometragem, ?ano_fabricacao, ?id_carro_fabricante, ?id_carro_categoria, ?valor_locacao);", conexao);
                comando.Parameters.AddWithValue("?carro_nome", txtCarroNome.Text);
                comando.Parameters.AddWithValue("?placa", mkdCarroPlaca.Text.ToString());
                comando.Parameters.AddWithValue("?kilometragem", int.Parse(txtCarroKilometragem.Text.ToString()));
                comando.Parameters.AddWithValue("?ano_fabricacao", mkdCarroAnoFaabricacao.Text);
                comando.Parameters.AddWithValue("?id_carro_fabricante", fabricanteId);
                comando.Parameters.AddWithValue("?id_carro_categoria", categoriaId);
                comando.Parameters.AddWithValue("?valor_locacao", decimal.Parse(txtValorLocacao.Text));

                conexao.Open();
                comando.ExecuteNonQuery();
                lblAvisoDeErro.ForeColor = Color.Green;
                lblAvisoDeErro.Text = "Cadastro efetuado com sucesso";
            }
            catch (Exception)
            {
                lblAvisoDeErro.ForeColor = Color.Red;
                lblAvisoDeErro.Text = "Cadastro negado \n"
                    + "Certifique-se que todos os dados estão inseridos corretamente!";
            }
            conexao.Close();
        }
            public void cbxFabricanteOptions(string nomeAtributo, string nomeTbela, ComboBox cbxNome)
        {
            MySqlConnection conexao = data.conexaoBd();
            MySqlCommand comando = new MySqlCommand("SELECT " + nomeAtributo + " FROM " + nomeTbela + ";", conexao);

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            conexao.Open();
            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                cbxNome.Items.Add(tabela.Rows[i][nomeAtributo].ToString());
            }
           
            cbxNome.AutoScrollOffset.ToString();

           /* cbxNome.DataSource = tabela;
            cbxNome.DisplayMember = nomeAtributo;
            AutoCompleteStringCollection x = new AutoCompleteStringCollection();
            
            foreach (DataRow item in tabela.Rows)
            {
                x.Add(item[0].ToString());
            }
            cbxNome.AutoCompleteCustomSource = x;*/

        }
        public int pegaIdItemSelecionado(string itemSelecionado, string tabelaNome, string atributoNome)
        {
            MySqlConnection conexao = data.conexaoBd();
            MySqlCommand comando = new MySqlCommand("SELECT id FROM " + tabelaNome + " WHERE " + atributoNome + " = " + "?itemSelecionado" + ";", conexao);
            comando.Parameters.AddWithValue("?itemSelecionado", itemSelecionado);

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            conexao.Open();
            comando.ExecuteReader();
            conexao.Close();
            adapter.Fill(tabela);
            int id = int.Parse(tabela.Rows[0]["id"].ToString());

            return id;
        }
        }
}
