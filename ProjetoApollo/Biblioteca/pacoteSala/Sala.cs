using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSala
{
    [DataContract]
    public class Sala
    {
        private int codSala;
        private string nome;
        private string descricao;
        private double valor;

        [DataMember (IsRequired = true)]
        public int CodSala
        {
            get { return codSala; }
            set { codSala = value; }
        }

        [DataMember(IsRequired = true)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [DataMember(IsRequired = true)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        [DataMember(IsRequired = true)]
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
