using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtista
{
    public class ArtistaNegocio : InterfaceArtista
    {
        ArtistaDados dados = new ArtistaDados();

        public void AlterarArtista(Artista artista)
        {
            throw new NotImplementedException();
        }

        public void DeletarArtista(Artista artista)
        {
            if (artista == null)
                throw new Exception("Artista não instanciado");
            if (artista.ArtistaID <= 0)
                throw new Exception("id inválido");

            dados.DeletarArtista(artista);
        }

        public void InserirArtista(Artista artista)
        {
            if (artista == null)
                throw new Exception("Artista não instanciado");
            if (artista.Nome.Equals("") == true || artista.Nome == null)
                throw new Exception("Informa o nome do artista");
            if (artista.Telefone == null || artista.Telefone.Equals("") == true)
                throw new Exception("Informar o telefone do artista");
            if (artista.Email == null || artista.Email.Equals("") == true)
                throw new Exception("Informar o email do artista");

            dados.InserirArtista(artista);
        }

        public List<Artista> ListarArtista(Artista filtro)
        {
            throw new NotImplementedException();
        }
    }
}
