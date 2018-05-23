using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteHorario
{
    interface InterfaceHorario
    {
        void InserirHorario(Horario horario);
        void DeletarHorario(Horario horario);
        void AlterarHorario(Horario horario);
        List<Horario> ListarHorario(Horario horario);
    }
}
