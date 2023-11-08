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
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void TbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbEnderecoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void PnCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtSalvarCliente_Click(object sender, EventArgs e)
        {
            EntidadeCliente cliente = new EntidadeCliente();
            cliente.name_cliente = TbNome.Text;
            cliente.cpf_cliente = Convert.ToInt64(TbCPFCliente.Text);
            cliente.telefone_cliente = Convert.ToInt64(TbTelefoneCliente.Text);
            cliente.endereco_cliente = TbEnderecoCliente.Text;
            AcessoBancoDeDados.NovoCliente(cliente);
            TbNome.Clear();
            TbCPFCliente.Clear();
            TbTelefoneCliente.Clear();
            TbEnderecoCliente.Clear();
        }

        private void TbCPFCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            TbNome.Clear();
            TbCPFCliente.Clear();
            TbTelefoneCliente.Clear();
            TbEnderecoCliente.Clear();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditarCliente telaEditarCliente = new TelaEditarCliente();
            telaEditarCliente.ShowDialog();
        }
    }
}
