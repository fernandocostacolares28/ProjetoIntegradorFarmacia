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
    public partial class TelaCadastroFornecedor : Form
    {
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void TbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbIdFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbTelefoneFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNomeFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbEnderecoFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtSalvarFornecedor_Click(object sender, EventArgs e)
        {
            EntidadeFornecedor fornecedor = new EntidadeFornecedor();
            fornecedor.name_fornecedor = TbNomeFornecedor.Text;
            fornecedor.cnpj_fornecedor = Convert.ToInt64(TbCNPJ.Text);
            fornecedor.telefone_fornecedor = Convert.ToInt64(TbTelefoneFornecedor.Text);
            fornecedor.endereco_fornecedor = TbEnderecoFornecedor.Text;
            AcessoBancoDeDados.NovoFornecedor(fornecedor);
            TbNomeFornecedor.Clear();
            TbCNPJ.Clear();
            TbTelefoneFornecedor.Clear();
            TbEnderecoFornecedor.Clear();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditarFornecedor telaEditarFornecedor = new TelaEditarFornecedor();
            telaEditarFornecedor.ShowDialog();
        }
    }
}
