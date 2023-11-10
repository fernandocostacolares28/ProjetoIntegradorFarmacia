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
    public partial class TelaCompra : Form
    {
        public TelaCompra()
        {
            InitializeComponent();

            AcessoBancoDeDados.PreencherComboBoxProduto(CbProduto);
            AcessoBancoDeDados.PreencherComboBoxFornecedor(CbFornecedor);
        }

        private void TbNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbValorProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbQuantidadeVenda_TextChanged(object sender, EventArgs e)
        {
            if (TbQuantidadeCompra.Text == "")
            {

            }
            else
            {
                TbValorTotalCompra.Text = Convert.ToString(Convert.ToDouble(TbValorProduto.Text) * Convert.ToDouble(TbQuantidadeCompra.Text));
            }
        }

        private void BtComprar_Click(object sender, EventArgs e)
        {
            Int64 qtd = Convert.ToInt64(TbQuantidadeCompra.Text);
            string prd = CbProduto.Text;
            EntidadeCompra compra = new EntidadeCompra();
            compra.nomefornecedor = CbFornecedor.Text;
            compra.valortotal_compra = Convert.ToDouble(TbValorTotalCompra.Text);
            compra.nameproduto_compra = CbProduto.Text;
            compra.quantidade_produto = Convert.ToInt64(TbQuantidadeCompra.Text);
            compra.systemData = DateTime.Now;
            AcessoBancoDeDados.NovaCompra(compra);
            AcessoBancoDeDados.AtualizarQuantidadeProdutoCompra(qtd, prd);
            DgvCompra.DataSource = AcessoBancoDeDados.ObterCompraId();
        }

        private void LbxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbValorTotalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnVenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvCompra_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void TelaCompra_Load(object sender, EventArgs e)
        {
            DgvCompra.DataSource = AcessoBancoDeDados.ObterCompraId();
            DgvCompra.Columns[0].Width = 100;
            DgvCompra.Columns[1].Width = 100;
            DgvCompra.Columns[2].Width = 100;
            DgvCompra.Columns[3].Width = 100;
            DgvCompra.Columns[4].Width = 100;
            DgvCompra.Columns[5].Width = 100;
        }

        private void CbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcessoBancoDeDados.PreencherComboBoxProduto(CbProduto);
        }

        private void CbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcessoBancoDeDados.PreencherComboBoxFornecedor(CbFornecedor);
        }

        private void CbProduto_TextChanged(object sender, EventArgs e)
        {
            string name = CbProduto.Text;
            DataTable dt = new DataTable();
            dt = AcessoBancoDeDados.ObterDadosVendaId(name);
            TbValorProduto.Text = dt.Rows[0].Field<Double>("valor_produto").ToString();
        }
    }
}
