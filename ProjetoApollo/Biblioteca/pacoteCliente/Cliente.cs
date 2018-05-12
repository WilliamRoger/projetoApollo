using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteCliente
{
    public class Cliente
    {
        private int codCliente;
        private string nome;
        private string telefone;
        private string email;

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
