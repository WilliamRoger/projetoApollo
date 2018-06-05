using Biblioteca.pacoteInstrumento;
using Biblioteca.pacoteLocacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca.pacoteLocacaoInstrumento
{
    [DataContract]
    public class LocacaoInstrumento
    {
        private Locacao locacao;
        private Instrumento instrumento;
        private decimal valor;
        private int quantidade;

        public LocacaoInstrumento()
        {
            this.locacao = new Locacao();
            this.instrumento = new Instrumento();
        }

        public LocacaoInstrumento(Locacao locacao, Instrumento instrumento, decimal valor, int quantidade)
        {
            this.locacao = locacao;
            this.instrumento = instrumento;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        [DataMember(IsRequired = true)]
        public Locacao Locacao
        {
            get { return locacao; }
            set { locacao = value; }
        }

        [DataMember(IsRequired = true)]
        public Instrumento Instrumento
        {
            get { return instrumento; }
            set { instrumento = value; }
        }

        [DataMember(IsRequired = true)]
        public decimal Valor
        {
          get { return valor; }
          set { valor = value; }
        }

        [DataMember(IsRequired = true)]
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}
