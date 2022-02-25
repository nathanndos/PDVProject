using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Utility;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MovimentoProdutoDAL
    {
        public static void create(MovimentoProduto mp)
        {
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "INSERT INTO Movimento_Produto(ID, Ide, TotalFinal,Quantidade, TotalOriginal,Funcionario__Id, Produto__id, movimento__id,DataLancamento, Status)" +
                                            "VALUES(@Id_mp, @Ide, @TotalFinal,@Quantidade, @TotalOriginal, @FuncionarioId,@ProdutoId, @MovimentoId,@DataLancamento,  @status)";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id_mp", mp.Codigo);
                    cmd.Parameters.AddWithValue("@Ide", mp.Ide);
                    cmd.Parameters.AddWithValue("@TotalFinal", mp.TotalFinal);
                    cmd.Parameters.AddWithValue("@Quantidade", mp.Quantidade);
                    cmd.Parameters.AddWithValue("@TotalOriginal", mp.PrecoUnitario);
                    cmd.Parameters.AddWithValue("@ProdutoId", mp.produto__id);
                    cmd.Parameters.AddWithValue("@FuncionarioId", mp.funcionario__id);
                    cmd.Parameters.AddWithValue("@MovimentoId", mp.produto__id  );
                    cmd.Parameters.AddWithValue("@DataLancamento", mp.DataLancamento);
                    cmd.Parameters.AddWithValue("@status", mp.Status);

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
        public static void update(MovimentoProduto mp)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE MovimentoProduto " +
                                            "SET status = 0"+
                                            "WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Codigo", mp.Codigo);

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
                    const string sqlQuery = "SELECT COUNT(id) FROM Movimento_Produto WHERE id = @codigo";
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
                    const string sqlQuery = "SELECT MAX(id) FROM Movimento_Produto";
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
        public static MovimentoProduto get(int codigo)
        {
            string textConnection = Common.get();
            MovimentoProduto mp = new MovimentoProduto();
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"SELECT p.Id, p.Nome,mp.TotalFinal,f.Nome, mp.DataLancamento FROM Movimento_Produto mp"+
	                                          "inner join Produtos p on p.Id = mp.Id"+
                                              "inner join Funcionarios f on f.id = mp.funcionario__id"+
                                              "where ide  = @Ide and status=0";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    //convert(date,m.DataCriacao) ,
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        mp.Codigo = (int)dr[0];
                        mp.ProdutoNome = dr[1].ToString();
                        mp.TotalFinal = (decimal)dr[2];
                        mp.FuncionarioNome = dr[3].ToString();
                        mp.DataLancamento = DateTime.Parse(dr[4].ToString());

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

            return mp;
        }
        public static void delete(int codigo)
        {
            string textConnection = Common.get();
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = @"UPDATE MovimentoProduto SET Status = -1 WHERE Id = @Codigo";
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
