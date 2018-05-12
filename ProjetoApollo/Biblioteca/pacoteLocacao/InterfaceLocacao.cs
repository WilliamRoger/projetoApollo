using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacao
{
    interface InterfaceLocacao
    {
        void InserirLocacao(Locacao locacao);
        void CancelarLocacao(Locacao locacao);
        void AlterarLocacao(Locacao locacao);
        List<Locacao> ListarLocacao(Locacao filtro);
        bool VerificaDuplicidade(Locacao locacao);
    }
}
