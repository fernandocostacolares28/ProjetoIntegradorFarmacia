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
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            InitializeComponent();
        }

        private void BtSalvarProduto_Click(object sender, EventArgs e)
        {
            EntidadeProduto pro = new EntidadeProduto();
            pro.id_produto = Convert.ToInt32(TbIdProduto.Text);
            pro.name_produto = TbNomeProduto.Text;
            pro.valor_produto = Convert.ToDouble(TbPrecoProduto.Text);
            pro.quantidadeestoque_produto = Convert.ToInt64(TbQtdProduto.Text);
            AcessoBancoDeDados.AtualizarProdutoId(pro);
            DgvEstoque.DataSource = AcessoBancoDeDados.ObterProdutoId();
            TbIdProduto.Clear();
            TbNomeProduto.Clear();
            TbPrecoProduto.Clear();
            TbQtdProduto.Clear();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            EntidadeProduto pro = new EntidadeProduto();
            pro.id_produto = Convert.ToInt32(TbIdProduto.Text);
            pro.name_produto = TbNomeProduto.Text;
            pro.valor_produto = Convert.ToDouble(TbPrecoProduto.Text);
            pro.quantidadeestoque_produto = Convert.ToInt64(TbQtdProduto.Text);
            AcessoBancoDeDados.ExcluirProdutoId(pro);
            DgvEstoque.DataSource = AcessoBancoDeDados.ObterProdutoId();
            TbIdProduto.Clear();
            TbNomeProduto.Clear();
            TbPrecoProduto.Clear();
            TbQtdProduto.Clear();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            TbIdProduto.Clear();
            TbNomeProduto.Clear();
            TbPrecoProduto.Clear();
            TbQtdProduto.Clear();
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            DgvEstoque.DataSource = AcessoBancoDeDados.ObterProdutoId();
            DgvEstoque.Columns[0].Width = 100;
            DgvEstoque.Columns[1].Width = 100;
            DgvEstoque.Columns[2].Width = 100;
            DgvEstoque.Columns[3].Width = 100;
        }

        private void DgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = AcessoBancoDeDados.ObterDadosProdutoId(vid);
                TbIdProduto.Text = dt.Rows[0].Field<Int64>("id_produto").ToString();
                TbNomeProduto.Text = dt.Rows[0].Field<string>("name_produto");
                TbPrecoProduto.Text = dt.Rows[0].Field<Double>("valor_produto").ToString();
                TbQtdProduto.Text = dt.Rows[0].Field<Int64>("quantidadeestoque_produto").ToString();
            }
        }
    }
}
