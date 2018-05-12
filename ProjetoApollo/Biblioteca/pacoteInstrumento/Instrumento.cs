using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteInstrumento
{
    public class Instrumento
    {
        private int codInstrumento;
        private int codTipo;
        private string nome;
        private double valor;

        public int CodInstrumento
        {
            get { return codInstrumento; }
            set { codInstrumento = value; }
        }

        public int CodTipo
        {
            get { return codTipo; }
            set { codTipo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
