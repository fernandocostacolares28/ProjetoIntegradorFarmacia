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
    public partial class TelaEditarCliente : Form
    {
        public TelaEditarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = AcessoBancoDeDados.ObterDadosClienteId(vid);
                TbIdCliente.Text = dt.Rows[0].Field<Int64>("id_cliente").ToString();
                TbNome.Text = dt.Rows[0].Field<string>("name_cliente");
                TbCPFCliente.Text = dt.Rows[0].Field<Int64>("cpf_cliente").ToString(); 
                TbTelefoneCliente.Text = dt.Rows[0].Field<Int64>("telefone_cliente").ToString();
                TbEnderecoCliente.Text = dt.Rows[0].Field<string>("endereco_cliente");
            }
        }

        private void TbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaEditarCliente_Load(object sender, EventArgs e)
        {
            DgvCliente.DataSource = AcessoBancoDeDados.ObterClienteId();
            DgvCliente.Columns[0].Width = 100;
            DgvCliente.Columns[1].Width = 100;
            DgvCliente.Columns[2].Width = 100;
            DgvCliente.Columns[3].Width = 100;
            DgvCliente.Columns[4].Width = 100;
        }

        private void BtSalvarCliente_Click(object sender, EventArgs e)
        {
            EntidadeCliente cli = new EntidadeCliente();
            cli.id_cliente = Convert.ToInt32(TbIdCliente.Text);
            cli.name_cliente = TbNome.Text;
            cli.cpf_cliente = Convert.ToInt64(TbCPFCliente.Text);
            cli.telefone_cliente = Convert.ToInt64(TbTelefoneCliente.Text);
            cli.endereco_cliente = TbEnderecoCliente.Text;
            AcessoBancoDeDados.AtualizarClienteId(cli);
            DgvCliente.DataSource = AcessoBancoDeDados.ObterClienteId();
            TbIdCliente.Clear();
            TbNome.Clear();
            TbCPFCliente.Clear();
            TbTelefoneCliente.Clear();
            TbEnderecoCliente.Clear();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            EntidadeCliente cli = new EntidadeCliente();
            cli.id_cliente = Convert.ToInt32(TbIdCliente.Text);
            cli.name_cliente = TbNome.Text;
            cli.cpf_cliente = Convert.ToInt64(TbCPFCliente.Text);
            cli.telefone_cliente = Convert.ToInt64(TbTelefoneCliente.Text);
            cli.endereco_cliente = TbEnderecoCliente.Text;
            AcessoBancoDeDados.ExcluirClienteId(cli);
            DgvCliente.DataSource = AcessoBancoDeDados.ObterClienteId();
            TbIdCliente.Clear();
            TbNome.Clear();
            TbCPFCliente.Clear();
            TbTelefoneCliente.Clear();
            TbEnderecoCliente.Clear();
        }
    }
}
