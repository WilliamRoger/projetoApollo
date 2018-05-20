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
        private int salaID;
        private string salaNome;
        private string descricao;
        private double valor;

        [DataMember (IsRequired = true)]
        public int SalaID
        {
            get { return salaID; }
            set { salaID = value; }
        }

        [DataMember(IsRequired = true)]
        public string SalaNome
        {
            get { return salaNome; }
            set { salaNome = value; }
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
