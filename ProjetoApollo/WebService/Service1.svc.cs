using Biblioteca.pacoteArtista;
using Biblioteca.pacoteCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void InserirCliente(Cliente cliente)
        {
            new ClienteNegocio().InserirCliente(cliente);
        }

        public void DeletarCliente(Cliente cliente)
        {
            new ClienteNegocio().DeletarCliente(cliente);
        }

        public void AlterarCliente(Cliente cliente)
        {
            new ClienteNegocio().AlterarCliente(cliente);
        }

        public List<Cliente> ListarCliente(Cliente cliente)
        {
            return new ClienteNegocio().ListarCliente(cliente);
        }

        public void InserirArtista(Artista artista)
        {
            new ArtistaNegocio().InserirArtista(artista);
        }

        public void DeletarArtista(Artista artista)
        {
            new ArtistaNegocio().DeletarArtista(artista);
        }

        public void AlterarArtista(Artista artista)
        {
            new ArtistaNegocio().AlterarArtista(artista);
        }

        public List<Artista> ListarArtista(Artista filtro)
        {
            return new ArtistaNegocio().ListarArtista(filtro);
        }
    }
}
