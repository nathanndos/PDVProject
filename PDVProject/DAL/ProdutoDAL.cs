using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;
using Utility;

namespace DAL
{
    class ProdutoDAL
    {
        public static void create(Produto produto)
        {
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "INSERT INTO Produtos(id, ide, nome, ncm, preco,codigoFornecedor, dataCriacao,dataAlteracao, status) " +
                                            "VALUES(@Id ,@Ide, @Nome, @Ncm, @Preco, @CodigoFornecedor,getdate(),getdate(), @Status)";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id", produto.Codigo);
                    cmd.Parameters.AddWithValue("@Ide", produto.Ide);
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Ncm", produto.Ncm);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);//nome do parametro e valor pra ser adicionado             
                    cmd.Parameters.AddWithValue("@CodigoFornecedor", produto.CodigoFornecedor);
                    cmd.Parameters.AddWithValue("@Status", produto.Status);

                    conec.Open();//abre a conexao
                    cmd.ExecuteNonQuery();//Executa uma instrução do blocoSQL
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();//dando certo ou errado, fecha a conexao
                }
            }
        }
        public static void update(Produto produto)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Produtos " +
                                            "SET Nome = @Nome, ncm = @Ncm, Preco = @Preco, CodigoFornecedor = @Codigofornecedor," +
                                            "dataAlteracao = getdate() WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Ncm", produto.Ncm);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@Preco", produto.CodigoFornecedor);

                    conec.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
        }
        public static bool find(int codigo)
        {
            string textConnection = Common.get();
            bool logic = false;
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT COUNT(id) FROM Produtos WHERE id = @codigo and status = 0";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    conec.Open();
                    cmd.ExecuteNonQuery();
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta
                    //Isso Explica o pq de usar o COUNT na consulta do BD
                    if (valor == 0)
                        logic = true;
                    else
                        logic = false;
                    //A condição implica diretamente na camada BLL, fazendo uma consulta e verificando existencia do registro
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
            return logic;
        }
        public static int getLastId()
        {
            string textConnection = Common.get();
            int last;
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT MAX(id) FROM Produtos";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    conec.Open();
                    last = int.Parse(cmd.ExecuteScalar().ToString());
                    //Verifica o ultimo id registrado no banco e o retorna

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
            return last;
        }
        public static DataTable getAll()
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT  id as Codigo, ide as Ide, nome as Nome, ncm as NCM, preco as 'Preço', " +
                        "codigoFornecedor as 'Codigo Fornecedor', dataCriacao,dataAlteracao, Status " +
                        "FROM Produtos WHERE Status = 0";
                    conec.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conec))
                    //Representa um conjunto de comandos SQL e uma conexão de banco de dados
                    //serve pra preencher dataset
                    {
                        using (DataTable dt = new DataTable())
                        //representa uma tabela de dados
                        {
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch { throw; }
                finally
                {
                    conec.Close();
                }
            }
        } //Busca todos os dados
        public static DataTable getByName(string valor)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    string sqlQuery = "SELECT  id as Codigo, ide as Ide, nome as Nome, ncm as NCM, preco as Preço " +
                        "codigofornecedor as 'Codigo Fornecedor', dataCriacao,dataAlteracao, Status " +
                        "FROM Produtos WHERE nome LIKE '%{valor}%' OR ide LIKE '%{valor}%' and Status = 0";
                    conec.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conec))
                    //Representa um conjunto de comandos SQL e uma conexão de banco de dados
                    //serve pra preencher dataset
                    {
                        using (DataTable dt = new DataTable())
                        {
                            //representa uma tabela de dados
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch { throw; }
                finally { conec.Close(); }
            }
        }//Consulta por nome
        public static DataTable getById(int valor)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    string sqlQuery = "SELECT  id as Codigo, ide as Ide, nome as Nome, ncm as NCM, preco as Preço " +
                        "codigofornecedor as 'Codigo Fornecedor', dataCriacao,dataAlteracao, Status " +
                        "FROM Produtos WHERE NCM LIKE '%{valor}%' OR codigoFornecedor LIKE '%{valor}%' and Status = 0";
                    conec.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conec))
                    //Representa um conjunto de comandos SQL e uma conexão de banco de dados
                    //serve pra preencher dataset
                    {
                        using (DataTable dt = new DataTable())
                        //representa uma tabela de dados
                        {
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch { throw; }
                finally
                {
                    conec.Close();
                }
            }
        }//Consulta por codigo
        public static Produto get(int codigo)
        {
            string textConnection = Common.get();
            Produto produto = new Produto();
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT Id,Nome, Ncm, Preco, CodigoFornecedor FROM Produtos WHERE Id = @Codigo and Status = 0";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        produto.Codigo = (int)dr[0];
                        produto.Nome = dr[1].ToString();
                        produto.Ncm = dr[2].ToString();
                        produto.Preco = (decimal)dr[3];
                        produto.CodigoFornecedor  = dr[4].ToString();   
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
            return produto;
        }
        public static void delete(int codigo)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Produtos SET Status = -1 WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
        }
    }
}
