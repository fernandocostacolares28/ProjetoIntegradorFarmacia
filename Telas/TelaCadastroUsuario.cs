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
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            EntidadeUsuario usuario = new EntidadeUsuario();
            usuario.name_user = TbUsuario.Text;
            usuario.password_user = TbSenha.Text;
            AcessoBancoDeDados.NovoUsuario(usuario);
            TbUsuario.Clear();
            TbSenha.Clear();

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            TbUsuario.Clear();
            TbSenha.Clear();
        }

        private void TelaCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
