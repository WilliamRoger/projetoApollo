using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;
using Biblioteca.pacoteSala;
using Biblioteca.pacoteHorario;
using Biblioteca.pacoteLocacao;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.pacoteSalaHorario
{
    public class SalaHorarioDados : ConexaoSQLServer, InterfaceSalaHorario
    {
        public void AlterarSalaHorario(SalaHorario salaHorario)
        {
            try
            {
                this.AbrirConexao();
                string sql = "update SalaHorario set DataSalaHorario = @Data,Valor = @Valor,SalaID = @Sala,HorarioID = @Horario,LocacaoID = @Locacao where SalaHorarioID = @Codigo";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Data", SqlDbType.Date);
                cmd.Parameters["@Data"].Value = salaHorario.Data;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = salaHorario.Valor;

                cmd.Parameters.Add("@Sala", SqlDbType.Int);
                cmd.Parameters["@Sala"].Value = salaHorario.Sala.SalaID;

                cmd.Parameters.Add("@Horario", SqlDbType.Int);
                cmd.Parameters["@Horario"].Value = salaHorario.Horario.HorarioID;

                cmd.Parameters.Add("@Locacao", SqlDbType.Int);
                cmd.Parameters["@Locacao"].Value = salaHorario.Locacao.LocacaoID;

                cmd.Parameters.Add("@Codigo", SqlDbType.Int);
                cmd.Parameters["@Codigo"].Value = salaHorario.Codigo;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e alterar - " + ex.Message);
            }
        }

        public void DeletarSalaHorario(SalaHorario salaHorario)
        {
            try
            {
                this.AbrirConexao();
                string sql = "delete from SalaHorario where SalaHorarioID = @Codigo";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Codigo", SqlDbType.Int);
                cmd.Parameters["@Codigo"].Value = salaHorario.Codigo;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e deletar - " + ex.Message); 
            }
        }

        public void InserirSalaHorario(SalaHorario salaHorario)
        {
            try
            {
                this.AbrirConexao();
                string sql = "insert into SalaHorario (DataSalaHorario,Valor,SalaID,HorarioID,LocacaoID) ";
                sql += "values (@Data,@Valor,@Sala,@Horario,@Locacao)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Data", SqlDbType.Date);
                cmd.Parameters["@Data"].Value = salaHorario.Data;

                cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                cmd.Parameters["@Valor"].Value = salaHorario.Valor;

                cmd.Parameters.Add("@Sala", SqlDbType.Int);
                cmd.Parameters["@Sala"].Value = salaHorario.Sala.SalaID;

                cmd.Parameters.Add("@Horario", SqlDbType.Int);
                cmd.Parameters["@Horario"].Value = salaHorario.Horario.HorarioID;

                cmd.Parameters.Add("@Locacao", SqlDbType.Int);
                cmd.Parameters["@Locacao"].Value = salaHorario.Locacao.LocacaoID;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir - " + ex.Message);
            }
        }

        public List<SalaHorario> ListarSalaHorario(SalaHorario filtro)
        {
            List<SalaHorario> lista = new List<SalaHorario>();

            try
            {
                this.AbrirConexao();
                string sql = "select SalaHorarioID,DataSalaHorario,Valor,SalaID,HorarioID,LocacaoID from SalaHorario where SalaHorarioID = SalaHorarioID";

                if (filtro.Codigo > 0)
                {
                    sql += "and SalaHorarioID = @Codigo";
                }
                if (filtro.Data != null && filtro.Data.Equals("") == false)
                {
                    sql += "and DataSalaHorario = @Data";
                }
                if (filtro.Valor > 0)
                {
                    sql += "and Valor = @Valor";
                }
                if (filtro.Sala.SalaID > 0)
                {
                    sql += "and SalaID = @Sala";
                }
                if (filtro.Horario.HorarioID > 0)
                {
                    sql += "and HorarioID = @Horario";
                }
                if (filtro.Locacao.LocacaoID > 0)
                {
                    sql += "and LocacaoID = @Locacao";
                }

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (filtro.Codigo > 0)
                {
                    cmd.Parameters.Add("@Codigo", SqlDbType.Int);
                    cmd.Parameters["@Codigo"].Value = filtro.Codigo;
                }
                if (filtro.Data != null && filtro.Data.Equals("") == false)
                {
                    cmd.Parameters.Add("@Data", SqlDbType.VarChar);
                    cmd.Parameters["@Data"].Value = filtro.Data;
                }
                if (filtro.Valor > 0)
                {
                    cmd.Parameters.Add("@Valor", SqlDbType.Decimal);
                    cmd.Parameters["@Valor"].Value = filtro.Valor;
                }
                if (filtro.Sala.SalaID > 0)
                {
                    cmd.Parameters.Add("@Sala", SqlDbType.Int);
                    cmd.Parameters["@Sala"].Value = filtro.Sala.SalaID;
                }
                if (filtro.Horario.HorarioID > 0)
                {
                    cmd.Parameters.Add("@Horario", SqlDbType.Int);
                    cmd.Parameters["@Horario"].Value = filtro.Horario.HorarioID;
                }
                if (filtro.Locacao.LocacaoID > 0)
                {
                    cmd.Parameters.Add("@Locacao", SqlDbType.Int);
                    cmd.Parameters["@Locacao"].Value = filtro.Locacao.LocacaoID;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Sala sala = new Sala();
                    Horario horario = new Horario();
                    Locacao locacao = new Locacao();
                    SalaHorario salaHorario = new SalaHorario();
                    salaHorario.Codigo = DbReader.GetInt32(DbReader.GetOrdinal("SalaHorarioID"));
                    salaHorario.Data = DbReader.GetString(DbReader.GetOrdinal("DataSalaHorario"));
                    salaHorario.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));
                    sala.SalaID = DbReader.GetInt32(DbReader.GetOrdinal("SalaID"));
                    horario.HorarioID = DbReader.GetInt32(DbReader.GetOrdinal("HorarioID"));
                    locacao.LocacaoID = DbReader.GetInt32(DbReader.GetOrdinal("LocacaoID"));
                    salaHorario.Sala = sala;
                    salaHorario.Horario = horario;
                    salaHorario.Locacao = locacao;
                    lista.Add(salaHorario);
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
