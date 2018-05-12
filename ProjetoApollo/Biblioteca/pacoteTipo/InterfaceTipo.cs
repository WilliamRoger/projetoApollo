using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteTipo
{
    interface InterfaceTipo
    {
        void InserirTipo(Tipo tipo);
        void DeletarTipo(Tipo tipo);
        void AlterarTipo(Tipo tipo);
        List<Tipo> ListarHorario(Tipo filtro);
        bool VerificaDuplicidade(Tipo tipo);
    }
}
