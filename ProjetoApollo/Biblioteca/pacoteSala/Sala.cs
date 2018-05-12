using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSala
{
    public class Sala
    {
        private int codSala;
        private string nome;
        private string descricao;
        private double valor;

        public int CodSala
        {
            get { return codSala; }
            set { codSala = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
