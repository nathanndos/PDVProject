﻿using System;
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
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConexao) ) {
                try{
                    const string sqlQuery = "INSERT INTO tbl_cliente(Id_cliente, Nome, Email) VALUES(@Id_cliente, @Nome, @Email)";

                    SqlCommand cmd = new SqlCommand(sqlQuery,conec);//passa a query e passa a instancia da conexao 
                    cmd.Parameters.AddWithValue("@Id_cliente", cliente.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);//nome do parametro e valor pra ser adicionado
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
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = @"UPDATE tbl_cliente " +
                                            "SET Nome = @Nome, Email = @Email "+
                                            "WHERE Id_cliente = @Id_cliente";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Id_cliente", cliente.Codigo);
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
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            bool logic = false;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = "SELECT COUNT(codigo) FROM tbl_cliente WHERE codigo = @codigo";
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
            string textConexao = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
            int last;
            using (SqlConnection conec = new SqlConnection(textConexao)){
                try{
                    const string sqlQuery = "SELECT MAX(codigo) FROM cliente";
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
                    const string sqlQuery = "SELECT codigo, nome, sobrenome, email, cpf from cliente";
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
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=db_pdvproject;Integrated Security=True";
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
    }
}


