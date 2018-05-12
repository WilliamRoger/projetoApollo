using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteHorario
{
    public class Horario
    {
        private int codHorario;
        private string horarioInicio;
        private string horarioFim;

        public int CodHorario
        {
            get { return codHorario; }
            set { codHorario = value; }
        }

        public string HorarioInicio
        {
            get { return horarioInicio; }
            set { horarioInicio = value; }
        }

        public string HorarioFim
        {
            get { return horarioFim; }
            set { horarioFim = value; }
        }
    }
}
