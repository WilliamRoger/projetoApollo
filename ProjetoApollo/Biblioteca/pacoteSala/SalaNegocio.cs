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
            //Validacao da criacao da sala.
            if (sala == null)
            {
                throw new Exception("Por Favor Criar Sala.");
            }

            //Validacao do nome vazio.
            if (sala.Nome == null || sala.Nome.Equals("") == true)
            {
                throw new Exception("Inserir nome da Sala.");
            }

            //Validacao do preenchimento da descricao Sala.
            if (sala.Descricao == null || sala.Descricao.Equals(""))
            {
                throw new Exception("Preencher Descriç±ao");
            }

            //Inserir o valor da sala.
            if (sala.Valor <= 0)
            {
                throw new Exception("Inseriri Valor.");
            }

            //Ciar uma sala nova após a validaçao.
            new SalaDados().InserirSala(sala);
            
        }
    }
}
