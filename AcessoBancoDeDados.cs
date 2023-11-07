using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoIntegradorFarmacia
{
    internal class AcessoBancoDeDados
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\ProjetoIntegrador\\ProjetoIntegradorFarmacia\\banco\\banco_farmacia.db");
            conexao.Open();
            return conexao;
        }

        private static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_user";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable Consulta(string sql) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt) ;
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi encontrado nada no sistema!");
                ConexaoBanco().Close();
                throw ex;
            }
        }
    }
}
