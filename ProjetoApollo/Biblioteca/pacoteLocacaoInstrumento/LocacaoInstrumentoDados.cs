using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;
using Biblioteca.pacoteInstrumento;
using Biblioteca.pacoteLocacao;

namespace Biblioteca.pacoteLocacaoInstrumento
{
    public class LocacaoInstrumentoDados : ConexaoSQLServer, InterfaceLocacaoInstrumento
    {
        public void AlterarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            try
            {
                this.AbrirConexao();
                string sql = "UPDATE LocacaoInstrumento SET LocacaoID = @LocacaoID, InstrumentoID = @InstrumentoID, Valor = @Valor, Quantidade = @Quantidade WHERE LocacaoID = @LocacaoIdParam AND InstrumentoID = @InstrumentoIdParam";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@LocacaoID", SqlDbType.Int);
                cmd.Parameters["@LocacaoID"].Value = locaInstrumento.Locacao.LocacaoID;

                cmd.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                cmd.Parameters["@InstrumentoID"].Value = locaInstrumento.Instrumento.InstrumentoID;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = locaInstrumento.Valor;

                cmd.Parameters.Add("@Quantidade", SqlDbType.Int);
                cmd.Parameters["@Quantidade"].Value = locaInstrumento.Quantidade;

                cmd.Parameters.Add("@LocacaoIdParam", SqlDbType.Int);
                cmd.Parameters["@LocacaoIdParam"].Value = locaInstrumento.Locacao.LocacaoID;

                cmd.Parameters.Add("@InstrumentoIdParam", SqlDbType.Int);
                cmd.Parameters["@InstrumentoIdParam"].Value = locaInstrumento.Instrumento.InstrumentoID;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e alterar - " + ex.Message);
            }
        }

        public void DeletarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            try
            {
                this.AbrirConexao();
                string sql = "DELETE FROM LocacaoInstrumento WHERE LocacaoID = @LocacaoID AND InstrumentoID = @InstrumentoID";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@LocacaoID", SqlDbType.Int);
                cmd.Parameters["@LocacaoID"].Value = locaInstrumento.Locacao.LocacaoID;

                cmd.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                cmd.Parameters["@InstrumentoID"].Value = locaInstrumento.Instrumento.InstrumentoID;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e deletar - " + ex.Message);
            }
        }

        public void InserirLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            try
            {
                this.AbrirConexao();
                string sql = "INSERT INTO LocacaoInstrumento (LocacaoID,InstrumentoID,Valor,Quantidade) ";
                sql += "VALUES(@LocacaoID,@InstrumentoID,@Valor,@Quantidade)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@LocacaoID",SqlDbType.Int);
                cmd.Parameters["@LocacaoID"].Value = locaInstrumento.Locacao.LocacaoID;

                cmd.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                cmd.Parameters["@InstrumentoID"].Value = locaInstrumento.Instrumento.InstrumentoID;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = locaInstrumento.Valor;

                cmd.Parameters.Add("@Quantidade", SqlDbType.Int);
                cmd.Parameters["@Quantidade"].Value = locaInstrumento.Quantidade;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e cadastrar - " + ex.Message);
            }
        }

        public List<LocacaoInstrumento> ListarLocacaoInstrumento(LocacaoInstrumento filtro)
        {
            List<LocacaoInstrumento> lista = new List<LocacaoInstrumento>();
            try
            {
                this.AbrirConexao();
                string sql = "SELECT LocacaoID,InstrumentoID,Valor,Quantidade FROM LocacaoInstrumento WHERE LocacaoID = LocacaoID AND InstrumentoID = InstrumentoID";
                if (filtro.Locacao.LocacaoID > 0)
                {
                    sql += "AND LocacaoID = @LocacaoID";
                }
                if (filtro.Instrumento.InstrumentoID > 0)
                {
                    sql += "AND InstrumentoID = @InstrumentoID";
                }
                if (filtro.Valor > 0)
                {
                    sql += "AND Valor = @Valor";
                }
                if (filtro.Quantidade > 0)
                {
                    sql += "AND Quantidade = @Quantidade";
                }

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (filtro.Locacao.LocacaoID > 0)
                {
                    cmd.Parameters.Add("@LocacaoID", SqlDbType.Int);
                    cmd.Parameters["@LocacaoID"].Value = filtro.Locacao.LocacaoID;
                }
                if (filtro.Instrumento.InstrumentoID > 0)
                {
                    cmd.Parameters.Add("@InstrumentoID", SqlDbType.Int);
                    cmd.Parameters["@InstrumentoID"].Value = filtro.Instrumento.InstrumentoID;
                }
                if (filtro.Valor > 0)
                {
                    cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                    cmd.Parameters["@Valor"].Value = filtro.Valor;
                }
                if (filtro.Quantidade > 0)
                {
                    cmd.Parameters.Add("@Quantidade", SqlDbType.Int);
                    cmd.Parameters["@Quantidade"].Value = filtro.Quantidade;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Locacao loca = new Locacao();
                    Instrumento instr = new Instrumento();
                    LocacaoInstrumento locaInstrumento = new LocacaoInstrumento();
                    loca.LocacaoID = DbReader.GetInt32(DbReader.GetOrdinal("LocacaoID"));
                    locaInstrumento.Locacao = loca;
                    instr.InstrumentoID = DbReader.GetInt32(DbReader.GetOrdinal("InstrumentoID"));
                    locaInstrumento.Instrumento = instr;
                    locaInstrumento.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    locaInstrumento.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("Quantidade"));
                    lista.Add(locaInstrumento);
                }
                DbReader.Close();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e listar - " + ex.Message);
            }
            return lista;
        }
    }
}
