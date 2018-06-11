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
        private decimal valor;

        public Sala() { }

        public Sala(int salaID, string salaNome, string descricao, decimal valor)
        {
            this.salaID = salaID;
            this.salaNome = salaNome;
            this.descricao = descricao;
            this.valor = valor;
        }

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
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
