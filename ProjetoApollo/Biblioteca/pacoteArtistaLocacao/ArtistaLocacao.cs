using Biblioteca.pacoteArtista;
using Biblioteca.pacoteLocacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtistaLocacao
{
    [DataContract]
    public class ArtistaLocacao
    {
        private int quantidade;
        private decimal valor;
        private Artista artistaID;
        private Locacao locacaoID;

        [DataMember(IsRequired = true)]
        public int Quantidade
        {
            get { return quantidade;  }
            set { quantidade = value; }
        }

        [DataMember(IsRequired = true)]
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [DataMember(IsRequired = true)]
        public Artista ArtistaID
        {
            get { return artistaID; }
            set { artistaID = value; }
        }

        [DataMember(IsRequired = true)]
        public Locacao LocacaoID
        {
            get { return locacaoID; }
            set { locacaoID = value; }
        }
    }
}
