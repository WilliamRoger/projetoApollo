using Biblioteca.pacoteCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    
    public interface IService1
    {
        void InserirCliente(Cliente cliente);
        void DeletarCliente(Cliente cliente);
    }
}
