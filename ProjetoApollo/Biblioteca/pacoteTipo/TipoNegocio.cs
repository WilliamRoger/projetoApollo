using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteTipo
{
    class TipoNegocio: InterfaceTipo
    {
        public void InserirTipo(Tipo tipo)
        {
            if (tipo == null)
            {
                throw new Exception("O objeto Tipo não foi instanciado.");
            }

            if (tipo.Nome == null || tipo.Nome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome do Tipo.");
            }

            new TipoDados().InserirTipo(tipo);
        }

        public void DeletarTipo(Tipo tipo)
        {
            if (tipo == null)
            {
                throw new Exception("O objeto Tipo não foi instanciado.");
            }

            if (tipo.TipoID <= 0 || tipo.TipoID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Tipo.");
            }

            new TipoDados().DeletarTipo(tipo);
        }

        public void AlterarTipo(Tipo tipo)
        {
            if (tipo.TipoID <= 0 || tipo.TipoID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Tipo.");
            }

            if (tipo.Nome == null || tipo.Nome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome do Tipo.");
            }

            new TipoDados().AlterarTipo(tipo);
        }

        public List<Tipo> ListarTipo(Tipo filtro)
        {
            List<Tipo> retorno = new List<Tipo>();

            List<Tipo> lista = new TipoDados().ListarTipo(filtro);

            foreach(Tipo tip in lista)
            {
                Tipo NovoTipo = new Tipo()
                {
                    TipoID = tip.TipoID,
                    Nome = tip.Nome
                };
                retorno.Add(NovoTipo);
            }
            return retorno;
        }
    }
}
