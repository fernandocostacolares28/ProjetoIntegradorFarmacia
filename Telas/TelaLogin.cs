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
    public partial class TelaLogin : Form
    {
        TelaInicial telaInicial;
        DataTable dt = new DataTable();
        public TelaLogin(TelaInicial f)
        {
            InitializeComponent();
            telaInicial = f;
        }

        private void BtLogar_Click(object sender, EventArgs e)
        {
            string username = TbUsuario.Text;
            string senha = TbSenha.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha não preenchidos!!");
                TbUsuario.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_user WHERE name_user ='"+username+"' AND password_user ='"+senha+"'";
            dt = AcessoBancoDeDados.Consulta(sql);
            if(dt.Rows.Count == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!!");
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
