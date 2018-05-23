using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteHorario
{
    [DataContract]
    public class Horario
    {
        private int horarioID;
        private string horarioInicial;
        private string horarioFinal;

        [DataMember(IsRequired = true)]
        public int HorarioID
        {
            get { return horarioID; }
            set { horarioID = value; }
        }

        [DataMember(IsRequired = true)]
        public string HorarioInicial
        {
            get { return horarioInicial; }
            set { horarioInicial = value; }
        }

        [DataMember(IsRequired = true)]
        public string HorarioFinal
        {
            get { return horarioFinal; }
            set { horarioFinal = value; }
        }
    }
}
