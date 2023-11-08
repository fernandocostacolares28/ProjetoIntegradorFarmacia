using System;
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

        // Funções Fornecedor

        public static void NovoFornecedor(EntidadeFornecedor forn)
        {
            if (verificaCnpjFornecedor(forn))
            {
                MessageBox.Show("Fornecedor já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_fornecedor (name_fornecedor, cnpj_fornecedor, telefone_fornecedor, endereco_fornecedor) VALUES(@name_fornecedor, @cnpj_fornecedor, @telefone_fornecedor, @endereco_fornecedor)";
                cmd.Parameters.AddWithValue("@name_fornecedor", forn.name_fornecedor);
                cmd.Parameters.AddWithValue("@cnpj_fornecedor", forn.cnpj_fornecedor);
                cmd.Parameters.AddWithValue("@telefone_fornecedor", forn.telefone_fornecedor);
                cmd.Parameters.AddWithValue("@endereco_fornecedor", forn.endereco_fornecedor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Fornecedor Cadastrado!!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar novo Fornecedor");
                throw ex;
            }
        }

        public static bool verificaCnpjFornecedor(EntidadeFornecedor forn)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cnpj_fornecedor FROM tb_fornecedor WHERE cnpj_fornecedor = '" + forn.cnpj_fornecedor + "'";
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

        public static void AtualizarFornecedorId(EntidadeFornecedor forn)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_fornecedor SET name_fornecedor = '" + forn.name_fornecedor + "', telefone_fornecedor = '" + forn.telefone_fornecedor + "' , endereco_fornecedor = '" + forn.endereco_fornecedor + "' WHERE id_fornecedor = " + forn.id_fornecedor;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirFornecedorId(EntidadeFornecedor forn)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_fornecedor WHERE id_fornecedor =" + forn.id_fornecedor + "";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterFornecedorId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_fornecedor as ID, name_fornecedor as Empresa, cnpj_fornecedor as CNPJ, telefone_fornecedor as Telefone, endereco_fornecedor as Endereço FROM tb_fornecedor";
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
        public static DataTable ObterDadosFornecedorId(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_fornecedor WHERE id_fornecedor =" + id;
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

        //Fim Funções Fornecedor

        // Funções Produto

        public static void NovoProduto(EntidadeProduto pro)
        {
            if (verificaProdutoName(pro))
            {
                MessageBox.Show("Produto já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_produto (name_produto, valor_produto, quantidadeestoque_produto) VALUES(@name_produto, @valor_produto, @quantidadeestoque_produto)";
                cmd.Parameters.AddWithValue("@name_produto", pro.name_produto);
                cmd.Parameters.AddWithValue("@valor_produto", pro.valor_produto);
                cmd.Parameters.AddWithValue("@quantidadeestoque_produto", pro.quantidadeestoque_produto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Produto Cadastrado!!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar novo produto");
                throw ex;
            }
        }

        public static bool verificaProdutoName(EntidadeProduto pro)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT name_produto FROM tb_produto WHERE name_produto = '" + pro.name_produto + "'";
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

        public static DataTable ObterProdutoId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_produto as ID, name_produto as Usuario, valor_produto as Valor, quantidadeestoque_produto as Quantidade FROM tb_produto";
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

        public static void AtualizarProdutoId(EntidadeProduto pro)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_produto SET name_produto = @name_produto, valor_produto = @valor_produto, quantidadeestoque_produto = @quantidadeestoque_produto WHERE id_produto = @id_produto";
                cmd.Parameters.AddWithValue("@name_produto", pro.name_produto);
                cmd.Parameters.AddWithValue("@valor_produto", pro.valor_produto);
                cmd.Parameters.AddWithValue("@quantidadeestoque_produto", pro.quantidadeestoque_produto);
                cmd.Parameters.AddWithValue("@id_produto", pro.id_produto);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirProdutoId(EntidadeProduto pro)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_produto WHERE id_produto =" + pro.id_produto + "";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosProdutoId(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_produto WHERE id_produto =" + id;
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

        //Fim funções Produto

        //Inicio Funções Venda

        public static DataTable ObterDadosVendaId(String name)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT valor_produto FROM tb_produto WHERE name_produto = '"+name+"'";
                //cmd.Parameters.AddWithValue("@name", name);
                //string res = @"SELECT valor_produto FROM tb_produto WHERE name_produto = '"+name+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                //dt.ToString();
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void PreencherComboBoxProduto(ComboBox comboBox)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT name_produto FROM tb_produto"; 
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            comboBox.Items.Add(reader["name_produto"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher o ComboBox: " + ex.Message);
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }

        public static void PreencherComboBoxCliente(ComboBox comboBox)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT name_cliente FROM tb_cliente"; 
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            comboBox.Items.Add(reader["name_cliente"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher o ComboBox: " + ex.Message);
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }

        public static void NovaVenda(EntidadeVenda v)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                if(v.quantidade_produto > )
                cmd.CommandText = "INSERT INTO tb_venda (nomecli, name_produtovenda, valor_venda, quantidade_produto, systemdata) VALUES(@nomecli, @name_produtovenda, @valor_venda, @quantidade_produto, @systemdata)";
                cmd.Parameters.AddWithValue("@nomecli", v.nomecli);
                cmd.Parameters.AddWithValue("@name_produtovenda", v.name_produtovenda);
                cmd.Parameters.AddWithValue("@valor_venda", v.valor_venda);
                cmd.Parameters.AddWithValue("@quantidade_produto", v.quantidade_produto);
                cmd.Parameters.AddWithValue("@systemdata", v.systemData);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nova Venda Realizada!!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a Venda!");
                throw ex;
            }
        }

        public static void AtualizarQuantidadeProduto(Int64 qtd, string pdt)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_produto SET quantidadeestoque_produto = quantidadeestoque_produto - @qtd WHERE name_produto = @pdt";
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@pdt", pdt);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterVendaId()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_venda as ID, nomecli as Cliente, name_produtovenda as Produto, valor_venda as Valor, quantidade_produto as Quantidade, systemdata as Data FROM tb_venda";
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

        //Fim Funções Venda
        public static bool verificaUserName(EntidadeUsuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT name_user FROM tb_user WHERE name_user = '" + u.name_user + "'";
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
