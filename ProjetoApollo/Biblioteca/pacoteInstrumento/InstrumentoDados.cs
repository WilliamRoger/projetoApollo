using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;
using Biblioteca.pacoteTipo;

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

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = instrumento.Valor;

                execSQL.Parameters.Add("@TipoID", SqlDbType.Int);
                execSQL.Parameters["@TipoID"].Value = instrumento.TipoID.TipoID;

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
                alterarSQL += " InstrumentoNome = @InstrumentoNome, ";
                alterarSQL += " Valor = @Valor, ";
                alterarSQL += " TipoID = @TipoID ";
                alterarSQL += " WHERE InstrumentoID = @InstrumentoID";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@InstrumentoNome", SqlDbType.VarChar);
                execSQL.Parameters["@InstrumentoNome"].Value = instrumento.Nome;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = instrumento.Valor;

                execSQL.Parameters.Add("@TipoID", SqlDbType.Int);
                execSQL.Parameters["@TipoID"].Value = instrumento.TipoID.TipoID;

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
                throw new Exception("Erro de conexão impossível alterar Instrumento!" + exception.Message);
            }
        }

        //Listar Instrumento
        public List<Instrumento> ListarInstrumento(Instrumento filtro)
        {
            List<Instrumento> lista = new List<Instrumento>();
            
            try
            {
                this.AbrirConexao();
                string sql = "SELECT InstrumentoID,InstrumentoNome,Valor,TipoID FROM Instrumento WHERE InstrumentoID = InstrumentoID";
                if (filtro.InstrumentoID > 0)
                {
                    sql += "and InstrumentoID = @InstrumentoID";
                }
                if (filtro.Nome != null && filtro.Nome.Equals("") == false)
                {
                    sql += "and InstrumentoNome LIKE @InstrumentoNome";
                }
                /*if (filtro.Valor > 0)
                {
                    sql += "and Valor = @Valor";
                }
                if (filtro.TipoID.TipoID > 0)
                {
                    sql += "and TipoID = @TipoID";
                }*/

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                
                if (filtro.InstrumentoID > 0)
                {
                    cmd.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                    cmd.Parameters["@InstrumentoID"].Value = filtro.InstrumentoID;
                }
                if (filtro.Nome != null && filtro.Nome.Equals("") == false)
                {
                    cmd.Parameters.Add("@InstrumentoNome", SqlDbType.VarChar);
                    cmd.Parameters["@InstrumentoNome"].Value = "%" + filtro.Nome + "%";
                }
                /*if (filtro.Valor > 0)
                {
                    cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                    cmd.Parameters["@Valor"].Value = filtro.Valor;
                }
                if (filtro.TipoID.TipoID > 0)
                {
                    cmd.Parameters.Add("@TipoID", SqlDbType.Int);
                    cmd.Parameters["@TipoID"].Value = filtro.TipoID.TipoID;
                }*/

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Instrumento instr = new Instrumento();
                    Tipo tipo = new Tipo();
                    instr.InstrumentoID = DbReader.GetInt32(DbReader.GetOrdinal("InstrumentoID"));
                    instr.Nome = DbReader.GetString(DbReader.GetOrdinal("InstrumentoNome"));
                    instr.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    tipo.TipoID = DbReader.GetInt32(DbReader.GetOrdinal("TipoID"));
                    instr.TipoID = tipo;
                    lista.Add(instr);
                }

                DbReader.Close();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao conectar e listar " + ex.Message);
            }
            return lista;
        }

    }
}