using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.pacoteArtista
{
    public class ArtistaDados : ConexaoSQLServer, InterfaceArtista
    {
        public void AlterarArtista(Artista artista)
        {
            throw new NotImplementedException();
        }

        public void DeletarArtista(Artista artista)
        {
            try
            {
                this.AbrirConexao();

                string sql = "DELETE FROM artista WHERE ArtistaID = @ArtistaID";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@ArtistaID", SqlDbType.Int);
                cmd.Parameters["@ArtistaID"].Value = artista.ArtistaID;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e deletar " + ex.Message);
            }
        }

        public void InserirArtista(Artista artista)
        {
            try
            {
                this.AbrirConexao();

                string sql = "INSERT INTO artista (ArtistaNome,Telefone,Email) ";
                sql += "VALUES(@ArtistaNome,@Telefone,@Email)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@ArtistaNome ", SqlDbType.VarChar);
                cmd.Parameters["@ArtistaNome "].Value = artista.Nome;
                cmd.Parameters.Add("@Telefone ", SqlDbType.VarChar);
                cmd.Parameters["@Telefone "].Value = artista.Telefone;
                cmd.Parameters.Add("@Email ", SqlDbType.VarChar);
                cmd.Parameters["@Email "].Value = artista.Email;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e cadastrar " + ex.Message);
            }

        }

        public List<Artista> ListarArtista(Artista filtro)
        {
            throw new NotImplementedException();
        }
    }
}
