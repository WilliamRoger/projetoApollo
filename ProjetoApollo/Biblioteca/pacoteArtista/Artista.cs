using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtista
{
    public class Artista
    {
        private int codArtista;
        private string nome;
        private string telefone;
        private string email;

        public int CodArtista
        {
            get { return codArtista; }
            set { codArtista = value; }
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
