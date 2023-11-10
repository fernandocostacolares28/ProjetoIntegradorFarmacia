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
    public partial class TelaRelatorioVenda : Form
    {
        public TelaRelatorioVenda()
        {
            InitializeComponent();
        }

        private void TelaRelatorioVenda_Load(object sender, EventArgs e)
        {
            AcessoBancoDeDados.GerarRelatorioVenda();
        }
    }
}
