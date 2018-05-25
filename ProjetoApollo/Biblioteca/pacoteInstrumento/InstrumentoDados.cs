using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;

namespace Biblioteca.pacoteInstrumento
{
    public class InstrumentoDados: ConexaoSQLServer, InterfaceInstrumento
    {   
        //Inserir Instrumento
        public void InserirInstrumento(Instrumento instrumento)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL = "INSERT INTO Instrumento(InstrumentoNome, Valor, TipoID)";
                inserirSQL += "VALUES (@InstrumentoNome, @Valor, @TipoID)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@InstrumentoNome", SqlDbType.VarChar);
                execSQL.Parameters["@InstrumentoNome"].Value = instrumento.Nome;

                execSQL.Parameters.Add("@Valor", SqlDbType.VarChar);
                execSQL.Parameters["@Valor"].Value = instrumento.Valor;

                execSQL.Parameters.Add("@TipoID", SqlDbType.VarChar);
                execSQL.Parameters["@TipoID"].Value = instrumento.TipoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Instrumento!" + exception.Message);
            }
        }

        //Deletar Instrumento
        public void DeletarInstrumento(Instrumento instrumento)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string deletarSQL = "DELETE FROM Instrumento WHERE InstrumentoID = @InstrumentoID";
                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                execSQL.Parameters["@InstrumentoID"].Value = instrumento.InstrumentoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível deletar Instrumento!" + exception.Message);
            }
        }

        //Alterar Instrumento
        public void AlterarInstrumento(Instrumento instrumento)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Instrumento SET ";
                alterarSQL += " Nome = @Nome, ";
                alterarSQL += " Valor = @Valor, ";
                alterarSQL += " CodTipo = @CodTipo ";
                alterarSQL += " WHERE InstrumentoID == @InstrumentoIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@Nome", SqlDbType.VarChar);
                execSQL.Parameters["@Nome"].Value = instrumento.Nome;

                execSQL.Parameters.Add("@Valor", SqlDbType.VarChar);
                execSQL.Parameters["@Valor"].Value = instrumento.Valor;

                execSQL.Parameters.Add("@TipoID", SqlDbType.Int);
                execSQL.Parameters["@TipoID"].Value = instrumento.TipoID;

                execSQL.Parameters.Add("@InstrumentoIDParam", SqlDbType.Int);
                execSQL.Parameters["@InstrumentoIDParam"].Value = instrumento.InstrumentoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Instrumento!" + exception.Message);
            }
        }

        //Listar Instrumento
        public List<Instrumento> ListarInstrumento(Instrumento filtro)
        {
            List<Instrumento> retorno = new List<Instrumento>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT InstrumentoID, InstrumentoNome, Valor, TipoID FROM Instrumento WHERE InstrumentoID = InstrumentoID";
                if (filtro.InstrumentoID > 0)
                {
                    listarSQL += " AND InstrumentoID = @InstrumentoID";
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    listarSQL += " AND InstrumentoNome LIKE @InstrumentoNome";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.InstrumentoID > 0)
                {
                    execSQL.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                    execSQL.Parameters["@InstrumentoID"].Value = filtro.InstrumentoID;
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    execSQL.Parameters.Add("@InstrumentoNome", SqlDbType.VarChar);
                    execSQL.Parameters["@InstrumentoNome"].Value = "%" + filtro.Nome + "%";
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Instrumento instrumento = new Instrumento();
                    //Acessando os valores das colunas do resultado
                    instrumento.InstrumentoID = DbReader.GetInt32(DbReader.GetOrdinal("InstrumentoID"));
                    instrumento.Nome = DbReader.GetString(DbReader.GetOrdinal("InstrumentoNome"));
                    //instrumento.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    instrumento.TipoID = DbReader.GetInt32(DbReader.GetOrdinal("TipoID"));

                    retorno.Add(instrumento);
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
                throw new Exception("Erro de conexão impossível listar Instrumentos!" + exception.Message);
            }
            return retorno;
        }
    }
}