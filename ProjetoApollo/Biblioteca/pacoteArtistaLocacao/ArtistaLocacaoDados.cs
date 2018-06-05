using Biblioteca.pacoteConexao;
using Biblioteca.pacoteArtista;
using Biblioteca.pacoteLocacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtistaLocacao
{
    public class ArtistaLocacaoDados: ConexaoSQLServer, InterfaceArtistaLocacao
    {
        public void InserirArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL = "INSERT INTO LocacaoArtista (ArtistaID, LocacaoID, Quantidade, Valor) ";
                inserirSQL += "VALUES (@ArtistaID, @LocacaoID, @Quantidade, @Valor)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@ArtistaID", SqlDbType.Int);
                execSQL.Parameters["@ArtistaID"].Value = artistaLocacao.ArtistaID.ArtistaID;

                execSQL.Parameters.Add("@LocacaoID", SqlDbType.Int);
                execSQL.Parameters["@LocacaoID"].Value = artistaLocacao.LocacaoID.LocacaoID;

                execSQL.Parameters.Add("@Quantidade", SqlDbType.Int);
                execSQL.Parameters["@Quantidade"].Value = artistaLocacao.Quantidade;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = artistaLocacao.Valor;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar ArtistaLocação! " + exception.Message);
            }
        }

        public void DeletarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string deletarSQL = "delete from LocacaoArtista where ArtistaID = @ArtistaID";

                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@ArtistaID", SqlDbType.Int);
                execSQL.Parameters["@ArtistaID"].Value = artistaLocacao.ArtistaID.ArtistaID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível deletar ArtistaLocação! " + exception.Message);
            }
        }

        public void AlterarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE LocacaoArtista SET ";
                alterarSQL += " ArtistaID = @ArtistaID, ";
                alterarSQL += " Quantidade = @Quantidade, ";
                alterarSQL += " Valor = @Valor ";
                alterarSQL += " WHERE LocacaoID = @LocacaoIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@ArtistaID", SqlDbType.Int);
                execSQL.Parameters["@ArtistaID"].Value = artistaLocacao.ArtistaID.ArtistaID;

                execSQL.Parameters.Add("@Quantidade", SqlDbType.Int);
                execSQL.Parameters["@Quantidade"].Value = artistaLocacao.Quantidade;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = artistaLocacao.Valor;

                execSQL.Parameters.Add("@LocacaoIDParam", SqlDbType.Int);
                execSQL.Parameters["@LocacaoIDParam"].Value = artistaLocacao.LocacaoID.LocacaoID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar ArtistaLocação! " + exception.Message);
            }
        }

        public List<ArtistaLocacao> ListarArtistaLocacao(ArtistaLocacao filtro)
        {
            List<ArtistaLocacao> retorno = new List<ArtistaLocacao>();
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT LocacaoID, ArtistaID, Quantidade, Valor FROM LocacaoArtista ";
                listarSQL += "WHERE LocacaoID = LocacaoID";

                if (filtro.LocacaoID.LocacaoID > 0)
                {
                    listarSQL += " AND LocacaoID = @LocacaoID";
                }

                if (filtro.ArtistaID.ArtistaID > 0)
                {
                    listarSQL += " AND ArtistaID = @ArtistaID";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.LocacaoID.LocacaoID > 0)
                {
                    execSQL.Parameters.Add("@LocacaoID", SqlDbType.Int);
                    execSQL.Parameters["@LocacaoID"].Value = filtro.LocacaoID.LocacaoID;
                }

                if (filtro.ArtistaID.ArtistaID > 0)
                {
                    execSQL.Parameters.Add("@ArtistaID", SqlDbType.Int);
                    execSQL.Parameters["@ArtistaID"].Value = filtro.ArtistaID.ArtistaID;
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Artista artista = new Artista();
                    Locacao locacao = new Locacao();
                    ArtistaLocacao artistaLocacao = new ArtistaLocacao();
                    //Acessando os valores das colunas do resultado
                    locacao.LocacaoID = DbReader.GetInt32(DbReader.GetOrdinal("LocacaoID"));
                    artista.ArtistaID = DbReader.GetInt32(DbReader.GetOrdinal("ArtistaID"));
                    artistaLocacao.LocacaoID = locacao;
                    artistaLocacao.ArtistaID = artista; 
                    artistaLocacao.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("Quantidade"));
                    artistaLocacao.Valor = DbReader.GetDecimal(DbReader.GetOrdinal("Valor"));

                    retorno.Add(artistaLocacao);
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
                throw new Exception("Erro de conexão impossível listar ArtistaLocação! " + exception.Message);
            }
            return retorno;
        }
    }
}
