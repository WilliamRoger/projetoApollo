using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    interface InterfaceCliente
    {
        void InserirCliente(Cliente cliente);
        void DeletarCliente(Cliente cliente);
        void AlterarCliente(Cliente cliente);
        List<Cliente> ListarCliente(Cliente filtro);
        //bool VerificaDuplicidade(Cliente cliente);
    }
}
