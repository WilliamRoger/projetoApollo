using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtistaLocacao
{
    interface InterfaceArtistaLocacao
    {
        void InserirArtistaLocacao(ArtistaLocacao artistaLocacao);
        void DeletarArtistaLocacao(ArtistaLocacao artistaLocacao);
        void AlterarArtistaLocacao(ArtistaLocacao artistaLocacao);
        List<ArtistaLocacao> ListarArtistaLocacao(ArtistaLocacao filtro);
    }
}
