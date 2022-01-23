using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace DAL
{
    public class ClienteDAL//Acesso ao banco de Dados
    {
        public static void createClient(Cliente cliente){
            //Maneira atual, visto que as informações do banco vem do ArdId
            string textConexao = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            using (SqlConnection conec = new SqlConnection(textConexao) ) {
                try{
                    const string sqlQuery = "INSERT INTO Cliente(id, ide, nome,sobrenome, cpf, email, dataCriacao,dataAlteracao) " +
                                            "VALUES(@Id_cliente,@Ide, @Nome, @Sobrenome, @CPF, @Email, getdate(),getdate())";

                    SqlCommand cmd = new SqlCommand(sqlQuery,conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id_cliente", cliente.Codigo);
                    cmd.Parameters.AddWithValue("@Ide", cliente.Ide);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", cliente.SobreNome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);//nome do parametro e valor pra ser adicionado
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);

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
        public static void updateClient(Cliente cliente)
        {
            string textConexao = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = @"UPDATE Cliente " +
                                            "SET Nome = @Nome, Sobrenome = @Sobrenome,Email = @Email, Cpf = @Cpf, dataAlteracao = getdate() "+
                                            "WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", cliente.SobreNome);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);

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
        public static bool findClient(int codigo)
        {
            string textConexao = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            bool logic = false;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = "SELECT COUNT(id) FROM Cliente WHERE id = @codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    conec.Open();
                    cmd.ExecuteNonQuery();
                    int valor = int.Parse(cmd.ExecuteScalar().ToString());         
                       //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta
                       //Isso Explica o pq de usar o COUNT na consulta do BD
                    if(valor == 0) { logic = true; }
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
            string textConexao = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            int last;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = "SELECT MAX(id) FROM cliente";
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
            string textConnection = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            using (SqlConnection conec = new SqlConnection(textConnection)){
                try{
                    const string sqlQuery = "SELECT id as Codigo, Ide,nome as Nome, sobrenome as Sobrenome, cpf as CPF, " +
                        "email as 'E-mail', dataAlteracao as 'Data alteração', dataCriacao as 'Data Criação' from Cliente";
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
        public static DataTable consultClient(string valor)
        {
            string textConnection = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            using (SqlConnection conec = new SqlConnection(textConnection)){
                try{
                    string sqlQuery = $"SELECT codigo,nome, sobrenome, email, cpf FROM cliente WHERE Nome LIKE '%{valor}%'";
                    conec.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conec))
                    //Representa um conjunto de comandos SQL e uma conexão de banco de dados
                    //serve pra preencher dataset
                    {
                        using (DataTable dt = new DataTable()){
                            //representa uma tabela de dados
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch { throw; }
                finally{ conec.Close(); }
            }
        }//Consulta por nome
        public static DataTable consultCodigo(int valor)
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConnection)){
                try{
                    string sqlQuery = $"SELECT codigo, nome, sobrenome, email, cpf FROM cliente WHERE codigo = {valor}";
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
        public static Cliente get(int codigo)
        {
            string textConnection = @"Data Source=YMCA-AULTSTRING\SQL2014;Initial Catalog=fakeetrade;User ID=sa;Password=senha";
            Cliente cliente = new Cliente();
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT nome, sobrenome, email, cpf FROM Cliente WHERE Id = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        cliente.Nome = dr[0].ToString();
                        cliente.SobreNome = dr[1].ToString();
                        cliente.Email = dr[2].ToString();
                        cliente.Cpf = dr[3].ToString();
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
            
            return cliente;
        }
    }
}


