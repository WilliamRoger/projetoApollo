using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtistaLocacao
{
    public class ArtistaLocacaoNegocio: InterfaceArtistaLocacao
    {
        ArtistaLocacaoDados dados = new ArtistaLocacaoDados();

        public void InserirArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            if (artistaLocacao == null)
                throw new Exception("Informa a instancia");
            if (artistaLocacao.ArtistaID.ArtistaID < 0)
                throw new Exception("Informa o id do Artista");
            if (artistaLocacao.LocacaoID.LocacaoID < 0)
                throw new Exception("Informa o id da Locacao");
            if (artistaLocacao.Quantidade < 0)
                throw new Exception("Informa a Quantidade");
            if (artistaLocacao.Valor < 0)
                throw new Exception("Informa o Valor");

            dados.InserirArtistaLocacao(artistaLocacao);
        }

        public void DeletarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            if (artistaLocacao == null)
                throw new Exception("Informa a instancia");
            if (artistaLocacao.ArtistaID.ArtistaID < 0)
                throw new Exception("Informa o id do Artista");

            dados.DeletarArtistaLocacao(artistaLocacao);
        }

        public void AlterarArtistaLocacao(ArtistaLocacao artistaLocacao)
        {
            if (artistaLocacao == null)
                throw new Exception("Informa a instancia");
            if (artistaLocacao.ArtistaID.ArtistaID < 0)
                throw new Exception("Informa o id do Artista");
            if (artistaLocacao.LocacaoID.LocacaoID < 0)
                throw new Exception("Informa o id da Locacao");
            if (artistaLocacao.Quantidade < 0)
                throw new Exception("Informa a Quantidade");
            if (artistaLocacao.Valor < 0)
                throw new Exception("Informa o Valor");

            dados.AlterarArtistaLocacao(artistaLocacao);
        }

        public List<ArtistaLocacao> ListarArtistaLocacao(ArtistaLocacao filtro)
        {
            List<ArtistaLocacao> retorno = new List<ArtistaLocacao>();

            List<ArtistaLocacao> lista = dados.ListarArtistaLocacao(filtro);

            foreach (ArtistaLocacao artistaLocacao in lista)
            {
                ArtistaLocacao novo = new ArtistaLocacao()
                {
                    ArtistaID = artistaLocacao.ArtistaID,
                    LocacaoID = artistaLocacao.LocacaoID,
                    Quantidade = artistaLocacao.Quantidade,
                    Valor = artistaLocacao.Valor
                };
                retorno.Add(novo);
            }
            return retorno;
        }
    }
}
