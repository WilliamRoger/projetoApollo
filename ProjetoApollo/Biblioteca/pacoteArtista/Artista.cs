using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca.pacoteArtista
{
    [DataContract]
    public class Artista
    {
        private int artistaID;
        private string nome;
        private string telefone;
        private string email;

        [DataMember(IsRequired = true)]
        public int ArtistaID
        {
            get { return artistaID; }
            set { artistaID = value; }
        }

        [DataMember(IsRequired = true)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
