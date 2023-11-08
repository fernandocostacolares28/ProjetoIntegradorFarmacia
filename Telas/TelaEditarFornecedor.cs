using ProjetoIntegradorFarmacia.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorFarmacia.Telas
{
    public partial class TelaEditarFornecedor : Form
    {
        public TelaEditarFornecedor()
        {
            InitializeComponent();
        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = AcessoBancoDeDados.ObterDadosFornecedorId(vid);
                TbIdFornecedor.Text = dt.Rows[0].Field<Int64>("id_fornecedor").ToString();
                TbNomeFornecedor.Text = dt.Rows[0].Field<string>("name_fornecedor");
                TbCNPJ.Text = dt.Rows[0].Field<Int64>("cnpj_fornecedor").ToString();
                TbTelefoneFornecedor.Text = dt.Rows[0].Field<Int64>("telefone_fornecedor").ToString();
                TbEnderecoFornecedor.Text = dt.Rows[0].Field<string>("endereco_fornecedor");
            }
        }

        private void BtSalvarFornecedor_Click(object sender, EventArgs e)
        {
            EntidadeFornecedor forn = new EntidadeFornecedor();
            forn.id_fornecedor = Convert.ToInt32(TbIdFornecedor.Text);
            forn.name_fornecedor = TbNomeFornecedor.Text;
            forn.cnpj_fornecedor = Convert.ToInt64(TbCNPJ.Text);
            forn.telefone_fornecedor = Convert.ToInt64(TbTelefoneFornecedor.Text);
            forn.endereco_fornecedor = TbEnderecoFornecedor.Text;
            AcessoBancoDeDados.AtualizarFornecedorId(forn);
            DgvFornecedor.DataSource = AcessoBancoDeDados.ObterFornecedorId();
            TbIdFornecedor.Clear();
            TbNomeFornecedor.Clear();
            TbCNPJ.Clear();
            TbTelefoneFornecedor.Clear();
            TbEnderecoFornecedor.Clear();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            EntidadeFornecedor forn = new EntidadeFornecedor();
            forn.id_fornecedor = Convert.ToInt32(TbIdFornecedor.Text);
            forn.name_fornecedor = TbNomeFornecedor.Text;
            forn.cnpj_fornecedor = Convert.ToInt64(TbCNPJ.Text);
            forn.telefone_fornecedor = Convert.ToInt64(TbTelefoneFornecedor.Text);
            forn.endereco_fornecedor = TbEnderecoFornecedor.Text;
            AcessoBancoDeDados.ExcluirFornecedorId(forn);
            DgvFornecedor.DataSource = AcessoBancoDeDados.ObterFornecedorId();
            TbIdFornecedor.Clear();
            TbNomeFornecedor.Clear();
            TbCNPJ.Clear();
            TbTelefoneFornecedor.Clear();
            TbEnderecoFornecedor.Clear();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            TbIdFornecedor.Clear();
            TbNomeFornecedor.Clear();
            TbCNPJ.Clear();
            TbTelefoneFornecedor.Clear();
            TbEnderecoFornecedor.Clear();
        }

        private void TelaEditarFornecedor_Load(object sender, EventArgs e)
        {
            DgvFornecedor.DataSource = AcessoBancoDeDados.ObterFornecedorId();
            DgvFornecedor.Columns[0].Width = 100;
            DgvFornecedor.Columns[1].Width = 100;
            DgvFornecedor.Columns[2].Width = 100;
            DgvFornecedor.Columns[3].Width = 100;
            DgvFornecedor.Columns[4].Width = 100;
        }
    }
}
