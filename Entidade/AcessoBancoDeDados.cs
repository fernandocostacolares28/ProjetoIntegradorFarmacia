﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ProjetoIntegradorFarmacia.Telas;
using ProjetoIntegradorFarmacia.Entidade;

namespace ProjetoIntegradorFarmacia
{
    internal class AcessoBancoDeDados
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Git\\ProjetoIntegradorFarmacia\\banco\\banco_farmacia.db");
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

            }
            catch (Exception ex)
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
                da.Fill(dt);
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
            }
            catch (Exception ex)
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
                cmd.CommandText = "SELECT * FROM tb_user WHERE id_user =" + id;
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
                cmd.CommandText = "UPDATE tb_user SET password_user = '" + u.password_user + "' WHERE id_user = " + u.id_user;
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
                cmd.CommandText = "DELETE FROM tb_user WHERE id_user =" + u.id_user + "";
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
        // Funções Cliente

        public static void NovoCliente(EntidadeCliente cli)
        {
            if (verificaCpfCliente(cli))
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_cliente (name_cliente, cpf_cliente, telefone_cliente, endereco_cliente) VALUES(@name_cliente, @cpf_cliente, @telefone_cliente, @endereco_cliente)";
                cmd.Parameters.AddWithValue("@name_cliente", cli.name_cliente);
                cmd.Parameters.AddWithValue("@cpf_cliente", cli.cpf_cliente);
                cmd.Parameters.AddWithValue("@telefone_cliente", cli.telefone_cliente);
                cmd.Parameters.AddWithValue("@endereco_cliente", cli.endereco_cliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Cliente Cadastrado!!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar novo usuário");
                throw ex;
            }
        }
        public static bool verificaCpfCliente(EntidadeCliente cli)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cpf_cliente FROM tb_cliente WHERE cpf_cliente = '" + cli.cpf_cliente + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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

        public static DataTable ObterDadosClienteId(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_cliente WHERE id_cliente =" + id;
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

        public static DataTable ObterClienteId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_cliente as ID, name_cliente as Nome, cpf_cliente as CPF, telefone_cliente as Telefone, endereco_cliente as Endereço FROM tb_cliente";
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

        public static void AtualizarClienteId(EntidadeCliente cli)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_cliente SET name_cliente = '" + cli.name_cliente + "', telefone_cliente = '" + cli.telefone_cliente + "' , endereco_cliente = '" + cli.endereco_cliente + "' WHERE id_cliente = " + cli.id_cliente;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirClienteId(EntidadeCliente cli)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_cliente WHERE id_cliente =" + cli.id_cliente + "";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // fim funções Cliente
        public static bool verificaUserName(EntidadeUsuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT name_user FROM tb_user WHERE'" + u.name_user + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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
