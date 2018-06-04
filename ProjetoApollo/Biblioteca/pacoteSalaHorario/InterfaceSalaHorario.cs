using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSalaHorario
{
    interface InterfaceSalaHorario
    {
        void InserirSalaHorario(SalaHorario salaHorario);
        void DeletarSalaHorario(SalaHorario salaHorario);
        void AlterarSalaHorario(SalaHorario salaHorario);
        List<SalaHorario> ListarSalaHorario(SalaHorario filtro);
    }
}
