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
    public class FuncionarioDAL
    {
        public static void create(Funcionario func)
        {
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "INSERT INTO Funcionarios(id, ide, nome, funcao, comissao, dataCriacao,dataAlteracao, status) " +
                                            "VALUES(@Id ,@Ide, @Nome, @Funcao, @Comissao, getdate(),getdate(), @Status)";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id", func.Codigo);
                    cmd.Parameters.AddWithValue("@Ide", func.Ide);
                    cmd.Parameters.AddWithValue("@Nome", func.Nome);
                    cmd.Parameters.AddWithValue("@Funcao", func.Funcao);
                    cmd.Parameters.AddWithValue("@Comissao", func.Comissao);//nome do parametro e valor pra ser adicionado             
                    cmd.Parameters.AddWithValue("@Status", func.Status);

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
        public static void update(Funcionario func)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Funcionarios " +
                                            "SET Nome = @Nome, Funcao = @Funcao, @Comissao = comissao, dataAlteracao = getdate() " +
                                            "WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Codigo", func.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", func.Nome);
                    cmd.Parameters.AddWithValue("@Funcao", func.Funcao);
                    cmd.Parameters.AddWithValue("@Comissao", func.Comissao);

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
                    const string sqlQuery = "SELECT COUNT(id) FROM Funcionarios WHERE id = @codigo and status = 0";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    conec.Open();
                    cmd.ExecuteNonQuery();
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta
                    //Isso Explica o pq de usar o COUNT na consulta do BD
                    if (valor == 0)
                    {
                        logic = true;
                    }
                    else
                    {
                        logic = false;
                    }
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
                    const string sqlQuery = "SELECT MAX(id) FROM FUNCIONARIOS";
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
                    const string sqlQuery = "SELECT  id as Codigo, ide, nome, funcao, comissao, dataCriacao,dataAlteracao, Status " +
                        "FROM Funcionarios WHERE Status = 0";
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
                    string sqlQuery = $"SELECT id as Codigo, Ide,nome as Nome, funcao as Função, comissao as Comissão, " +
                        $"dataAlteracao as 'Data alteração', dataCriacao as 'Data Criação', status as Status from Funcionarios " +
                        $"where nome LIKE '%{valor}%' OR ide LIKE '%{valor}%' or funcao LIKE '%{valor}%' and Status = 0";
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
                    string sqlQuery = $"SELECT id as Codigo, Ide,nome as Nome, sobrenome as Sobrenome, cpf as CPF, " +
                        $"email as 'E-mail', dataAlteracao as 'Data alteração', dataCriacao as 'Data Criação' from Cliente " +
                        $"where id = {valor} or cpf LIKE '{valor}%' and Status = 0";
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
        public static Funcionario get(int codigo)
        {
            string textConnection = Common.get();
            Funcionario funcionario = new Funcionario();
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT Id,Nome, Funcao, Comissao FROM Funcionarios WHERE Id = @Codigo and Status = 0";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        funcionario.Codigo = (int)dr[0];
                        funcionario.Nome = dr[1].ToString();
                        funcionario.Funcao = dr[2].ToString();
                        funcionario.Comissao = (decimal)dr[3];
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

            return funcionario;
        }
        public static void delete(int codigo)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Funcionarios SET Status = -1 WHERE Id = @Codigo";
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
