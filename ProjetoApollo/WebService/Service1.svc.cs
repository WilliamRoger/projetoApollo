using Biblioteca.pacoteArtista;
using Biblioteca.pacoteCliente;
using Biblioteca.pacoteHorario;
using Biblioteca.pacoteInstrumento;
using Biblioteca.pacoteLocacao;
using Biblioteca.pacoteSala;
using Biblioteca.pacoteTipo;
using Biblioteca.pacoteLocacaoInstrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.pacoteArtistaLocacao;
using Biblioteca.pacoteSalaHorario;

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

        public string RetornaIDCliente(Cliente cliente)
        {
            return new ClienteNegocio().RetornaIDCliente(cliente);
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
        }

        public void DeletarInstrumento(Instrumento instrumento)
        {
            new InstrumentoNegocio().DeletarInstrumento(instrumento);
        }

        public void AlterarInstrumento(Instrumento instrumento)
        {
            new InstrumentoNegocio().AlterarInstrumento(instrumento);
        }

        public List<Instrumento> ListarInstrumento(Instrumento filtro)
        {
            return new InstrumentoNegocio().ListarInstrumento(filtro);
        }

        public void InserirTipo(Tipo tipo)
        {
            new TipoNegocio().InserirTipo(tipo);
        }

        public void DeletarTipo(Tipo tipo)
        {
            new TipoNegocio().DeletarTipo(tipo);
        }

        public void AlterarTipo(Tipo tipo)
        {
            new TipoNegocio().AlterarTipo(tipo);
        }

        public List<Tipo> ListarTipo(Tipo filtro)
        {
            return new TipoNegocio().ListarTipo(filtro);
        }

        public void InserirLocacao(Locacao locacao)
        {
            new LocacaoNegocio().InserirLocacao(locacao);
        }

        public void CancelarLocacao(Locacao locacao)
        {
            new LocacaoNegocio().CancelarLocacao(locacao);
        }

        public void AlterarLocacao(Locacao locacao)
        {
            new LocacaoNegocio().AlterarLocacao(locacao);
        }

        public List<Locacao> ListarLocacao(Locacao filtro)
        {
            return new LocacaoNegocio().ListarLocacao(filtro);
        }

        public void InserirLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            new LocacaoInstrumentoNegocio().InserirLocacaoInstrumento(locaInstrumento);
        }

        public void DeletarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            new LocacaoInstrumentoNegocio().DeletarLocacaoInstrumento(locaInstrumento);
        }

        public void AlterarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            new LocacaoInstrumentoNegocio().AlterarLocacaoInstrumento(locaInstrumento);
        }

        public List<LocacaoInstrumento> ListarLocacaoInstrumento(LocacaoInstrumento filtro)
        {
            return new LocacaoInstrumentoNegocio().ListarLocacaoInstrumento(filtro);
        }

        public void InserirArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            new ArtistaLocacaoNegocio().InserirArtistaLocacao(artistaLocacao);
        }

        public void DeletarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            new ArtistaLocacaoNegocio().DeletarArtistaLocacao(artistaLocacao);
        }

        public void AlterarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            new ArtistaLocacaoNegocio().AlterarArtistaLocacao(artistaLocacao);
        }

        public List<ArtistaLocacao> ListarArtistaLocacao(ArtistaLocacao filtro)
        {
            return new ArtistaLocacaoNegocio().ListarArtistaLocacao(filtro);
        }

        public void InserirSalaHorario(SalaHorario salaHorario)
        {
            new SalaHorarioNegocio().InserirSalaHorario(salaHorario);
        }

        public void DeletarSalaHorario(SalaHorario salaHorario)
        {
            new SalaHorarioNegocio().DeletarSalaHorario(salaHorario);
        }

        public void AlterarSalaHorario(SalaHorario salaHorario)
        {
            new SalaHorarioNegocio().AlterarSalaHorario(salaHorario);
        }

        public List<SalaHorario> ListarSalaHorario(SalaHorario filtro)
        {
            return new SalaHorarioNegocio().ListarSalaHorario(filtro);
        }
    }
}
