using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;
using Utility;

namespace DAL
{
    public class MovimentoDAL
    {
        public static void create(Movimento movimento)
        {
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "INSERT INTO Movimento(ID, Ide, TotalDesconto, TotalFinal,DataAlteracao,DataCriacao, Status,Funcionario__Id,Cliente__id)"+
                                            "VALUES(@Id_movimento, @Ide, @Desconto, @TotalFinal, GETDATE(), GETDATE(), @status, @FuncionarioId, @ClienteID)";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id_movimento", movimento.Codigo);
                    cmd.Parameters.AddWithValue("@Ide", movimento.Ide);
                    cmd.Parameters.AddWithValue("@Desconto", movimento.TotalDesconto);
                    cmd.Parameters.AddWithValue("@TotalFinal", movimento.TotalFinal);
                    cmd.Parameters.AddWithValue("@FuncionarioId", movimento.funcionario__Id);
                    cmd.Parameters.AddWithValue("@ClienteID", movimento.cliente__Id);
                    cmd.Parameters.AddWithValue("@Status", movimento.Status);

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
        public static void update(Movimento movimento)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Movimento " +
                                            "SET desconto = @Desconto, totalFinal = @TotalFinal,funcionario__Id = @FuncionarioId, " +
                                            "cliente__Id = @ClienteId, dataAlteracao = getdate()" +
                                            "WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Desconto", movimento.TotalDesconto);
                    cmd.Parameters.AddWithValue("@TotalFinal", movimento.TotalFinal);
                    cmd.Parameters.AddWithValue("@FuncionarioId", movimento.funcionario__Id);
                    cmd.Parameters.AddWithValue("@ClienteId", movimento.cliente__Id);
                    cmd.Parameters.AddWithValue("@Status", movimento.Status);

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
                    const string sqlQuery = "SELECT COUNT(id) FROM Movimento WHERE id = @codigo and status = 0";
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
                    const string sqlQuery = "SELECT MAX(id) FROM movimento";
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
                    const string sqlQuery = "SELECT * from Movimento where Status = 0";
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
                    string sqlQuery = $"SELECT id as Codigo, Ide,nome as Nome, sobrenome as Sobrenome, cpf as CPF, " +
                        $"email as 'E-mail', dataAlteracao as 'Data alteração', dataCriacao as 'Data Criação' from Movimento " +
                        $"where nome LIKE '%{valor}%' OR sobrenome LIKE '%{valor}%' or email LIKE '%{valor}%' and Status = 0";
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
                    string sqlQuery = $"SELECT * from Movimento " +
                        $"where (id = {valor} or ide = '{valor}%') and Status = 0";
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
        public static Movimento get(int codigo)
        {
            string textConnection = Common.get();
            Movimento movimento = new Movimento();
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"Select m.ID, m.TotalDesconto, m.TotalFinal, m.Funcionario__Id, m.Cliente__id, c.nome" +
                                            @"from movimento m"+
                                            @"inner join Cliente c on c.id = m.Cliente__id"+
                                            @"inner join Funcionarios f on f.Id = m.Funcionario__Id"+
                                            @"where id = @codigo or ide = @ide";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    //convert(date,m.DataCriacao) ,
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        movimento.Codigo = (int)dr[0];
                        movimento.TotalDesconto = (decimal)dr[1];
                        movimento.TotalFinal = (decimal)dr[2];
                        movimento.funcionario__Id = dr[3].ToString();
                        movimento.Cpf = dr[4].ToString();
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

            return movimento;
        }
        public static void delete(int codigo)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE Movimento SET Status = -1 WHERE Id = @Codigo";
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
