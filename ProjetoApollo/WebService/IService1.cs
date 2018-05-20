using Biblioteca.pacoteCliente;
using Biblioteca.pacoteArtista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.pacoteSala;

namespace WebService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InserirCliente(Cliente cliente);

        [OperationContract]
        void DeletarCliente(Cliente cliente);

        [OperationContract]
        void AlterarCliente(Cliente cliente);

        [OperationContract]
        List<Cliente> ListarCliente(Cliente cliente);

        [OperationContract]
        void InserirArtista(Artista artista);

        [OperationContract]
        void DeletarArtista(Artista artista);

        [OperationContract]
        void AlterarArtista(Artista artista);

        [OperationContract]
        List<Artista> ListarArtista(Artista filtro);

        [OperationContract]
        void InserirSala (Sala sala);

        [OperationContract]
        void DeletarSala(Sala sala);

        [OperationContract]
        void AlterarSala(Sala sala);

        [OperationContract]
        List<Sala> ListarSala(Sala filtro);
    }
}
