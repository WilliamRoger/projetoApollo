using Biblioteca.pacoteArtista;
using Biblioteca.pacoteCliente;
using Biblioteca.pacoteHorario;
using Biblioteca.pacoteInstrumento;
using Biblioteca.pacoteLocacao;
using Biblioteca.pacoteSala;
using Biblioteca.pacoteTipo;
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

        public void InserirSala(Sala sala)
        {
            new SalaNegocio().InserirSala(sala);
        }

        public void DeletarSala(Sala sala)
        {
            new SalaNegocio().DeletarSala(sala);
        }

        public void AlterarSala(Sala sala)
        {
            new SalaNegocio().AlterarSala(sala);
        }

        public List<Sala> ListarSala(Sala sala)
        {
            return new SalaNegocio().ListarSala(sala);
        }

        public void InserirHorario(Horario horario)
        {
            new HorarioNegocio().InserirHorario(horario);
        }

        public void DeletarHorario(Horario horario)
        {
            new HorarioNegocio().DeletarHorario(horario);
        }

        public void AlterarHorario(Horario horario)
        {
            new HorarioNegocio().AlterarHorario(horario);
        }

        public List<Horario> ListarHorario(Horario horario)
        {
            return new HorarioNegocio().ListarHorario(horario);
        }

        public void InserirInstrumento(Instrumento instrumento)
        {
            new InstrumentoNegocio().InserirInstrumento(instrumento);
            //new InstrumentoDados().InserirInstrumento(instrumento);
        }

        public void DeletarInstrumento(Instrumento instrumento)
        {
            new InstrumentoNegocio().DeletarInstrumento(instrumento);
            //new InstrumentoDados().DeletarInstrumento(instrumento);
        }

        public void AlterarInstrumento(Instrumento instrumento)
        {
            new InstrumentoNegocio().AlterarInstrumento(instrumento);
            //new InstrumentoDados().AlterarInstrumento(instrumento);
        }

        public List<Instrumento> ListarInstrumento(Instrumento filtro)
        {
            return new InstrumentoNegocio().ListarInstrumento(filtro);
            //return new InstrumentoDados().ListarInstrumento(filtro);
        }

        public void InserirTipo(Tipo tipo)
        {
            new TipoNegocio().InserirTipo(tipo);
            //new TipoDados().InserirTipo(tipo);
        }

        public void DeletarTipo(Tipo tipo)
        {
            new TipoNegocio().DeletarTipo(tipo);
            //new TipoDados().DeletarTipo(tipo);
        }

        public void AlterarTipo(Tipo tipo)
        {
            new TipoNegocio().AlterarTipo(tipo);
            //new TipoDados().AlterarTipo(tipo);
        }

        public List<Tipo> ListarTipo(Tipo filtro)
        {
            return new TipoNegocio().ListarTipo(filtro);
            //return new TipoDados().ListarTipo(filtro);
        }

        public void InserirLocacao(Locacao locacao)
        {
            new LocacaoDados().InserirLocacao(locacao);
        }

        public void CancelarLocacao(Locacao locacao)
        {
            new LocacaoDados().CancelarLocacao(locacao);
        }

        public void AlterarLocacao(Locacao locacao)
        {
            new LocacaoDados().AlterarLocacao(locacao);
        }

        public List<Locacao> ListarLocacao(Locacao filtro)
        {
            return new LocacaoDados().ListarLocacao(filtro);
        }
    }
}
