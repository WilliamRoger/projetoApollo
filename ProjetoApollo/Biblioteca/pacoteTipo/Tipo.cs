using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteTipo
{
    public class Tipo
    {
        private int codTipo;
        private string nome;

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
    }
}
