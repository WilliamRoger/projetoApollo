using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteTipo
{
    [DataContract]
    public class Tipo
    {
        private int tipoID;
        private string nome;

        public Tipo() { }

        public Tipo(int tipoID, string nome)
        {
            this.tipoID = tipoID;
            this.nome = nome;
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
    }
}
