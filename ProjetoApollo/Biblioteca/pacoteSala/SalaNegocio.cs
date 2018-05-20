using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSala
{
    public class SalaNegocio : InterfaceSala
    {
        public void InserirSala(Sala sala)
        {
            if (sala == null)
            {
                throw new Exception("O objeto Sala não foi instanciado.");
            }

            if (sala.SalaNome == null || sala.SalaNome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome da Sala.");
            }

            if (sala.Descricao == null || sala.Descricao.Equals("") == true)
            {
                throw new Exception("Você precisa informar a Descrição da Sala.");
            }

            if (sala.Valor <= 0)
            {
                throw new Exception("Você precisa informar o Valor da Sala.");
            }

            new SalaDados().InserirSala(sala);            
        }

        public void DeletarSala(Sala sala)
        {

        }

        public void AlterarSala(Sala sala)
        {

        }
    }
}
