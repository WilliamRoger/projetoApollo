using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacao
{
    public class LocacaoNegocio: InterfaceLocacao
    {
        public void InserirLocacao(Locacao locacao)
        {
            if (locacao == null)
            {
                throw new Exception("O objeto Locação não foi instanciado.");
            }

            if (locacao.ClienteID.ClienteID < 0 || locacao.ClienteID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Cliente.");
            }

            if (locacao.DataVencimento == null || locacao.DataVencimento.Equals("") == true)
            {
                throw new Exception("Você precisa informar uma data de vencimento.");
            }

            new LocacaoDados().InserirLocacao(locacao);
        }

        public void CancelarLocacao(Locacao locacao)
        {
            if (locacao.LocacaoID < 0 || locacao.LocacaoID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID da Locação.");
            } 

            if (locacao.DataCancelamento == null || locacao.DataCancelamento.Equals("") == true)
            {
                throw new Exception("Você precisa informar uma data do cancelamento.");
            }

            new LocacaoDados().CancelarLocacao(locacao);
        }

        public void AlterarLocacao(Locacao locacao)
        {
            if (locacao.LocacaoID < 0 || locacao.LocacaoID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID da Locação.");
            }

            if (locacao.DataVencimento == null || locacao.DataVencimento.Equals("") == true)
            {
                throw new Exception("Você precisa informar uma data do vencimento.");
            }

            new LocacaoDados().AlterarLocacao(locacao);
        }

        public List<Locacao> ListarLocacao(Locacao filtro)
        {
            List<Locacao> retorno = new List<Locacao>();
            List<Locacao> lista = new LocacaoDados().ListarLocacao(filtro);

            foreach (Locacao loc in lista)
            {
                Locacao novaLocacao = new Locacao()
                {
                    LocacaoID = loc.LocacaoID,
                    ClienteID = loc.ClienteID,
                    DataVencimento = loc.DataVencimento,
                    DataPagamento = loc.DataPagamento,
                    DataCancelamento = loc.DataCancelamento
                };

                retorno.Add(novaLocacao);
            }
            return retorno;
        }
    }
}
