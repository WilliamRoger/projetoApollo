using Biblioteca.pacoteTipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteInstrumento
{   
    [DataContract]
    public class Instrumento
    {
        private int instrumentoID;
        private Tipo tipoID;
        private string nome;
        private decimal valor;

        public Instrumento()
        {
            this.tipoID = new Tipo();
        }

        public Instrumento(int instrumentoID, Tipo tipoID, string nome, decimal valor)
        {
            this.instrumentoID = instrumentoID;
            this.tipoID = tipoID;
            this.nome = nome;
            this.valor = valor;
        }

        [DataMember(IsRequired = true)]
        public int InstrumentoID
        {
            get { return instrumentoID; }
            set { instrumentoID = value; }
        }

        [DataMember(IsRequired = true)]
        public Tipo TipoID
        {
            get { return tipoID; }
            set { tipoID = value; }
        }

        [DataMember(IsRequired = true)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [DataMember(IsRequired = true)]
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
