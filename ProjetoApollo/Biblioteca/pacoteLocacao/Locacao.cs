using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacao
{
    public class Locacao
    {
        private int codLocacao;
        private int codCliente;
        private string dataVencimento;
        private string dataPagamento;

        public int CodLocacao
        {
            get { return codLocacao; }
            set { codLocacao = value; }
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public string DataPagamento
        {
            get { return dataPagamento; }
            set { DataPagamento = value; }
        }
    }
}
