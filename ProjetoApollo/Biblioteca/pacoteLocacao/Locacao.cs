using Biblioteca.pacoteCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteLocacao
{
    [DataContract]
    public class Locacao
    {
        private int locacaoID;
        private Cliente clienteID;
        private string dataVencimento;
        private string dataPagamento;
        private string dataCancelamento;

        [DataMember(IsRequired = true)]
        public int LocacaoID
        {
            get { return locacaoID; }
            set { locacaoID = value; }
        }

        [DataMember(IsRequired = true)]
        public Cliente ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }

        [DataMember(IsRequired = true)]
        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        [DataMember(IsRequired = true)]
        public string DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        [DataMember(IsRequired = true)]
        public string DataCancelamento
        {
            get { return dataCancelamento; }
            set { dataCancelamento = value; }
        }
    }
}
