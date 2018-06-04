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
using Biblioteca.pacoteHorario;
using Biblioteca.pacoteInstrumento;
using Biblioteca.pacoteTipo;
using Biblioteca.pacoteLocacao;

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

        [OperationContract]
        void InserirHorario(Horario horario);

        [OperationContract]
        void DeletarHorario(Horario horario);

        [OperationContract]
        void AlterarHorario(Horario horario);

        [OperationContract]
        List<Horario> ListarHorario(Horario horario);

        [OperationContract]
        void InserirInstrumento(Instrumento instrumento);

        [OperationContract]
        void DeletarInstrumento(Instrumento instrumento);

        [OperationContract]
        void AlterarInstrumento(Instrumento instrumento);

        [OperationContract]
        List<Instrumento> ListarInstrumento(Instrumento filtro);

        [OperationContract]
        void InserirTipo(Tipo tipo);

        [OperationContract]
        void DeletarTipo(Tipo tipo);

        [OperationContract]
        void AlterarTipo(Tipo tipo);

        [OperationContract]
        List<Tipo> ListarTipo(Tipo filtro);

        [OperationContract]
        void InserirLocacao(Locacao locacao);

        [OperationContract]
        void CancelarLocacao(Locacao locacao);

        [OperationContract]
        void AlterarLocacao(Locacao locacao);

        [OperationContract]
        List<Locacao> ListarLocacao(Locacao filtro);
    }
}
