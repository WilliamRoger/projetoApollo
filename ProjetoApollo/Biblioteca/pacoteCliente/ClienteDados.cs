using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    public class ClienteDados: ConexaoSQLServer, InterfaceCliente
    {   //Inserir Cliente
        public void InserirCliente(Cliente cliente)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL = "INSERT INTO Cliente(ClienteNome, Telefone, Email)";
                inserirSQL += "VALUES (@ClienteNome, @Telefone, @Email)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@ClienteNome", SqlDbType.VarChar);
                execSQL.Parameters["@ClienteNome"].Value = cliente.ClienteNome;

                execSQL.Parameters.Add("@Telefone", SqlDbType.VarChar);
                execSQL.Parameters["@Telefone"].Value = cliente.Telefone;

                execSQL.Parameters.Add("@Email", SqlDbType.VarChar);
                execSQL.Parameters["@Email"].Value = cliente.Email;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Cliente!" + exception.Message);
            }
        }

        //Deletar Cliente
        public void DeletarCliente(Cliente cliente)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string deletarSQL = "DELETE FROM Cliente WHERE ClienteID = @ClienteID";
                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
                execSQL.Parameters["@ClienteID"].Value = cliente.ClienteID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {

                throw new Exception("Erro de conexão impossível deletar Cliente!" + exception.Message);
            }
        }

        //Alterar Cliente
        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Cliente SET ";
                alterarSQL += " ClienteNome = @ClienteNome, ";
                alterarSQL += " Telefone = @Telefone, ";
                alterarSQL += " Email = @Email ";
                alterarSQL += " WHERE ClienteID = @ClienteIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@ClienteNome", SqlDbType.VarChar);
                execSQL.Parameters["@ClienteNome"].Value = cliente.ClienteNome;

                execSQL.Parameters.Add("@Telefone", SqlDbType.VarChar);
                execSQL.Parameters["@Telefone"].Value = cliente.Telefone;

                execSQL.Parameters.Add("@Email", SqlDbType.VarChar);
                execSQL.Parameters["@Email"].Value = cliente.Email;

                execSQL.Parameters.Add("@ClienteIDParam", SqlDbType.Int);
                execSQL.Parameters["@ClienteIDParam"].Value = cliente.ClienteID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Cliente!" + exception.Message);
            }
        }

        //Listar Cliente
        public List<Cliente> ListarCliente(Cliente filtro)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT ClienteID, ClienteNome, Telefone, Email FROM Cliente WHERE ClienteID = ClienteID";

                if (filtro.ClienteID > 0)
                {
                    listarSQL += " AND ClienteID = @ClienteID";
                }
                if (filtro.ClienteNome != null && filtro.ClienteNome.Trim().Equals("") == false)
                {
                    listarSQL += " AND ClienteNome LIKE @ClienteNome";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.ClienteID > 0)
                {
                    execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
                    execSQL.Parameters["@ClienteID"].Value = filtro.ClienteID;
                }
                if (filtro.ClienteNome != null && filtro.ClienteNome.Trim().Equals("") == false)
                {
                    execSQL.Parameters.Add("@ClienteNome", SqlDbType.VarChar);
                    execSQL.Parameters["@ClienteNome"].Value = "%" + filtro.ClienteNome + "%";
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();
                    //Acessando os valores das colunas do resultado
                    cliente.ClienteID = DbReader.GetInt32(DbReader.GetOrdinal("ClienteID"));
                    cliente.ClienteNome = DbReader.GetString(DbReader.GetOrdinal("ClienteNome"));
                    cliente.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    cliente.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));

                    retorno.Add(cliente);
                }

                //Fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                execSQL.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível listar Clientes!" + exception.Message);
            }
            return retorno;
        }
    }
}
