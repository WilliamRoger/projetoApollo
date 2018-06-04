using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacaoInstrumento
{
    public class LocacaoInstrumentoNegocio : InterfaceLocacaoInstrumento
    {
        LocacaoInstrumentoDados dados = new LocacaoInstrumentoDados();

        public void AlterarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            if (locaInstrumento == null)
                throw new Exception("Informa a instancia");
            if (locaInstrumento.Locacao.LocacaoID < 0)
                throw new Exception("Informa o id da Locacao");
            if (locaInstrumento.Instrumento.InstrumentoID < 0)
                throw new Exception("Informa o id do Instrumento");
            if (locaInstrumento.Valor < 0)
                throw new Exception("Informe o valor dos instrumentos locados");
            if (locaInstrumento.Quantidade < 0)
                throw new Exception("Informe a quantidade dos instrumentos locados");

            dados.AlterarLocacaoInstrumento(locaInstrumento);
        }

        public void DeletarLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            if (locaInstrumento == null)
                throw new Exception("Informa a instancia");
            if (locaInstrumento.Locacao.LocacaoID < 0)
                throw new Exception("Informa o id da Locacao");
            if (locaInstrumento.Instrumento.InstrumentoID < 0)
                throw new Exception("Informa o id do Instrumento");

            dados.DeletarLocacaoInstrumento(locaInstrumento);
        }

        public void InserirLocacaoInstrumento(LocacaoInstrumento locaInstrumento)
        {
            if (locaInstrumento == null)
                throw new Exception("Informa a instancia");
            if (locaInstrumento.Locacao.LocacaoID < 0)
                throw new Exception("Informa o id da Locacao");
            if (locaInstrumento.Instrumento.InstrumentoID < 0)
                throw new Exception("Informa o id do Instrumento");
            if (locaInstrumento.Valor < 0)
                throw new Exception("Informe o valor dos instrumentos locados");
            if (locaInstrumento.Quantidade < 0)
                throw new Exception("Informe a quantidade dos instrumentos locados");

            dados.InserirLocacaoInstrumento(locaInstrumento);
        }

        public List<LocacaoInstrumento> ListarLocacaoInstrumento(LocacaoInstrumento filtro)
        {
            List<LocacaoInstrumento> retorno = new List<LocacaoInstrumento>();
            LocacaoInstrumentoDados dados = new LocacaoInstrumentoDados();

            List<LocacaoInstrumento> lista = dados.ListarLocacaoInstrumento(filtro);

            foreach (LocacaoInstrumento locaInstrumento in lista)
            {
                LocacaoInstrumento novo = new LocacaoInstrumento()
                {
                    Locacao = locaInstrumento.Locacao,
                    Instrumento = locaInstrumento.Instrumento,
                    Valor = locaInstrumento.Valor,
                    Quantidade = locaInstrumento.Quantidade
                };
                retorno.Add(novo);
            }
            return retorno;
        }
    }
}
