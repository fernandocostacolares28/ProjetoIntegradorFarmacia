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
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtVender_Click(object sender, EventArgs e)
        {

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

        }


        private void CbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcessoBancoDeDados.PreencherComboBoxProduto(CbProduto);
            //EntidadeProduto entidadeProduto = new EntidadeProduto();
            //entidadeProduto.name_produto = CbProduto.ToString();
            
        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CbProduto_TextChanged(object sender, EventArgs e)
        {
            string name = CbProduto.Text;
            //DataTable dt = new DataTable();
            //name = AcessoBancoDeDados.ObterDadosVendaId(name);
            //EntidadeProduto entidadeProduto = new EntidadeProduto();
            //entidadeProduto.name_produto = CbProduto.ToString();
            DataTable dt = new DataTable();
            dt = AcessoBancoDeDados.ObterDadosVendaId(name);
            TbValorProduto.Text = dt.Rows[0].Field<Double>("valor_produto").ToString();
        }
    }
}
