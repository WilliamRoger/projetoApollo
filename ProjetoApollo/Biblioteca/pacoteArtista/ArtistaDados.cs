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
            try
            {
                this.AbrirConexao();

                string sql = "UPDATE artista SET ArtistaNome  = @ArtistaNome , Telefone  = @Telefone , Email  = @Email  WHERE ArtistaID  = @ArtistaID";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@ArtistaNome ", SqlDbType.VarChar);
                cmd.Parameters["@ArtistaNome "].Value = artista.Nome;
                cmd.Parameters.Add("@Telefone ", SqlDbType.VarChar);
                cmd.Parameters["@Telefone "].Value = artista.Telefone;
                cmd.Parameters.Add("@Email ", SqlDbType.VarChar);
                cmd.Parameters["@Email "].Value = artista.Email;
                cmd.Parameters.Add("@ArtistaID", SqlDbType.Int);
                cmd.Parameters["@ArtistaID"].Value = artista.ArtistaID;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e alterar " + ex.Message);
            }

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
            List<Artista> lista = new List<Artista>();
            try
            {
                this.AbrirConexao();
                string sql = "SELECT ArtistaID,ArtistaNome,Telefone,Email FROM artista WHERE ArtistaID = ArtistaID";

                if (filtro.ArtistaID > 0)
                {
                    sql += "and ArtistaID = @ArtistaID";
                }
                if (filtro.Nome != null && filtro.Nome.Equals("") == false)
                {
                    sql += "and ArtistaNome LIKE @ArtistaNome";
                }
                if (filtro.Telefone != null && filtro.Telefone.Equals("") == false)
                {
                    sql += "and Telefone LIKE @Telefone";
                }
                if (filtro.Email != null && filtro.Email.Equals("") == false)
                {
                    sql += "and Email LIKE @Email";
                }

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (filtro.ArtistaID > 0)
                {
                    cmd.Parameters.Add("@ArtistaID", SqlDbType.Int);
                    cmd.Parameters["@ArtistaID"].Value = filtro.ArtistaID;
                }
                if (filtro.Nome != null && filtro.Nome.Equals("") == false)
                {
                    cmd.Parameters.Add("@ArtistaNome", SqlDbType.VarChar);
                    cmd.Parameters["@ArtistaNome"].Value = "%" + filtro.Nome + "%";
                }
                if (filtro.Telefone != null && filtro.Telefone.Equals("") == false)
                {
                    cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                    cmd.Parameters["@Telefone"].Value = "%" + filtro.Telefone + "%";
                }
                if (filtro.Email != null && filtro.Email.Equals("") == false)
                {
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                    cmd.Parameters["@Email"].Value = "%" + filtro.Email + "%";
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Artista artista = new Artista();
                    artista.ArtistaID = DbReader.GetInt32(DbReader.GetOrdinal("ArtistaID"));
                    artista.Nome = DbReader.GetString(DbReader.GetOrdinal("ArtistaNome"));
                    artista.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    artista.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));
                    lista.Add(artista);
                }
                DbReader.Close();
                cmd.Dispose();
                this.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e listar" + ex.Message);
            }
            return lista;

        }
    }
}
