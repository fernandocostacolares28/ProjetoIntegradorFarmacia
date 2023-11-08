using ProjetoIntegradorFarmacia.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegradorFarmacia
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            TelaLogin telaLogin = new TelaLogin(this);
            telaLogin.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVenda telaVenda = new TelaVenda();
            telaVenda.ShowDialog();
        }

        private void CompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCompra telaCompra = new TelaCompra();
            telaCompra.ShowDialog();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.ShowDialog();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroFornecedor telaCadastroFornecedor = new TelaCadastroFornecedor();
            telaCadastroFornecedor.ShowDialog();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.ShowDialog();
        }

        private void EstoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroUsuario telaCadastroUsuario = new TelaCadastroUsuario();
            telaCadastroUsuario.ShowDialog();
        }

        private void EditarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditarUsuario telaEditarUsuario = new TelaEditarUsuario();
            telaEditarUsuario.ShowDialog();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditarCliente telaEditarCliente = new TelaEditarCliente();
            telaEditarCliente.ShowDialog();
        }
    }
}
