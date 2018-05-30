using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteTipo
{
    public class TipoDados: ConexaoSQLServer, InterfaceTipo
    {
        public void InserirTipo(Tipo tipo)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL = "INSERT INTO Tipo(TipoNome) ";
                inserirSQL += "VALUES (@TipoNome)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@TipoNome", SqlDbType.VarChar);
                execSQL.Parameters["@TipoNome"].Value = tipo.Nome;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Tipo! " + exception.Message);
            }
        }

        public void DeletarTipo(Tipo tipo)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string deletarSQL = "DELETE FROM Tipo WHERE TipoID = @TipoID";

                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@TipoID", SqlDbType.Int);
                execSQL.Parameters["@TipoID"].Value = tipo.TipoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível deletar Tipo! " + exception.Message);
            }
        }

        public void AlterarTipo(Tipo tipo)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Tipo SET TipoNome = @TipoNome WHERE TipoID = @TipoIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@TipoNome", SqlDbType.VarChar);
                execSQL.Parameters["@TipoNome"].Value = tipo.Nome;

                execSQL.Parameters.Add("@TipoIDParam", SqlDbType.Int);
                execSQL.Parameters["@TipoIDParam"].Value = tipo.TipoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Tipo! " + exception.Message);
            }
        }

        public List<Tipo> ListarTipo(Tipo filtro)
        {
            List<Tipo> retorno = new List<Tipo>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT TipoID, TipoNome FROM Tipo WHERE TipoID = TipoID";

                if (filtro.TipoID > 0)
                {
                    listarSQL += " AND TipoID = @TipoID";
                }

                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    listarSQL += " AND TipoNome LIKE @TipoNome";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.TipoID > 0)
                {
                    execSQL.Parameters.Add("@TipoID", SqlDbType.Int);
                    execSQL.Parameters["@TipoID"].Value = filtro.TipoID;
                }

                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    execSQL.Parameters.Add("@TipoNome", SqlDbType.VarChar);
                    execSQL.Parameters["@TipoNome"].Value = filtro.Nome;
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Tipo tipo = new Tipo();
                    //Acessando os valores das colunas do resultado
                    tipo.TipoID = DbReader.GetInt32(DbReader.GetOrdinal("TipoID"));
                    tipo.Nome = DbReader.GetString(DbReader.GetOrdinal("TipoNome"));

                    retorno.Add(tipo);
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
                throw new Exception("Erro de conexão impossível listar Tipos! " + exception.Message);
            }
            return retorno;
        }
    }
}
