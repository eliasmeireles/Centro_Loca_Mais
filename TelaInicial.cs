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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVeiculo veiculo = new RegistroVeiculo();
            veiculo.Show();
        }

        private void localizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeClientes registroClientes = new RegistroDeClientes();
            registroClientes.Show();
            registroClientes.MkdTxtCpf.Focus();
            
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeLocacao cadastroLocacao = new CadastroDeLocacao();
            cadastroLocacao.Show();
        }

        private void casdastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeClientes registroClientes = new RegistroDeClientes();
            registroClientes.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistraLocacao registrarLocacao = new RegistraLocacao();
            registrarLocacao.Show(); 
        }

        private void fabricanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroFabricantes fabricante = new RegistroFabricantes();
            fabricante.Show();
        }

        private void modeloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistraCategoria categoria = new RegistraCategoria();
            categoria.Show();
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizaLocacao finalizar = new FinalizaLocacao();
            finalizar.Show();
        }

        private void historioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoDeLocacao historico = new HistoricoDeLocacao();
            historico.Show();
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarValorLocacaoPorCategoria alterarPorCategoria = new AlterarValorLocacaoPorCategoria();
            alterarPorCategoria.Show();
        }

        private void placaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarValorPorPlaca alterarPorPlaca = new AlterarValorPorPlaca();
            alterarPorPlaca.Show();
        }
    }
}
