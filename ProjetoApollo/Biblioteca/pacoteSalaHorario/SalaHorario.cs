using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteLocacao;
using Biblioteca.pacoteSala;
using Biblioteca.pacoteHorario;
using System.Runtime.Serialization;

namespace Biblioteca.pacoteSalaHorario
{
    [DataContract]
    public class SalaHorario
    {
        private int codigo;
        private string data;
        private decimal valor;
        private Sala sala;
        private Horario horario;
        private Locacao locacao;

        [DataMember(IsRequired = true)]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember(IsRequired = true)]
        public string Data
        {
          get { return data; }
          set { data = value; }
        }

        [DataMember(IsRequired = true)]
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [DataMember(IsRequired = true)]
        public Sala Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        [DataMember(IsRequired = true)]
        public Horario Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        [DataMember(IsRequired = true)]
        public Locacao Locacao
        {
            get { return locacao; }
            set { locacao = value; }
        }
    }
}
