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
        private int tipoID;
        private string nome;
        private double valor;

        [DataMember(IsRequired = true)]
        public int InstrumentoID
        {
            get { return instrumentoID; }
            set { instrumentoID = value; }
        }

        [DataMember(IsRequired = true)]
        public int TipoID
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
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
