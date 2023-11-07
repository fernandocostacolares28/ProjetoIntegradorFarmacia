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
    public partial class TelaEditarUsuario : Form
    {
        public TelaEditarUsuario()
        {
            InitializeComponent();
        }

        private void TelaEditarUsuario_Load(object sender, EventArgs e)
        {
            DgvUsuario.DataSource = AcessoBancoDeDados.ObterUsuariosId();
            DgvUsuario.Columns[0].Width = 100;
            DgvUsuario.Columns[1].Width = 100;

        }

        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = AcessoBancoDeDados.ObterDadosUsuariosId(vid);
                TbId.Text = dt.Rows[0].Field<Int64>("id_user").ToString();
                TbUsuario.Text = dt.Rows[0].Field<string>("name_user");
                TbSenha.Text = dt.Rows[0].Field<string>("password_user");
            }
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            TbId.Clear();
            TbUsuario.Clear();
            TbSenha.Clear();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            EntidadeUsuario u  = new EntidadeUsuario();
            u.id_user = Convert.ToInt32(TbId.Text);
            u.name_user = TbUsuario.Text;
            u.password_user = TbSenha.Text;
            AcessoBancoDeDados.AtualizarUsuariosId(u);
            DgvUsuario.DataSource = AcessoBancoDeDados.ObterUsuariosId();
            TbId.Clear();
            TbUsuario.Clear();
            TbSenha.Clear();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            EntidadeUsuario u = new EntidadeUsuario();
            u.id_user = Convert.ToInt32(TbId.Text);
            u.name_user = TbUsuario.Text;
            u.password_user = TbSenha.Text;
            AcessoBancoDeDados.ExcluirUsuariosId(u);
            DgvUsuario.DataSource = AcessoBancoDeDados.ObterUsuariosId();
            TbId.Clear();
            TbUsuario.Clear();
            TbSenha.Clear();
        }
    }
}
