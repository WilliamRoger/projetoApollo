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

        public ArtistaLocacao()
        {
            this.artistaID = new Artista();
            this.locacaoID = new Locacao();
        }

        public ArtistaLocacao(int quantidade, decimal valor, Artista artistaID, Locacao locacaoID)
        {
            this.quantidade = quantidade;
            this.valor = valor;
            this.artistaID = artistaID;
            this.locacaoID = locacaoID;
        }

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
