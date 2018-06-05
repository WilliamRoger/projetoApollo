using Biblioteca.pacoteConexao;
using Biblioteca.pacoteCliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacao
{
    public class LocacaoDados: ConexaoSQLServer, InterfaceLocacao
    {   //Inserir Locação
        public void InserirLocacao(Locacao locacao)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL;
                if (locacao.DataPagamento != null && locacao.DataPagamento.Equals("") == false)
                {
                    inserirSQL = "INSERT INTO Locacao(ClienteID, DataVencimento, DataPagamento) ";
                    inserirSQL += "VALUES (@ClienteID, @DataVencimento, @DataPagamento)";
                } else
                {
                    inserirSQL = "INSERT INTO Locacao(ClienteID, DataVencimento) ";
                    inserirSQL += "VALUES (@ClienteID, @DataVencimento)";
                }
                    

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
                execSQL.Parameters["@ClienteID"].Value = locacao.ClienteID.ClienteID;

                execSQL.Parameters.Add("@DataVencimento", SqlDbType.Date);
                execSQL.Parameters["@DataVencimento"].Value = locacao.DataVencimento;

                if (locacao.DataPagamento != null && locacao.DataPagamento.Equals("") == false)
                {
                    execSQL.Parameters.Add("@DataPagamento", SqlDbType.VarChar);
                    execSQL.Parameters["@DataPagamento"].Value = locacao.DataPagamento;
                }

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Locação! " + exception.Message);
            }
        }

        //Cancelar Locação
        public void CancelarLocacao(Locacao locacao)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string cancelarSQL = "UPDATE Locacao SET DataCancelamento = @DataCancelamento WHERE LocacaoID = @LocacaoIDParam";

                SqlCommand execSQL = new SqlCommand(cancelarSQL, this.sqlConn);

                execSQL.Parameters.Add("@DataCancelamento", SqlDbType.Date);
                execSQL.Parameters["@DataCancelamento"].Value = locacao.DataCancelamento;

                execSQL.Parameters.Add("@LocacaoIDParam", SqlDbType.Int);
                execSQL.Parameters["@LocacaoIDParam"].Value = locacao.LocacaoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cancelar Locação! " + exception.Message);
            }
        }

        //Alterar Locação
        public void AlterarLocacao(Locacao locacao)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Locacao SET ";
                alterarSQL += " DataVencimento = @DataVencimento";
                if (locacao.DataPagamento != null && locacao.DataPagamento.Equals("") == false)
                {
                    alterarSQL += ", DataPagamento = @DataPagamento ";
                }
                alterarSQL += " WHERE LocacaoID = @LocacaoIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@DataVencimento", SqlDbType.Date);
                execSQL.Parameters["@DataVencimento"].Value = locacao.DataVencimento;
                if (locacao.DataPagamento != null && locacao.DataPagamento.Equals("") == false)
                {
                    execSQL.Parameters.Add("@DataPagamento", SqlDbType.Date);
                    execSQL.Parameters["@DataPagamento"].Value = locacao.DataPagamento;
                }

                execSQL.Parameters.Add("@LocacaoIDParam", SqlDbType.Int);
                execSQL.Parameters["@LocacaoIDParam"].Value = locacao.LocacaoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Locação! " + exception.Message);
            }
        }

        //Listar Locação
        public List<Locacao> ListarLocacao(Locacao filtro)
        {
            List<Locacao> retorno = new List<Locacao>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT LocacaoID, ClienteID, DataVencimento, DataPagamento, DataCancelamento FROM Locacao ";
                listarSQL += "WHERE LocacaoID = LocacaoID";

                if (filtro.LocacaoID > 0)
                {
                    listarSQL += " AND LocacaoID = @LocacaoID";
                }

                if (filtro.ClienteID.ClienteID > 0)
                {
                    listarSQL += " AND ClienteID = @ClienteID";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.LocacaoID > 0)
                {
                    execSQL.Parameters.Add("@LocacaoID", SqlDbType.Int);
                    execSQL.Parameters["@LocacaoID"].Value = filtro.LocacaoID;
                }

                if (filtro.ClienteID.ClienteID > 0)
                {
                    execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
                    execSQL.Parameters["@ClienteID"].Value = filtro.ClienteID.ClienteID;
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();
                    Locacao locacao = new Locacao();
                    //Acessando os valores das colunas do resultado
                    locacao.LocacaoID = DbReader.GetInt32(DbReader.GetOrdinal("LocacaoID"));
                    cliente.ClienteID = DbReader.GetInt32(DbReader.GetOrdinal("ClienteID"));
                    locacao.ClienteID = cliente;
                    locacao.DataVencimento = DbReader.GetString(DbReader.GetOrdinal("DataVencimento"));
                    locacao.DataPagamento = DbReader.GetString(DbReader.GetOrdinal("DataPagamento"));
                    locacao.DataCancelamento = DbReader.GetString(DbReader.GetOrdinal("DataCancelamento"));

                    retorno.Add(locacao);
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
                throw new Exception("Erro de conexão impossível listar Locação!" + exception.Message);
            }
            return retorno;
        }
    }
}
