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
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();

            
            AcessoBancoDeDados.PreencherComboBoxProduto(CbProduto);
            AcessoBancoDeDados.PreencherComboBoxCliente(CbCliente);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtVender_Click(object sender, EventArgs e)
        {
            Int64 qtd = Convert.ToInt64(TbQuantidadeVenda.Text);
            string prd = CbProduto.Text;
            EntidadeVenda venda = new EntidadeVenda();
            venda.id_cliente = CbCliente.Text;
            venda.valor_venda = Convert.ToDouble(TbValorTotalVenda.Text);
            venda.name_produtovenda = CbProduto.Text;
            venda.quantidade_produto = Convert.ToInt64(TbQuantidadeVenda);
            venda.systemData = DateTime.Now;
            AcessoBancoDeDados.NovaVenda(venda);
            AcessoBancoDeDados.AtualizarQuantidadeProduto(qtd, prd);

        }

        private void PnVenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbValorTotalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            DgvVenda.DataSource = AcessoBancoDeDados.ObterVendaId();
            DgvVenda.Columns[0].Width = 100;
            DgvVenda.Columns[1].Width = 100;
            DgvVenda.Columns[2].Width = 100;
            DgvVenda.Columns[3].Width = 100;
            DgvVenda.Columns[4].Width = 100;
        }


        private void CbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcessoBancoDeDados.PreencherComboBoxProduto(CbProduto);

            
        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcessoBancoDeDados.PreencherComboBoxCliente(CbCliente);
        }

        private void CbProduto_TextChanged(object sender, EventArgs e)
        {
            string name = CbProduto.Text;
            DataTable dt = new DataTable();
            dt = AcessoBancoDeDados.ObterDadosVendaId(name);
            TbValorProduto.Text = dt.Rows[0].Field<Double>("valor_produto").ToString();
        }


        private void TbQuantidadeVenda_TextChanged(object sender, EventArgs e)
        {
            TbValorTotalVenda.Text = Convert.ToString(Convert.ToDouble(TbValorProduto.Text) * Convert.ToDouble(TbQuantidadeVenda.Text));
        }


        private void DgvVenda_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
