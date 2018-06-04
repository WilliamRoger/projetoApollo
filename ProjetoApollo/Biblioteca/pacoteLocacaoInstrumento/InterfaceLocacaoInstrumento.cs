using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacaoInstrumento
{
    interface InterfaceLocacaoInstrumento
    {
        void InserirLocacaoInstrumento(LocacaoInstrumento locaInstrumento);
        void DeletarLocacaoInstrumento(LocacaoInstrumento locaInstrumento);
        void AlterarLocacaoInstrumento(LocacaoInstrumento locaInstrumento);
        List<LocacaoInstrumento> ListarLocacaoInstrumento(LocacaoInstrumento filtro);
    }
}
