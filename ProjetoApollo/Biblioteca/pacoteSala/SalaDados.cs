using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSala
{
    class SalaDados : ConexaoSQLServer, InterfaceSala
    {
        public void InserirSala(Sala sala)
        {
            try
            {   
                //Abrir a conexao.
                this.AbrirConexao();
                //Instrucao do banco para substituir valores.
                string inserirSQL = "INSERT INTO Sala(SalaNome, Descricao, Valor) ";
                inserirSQL += "VALUES(@SalaNome, @Descricao, @Valor)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@SalaNome", SqlDbType.VarChar);
                execSQL.Parameters["@SalaNome"].Value = sala.SalaNome;

                execSQL.Parameters.Add("@Descricao", SqlDbType.VarChar);
                execSQL.Parameters["@Descricao"].Value = sala.Descricao;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = sala.Valor;

                //Executar Instrucao.
                execSQL.ExecuteNonQuery();
                //Liberar memoria.
                execSQL.Dispose();
                //Fechar conexao.
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Cliente!" + exception.Message);
            }

            
        }

        public void DeletarSala(Sala sala)
        {
            try
            {
                //Abrir a conexao.
                this.AbrirConexao();
                //Instrucao do banco para substituir valores.
                string deletarSQL = "DELETE FROM Sala WHERE SalaID = @SalaID";
                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@SalaID", SqlDbType.Int);
                execSQL.Parameters["@SalaID"].Value = sala.SalaID;

                //Executar Instrucao.
                execSQL.ExecuteNonQuery();
                //Liberar memoria.
                execSQL.Dispose();
                //Fechar conexao.
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível deletar Cliente!" + exception.Message);
            }
        }

        public void AlterarSala(Sala sala)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Sala SET ";
                alterarSQL += " SalaNome = @SalaNome, ";
                alterarSQL += " Descricao = @Descricao, ";
                alterarSQL += " Valor = @Valor ";
                alterarSQL += " WHERE SalaID = @SalaIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@SalaNome", SqlDbType.VarChar);
                execSQL.Parameters["@SalaNome"].Value = sala.SalaNome;

                execSQL.Parameters.Add("@Descricao", SqlDbType.VarChar);
                execSQL.Parameters["@Descricao"].Value = sala.Descricao;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = sala.Valor;

                execSQL.Parameters.Add("@SalaIDParam", SqlDbType.Int);
                execSQL.Parameters["@SalaIDParam"].Value = sala.SalaID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Sala!" + exception.Message);
            }
        }

        public List<Sala> ListarSala(Sala filtro)
        {
            List<Sala> retorno = new List<Sala>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT SalaID, SalaNome, Descricao, Valor FROM Sala WHERE SalaID = SalaID";

                if (filtro.SalaID > 0)
                {
                    listarSQL += " AND SalaID = @SalaID";
                }

                if (filtro.SalaNome != null && filtro.SalaNome.Trim().Equals("") == false)
                {
                    listarSQL += " AND SalaNome LIKE @SalaNome";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.SalaID > 0)
                {
                    execSQL.Parameters.Add("@SalaID", SqlDbType.Int);
                    execSQL.Parameters["@SalaID"].Value = filtro.SalaID;
                }

                if (filtro.SalaNome != null && filtro.SalaNome.Trim().Equals("") == false)
                {
                    execSQL.Parameters.Add("@SalaNome", SqlDbType.VarChar);
                    execSQL.Parameters["@SalaNome"].Value = "%" + filtro.SalaNome + "%";
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Sala sala = new Sala();
                    //Acessando os valores das colunas do resultado
                    sala.SalaID = DbReader.GetInt32(DbReader.GetOrdinal("SalaID"));
                    sala.SalaNome = DbReader.GetString(DbReader.GetOrdinal("SalaNome"));
                    sala.Descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    sala.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));

                    retorno.Add(sala);
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
                throw new Exception("Erro de conexão impossível listar Salas!" + exception.Message);
            }
            return retorno;
        }
    }
}
