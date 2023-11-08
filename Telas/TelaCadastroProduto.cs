using ProjetoIntegradorFarmacia.Entidade;
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

namespace ProjetoIntegradorFarmacia
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        private void TbIdProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbQtdProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSalvarProduto_Click(object sender, EventArgs e)
        {
            EntidadeProduto produto = new EntidadeProduto();
            produto.name_produto = TbNomeProduto.Text;
            produto.valor_produto = Convert.ToDouble(TbPrecoProduto.Text);
            produto.quantidadeestoque_produto = Convert.ToInt32(TbQtdProduto.Text);
            AcessoBancoDeDados.NovoProduto(produto);
            TbNomeProduto.Clear();
            TbPrecoProduto.Clear();
            TbQtdProduto.Clear();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            telaEstoque.ShowDialog();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
