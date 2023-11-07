using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ProjetoIntegradorFarmacia.Telas;

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
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_user";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static DataTable Consulta(string sql) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt) ;
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi encontrado nada no sistema!");
                throw ex;
            }
        }
        //////Funções novo Usuário
        
        public static void NovoUsuario(EntidadeUsuario u)
        {
            if (verificaUserName(u))
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_user (name_user, password_user) VALUES(@name_user, @password_user)";
                cmd.Parameters.AddWithValue("@name_user", u.name_user);
                cmd.Parameters.AddWithValue("@password_user", u.password_user);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário Cadastrado!!");
                vcon.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar novo usuário");
                throw ex;
            }
        }


        ///Fim funções novo Usuário
        ///Funções Gestão Usuário 

        public static DataTable ObterUsuariosId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_user as ID, name_user as Usuario FROM tb_user";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuariosId(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_user WHERE id_user ="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuariosId(EntidadeUsuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_user SET password_user = '"+u.password_user+"' WHERE id_user = "+u.id_user;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirUsuariosId(EntidadeUsuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_user WHERE id_user ="+u.id_user+"";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        ///Fim Gestão usuário
        public static bool verificaUserName(EntidadeUsuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT name_user FROM tb_user WHERE'"+u.name_user+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt) ;
            if(dt.Rows.Count > 0)
            {
                res = true;
                return res;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
    }
}
