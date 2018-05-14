using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    public class Cliente
    {
        private int clienteID;
        private string clienteNome;
        private string telefone;
        private string email;

        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }

        public string ClienteNome
        {
            get { return clienteNome; }
            set { clienteNome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
