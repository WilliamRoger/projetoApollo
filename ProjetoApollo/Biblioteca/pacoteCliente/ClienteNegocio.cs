using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    public class ClienteNegocio: InterfaceCliente
    {
        public void InserirCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new Exception("O objeto Cliente não foi instanciado.");
            }
            //if (cliente.ClienteID <= 0)
            //{
            //    throw new Exception("Você precisa informar o ID do Cliente.");
            //}
            if (cliente.ClienteNome == null || cliente.ClienteNome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome do Cliente.");
            }
            if (cliente.Telefone == null || cliente.Telefone.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Telefone do Cliente.");
            }
            if (cliente.Email == null || cliente.Email.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Email do Cliente.");
            }
            new ClienteDados().InserirCliente(cliente);
        }

        public void DeletarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new Exception("O objeto Cliente não foi instanciado.");
            }
            if (cliente.ClienteID <=0)
            {
                throw new Exception("Você precisa informar o ID do Cliente.");
            }
            ClienteDados dadosCliente = new ClienteDados();
            //if (dadosCliente.VerificaDuplicidade(cliente) == false)
            //{
            //    throw new Exception("O Cliente informado não existe.");
            //}
            dadosCliente.DeletarCliente(cliente);
        }

        public void AlterarCliente(Cliente cliente)
        {
            if (cliente.ClienteID <= 0 || cliente.ClienteID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Cliente.");
            }
            if (cliente.ClienteNome == null  || cliente.ClienteNome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome do Cliente.");
            }
            if (cliente.Telefone == null || cliente.Telefone.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Telefone do Cliente.");
            }
            if (cliente.Email == null || cliente.Email.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Email do Cliente.");
            }
            new ClienteDados().AlterarCliente(cliente);
        }

        public List<Cliente> ListarCliente(Cliente cliente)
        {
            List<Cliente> retorno = new List<Cliente>();
            ClienteDados dados = new ClienteDados();
            
            List<Cliente> lista =  dados.ListarCliente(cliente);

            foreach (Cliente cli in lista)
            {
                Cliente novoCliente = new Cliente()
                {
                    ClienteID = cli.ClienteID,
                    ClienteNome = cli.ClienteNome,
                    Telefone = cli.Telefone,
                    Email = cli.Email
                };
                retorno.Add(novoCliente);
            }
            return retorno;
        }

        //public bool VerificaDuplicidade(Cliente cliente)
        //{
        //throw new NotImplementedException();
        //}
    }
}
