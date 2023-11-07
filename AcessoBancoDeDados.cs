using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace ProjetoIntegradorFarmacia
{
    internal class AcessoBancoDeDados
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\ProjetoIntegrador\\ProjetoIntegradorFarmacia\\banco\\banco_farmacia.db");
            conexao.Open();
            return conexao;
        }
    }
}
