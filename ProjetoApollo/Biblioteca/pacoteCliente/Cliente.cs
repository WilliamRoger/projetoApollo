using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    [DataContract]
    public class Cliente
    {
        private int clienteID;
        private string clienteNome;
        private string telefone;
        private string email;

        public Cliente() { }

        public Cliente(int clienteID, string clienteNome, string telefone, string email)
        {
            this.clienteID = clienteID;
            this.clienteNome = clienteNome;
            this.telefone = telefone;
            this.email = email;
        }

        [DataMember(IsRequired = true)]
        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }

        [DataMember(IsRequired = true)]
        public string ClienteNome
        {
            get { return clienteNome; }
            set { clienteNome = value; }
        }

        [DataMember(IsRequired = true)]
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        [DataMember(IsRequired = true)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
