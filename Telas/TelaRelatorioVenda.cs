using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;


namespace ProjetoIntegradorFarmacia.Telas
{

    public partial class TelaRelatorioVenda : Form
    {
    
        public TelaRelatorioVenda()
        {
            InitializeComponent();

            //reportViewer1.LocalReport.ReportPath = "CaminhoParaSeuRelatorio.rdlc";
        }

        private void TelaRelatorioVenda_Load(object sender, EventArgs e)
        {
            AcessoBancoDeDados.GerarRelatorioVenda();
        }
    }
}
