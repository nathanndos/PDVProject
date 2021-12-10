using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FuncionarioDAL
    {
        public static void createFunc(Funcionario func)
        {
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConexao))
            {
                try
                {
                    const string sqlQuery = "INSERT INTO Funcionario(Codigo, Nome, Comissao, Funcao) VALUES(@Codigo, @nome, @funcao, @comissao)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@codigo", func.Codigo);
                    cmd.Parameters.AddWithValue("@nome", func.Nome);//nome do parametro e valor pra ser adicionado
                    cmd.Parameters.AddWithValue("@funcao", func.Funcao);
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
        public static void updateFunc(Funcionario func)
        {
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = @"UPDATE Funcionario " +
                                            "SET Nome = @nome, Comissao = @comissao, Funcao = @funcao " +
                                            "WHERE codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@nome", func.Nome);
                    cmd.Parameters.AddWithValue("@comissao", func.Comissao);
                    cmd.Parameters.AddWithValue("@funcao", func.Funcao);
                    cmd.Parameters.AddWithValue("@codigo", func.Codigo);
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
        public static bool findFunc(int codigo)
        {
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            bool logic = false;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try
                {
                    const string sqlQuery = "SELECT COUNT(Codigo) FROM Funcionario WHERE Codigo = @codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    conec.Open();
                    cmd.ExecuteNonQuery();
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());
                    //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta
                    //Isso Explica o pq de usar o COUNT na consulta do BD
                    if (valor == 0) { logic = true; }
                    else { logic = false; }
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
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            int last;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = "SELECT MAX(Codigo) FROM Funcionario";
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
        public static DataTable getData()
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConnection)){
                try{
                    const string sqlQuery = "SELECT Codigo, Nome, Funcao, Comissao FROM Funcionario";
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
        public static DataTable consultFunc(string valor)
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConnection)){
                try{
                    string sqlQuery = $"SELECT Codigo, Nome, Funcao, Comissao FROM Funcionario WHERE Nome LIKE '%{valor}%'";
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
        public static DataTable consultCodigo(int valor)
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    string sqlQuery = $"SELECT Codigo, Nome, Funcao, Comissao FROM Funcionario WHERE codigo = {valor}";
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
    }
}
