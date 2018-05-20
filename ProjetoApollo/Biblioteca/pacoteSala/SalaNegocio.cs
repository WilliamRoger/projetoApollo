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
            if (sala == null)
            {
                throw new Exception("O objeto Sala não foi instanciado.");
            }
            if (sala.SalaID <= 0 || sala.SalaID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID da Sala.");
            }

            SalaDados dadosSala = new SalaDados();
            dadosSala.DeletarSala(sala);
        }

        public void AlterarSala(Sala sala)
        {
            if (sala.SalaID <= 0 || sala.SalaID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID da Sala.");
            }

            if (sala.SalaNome == null || sala.SalaNome.Equals("") == true)
            {
                throw new Exception("Você precisa informar o Nome da Sala.");
            }

            if (sala.Descricao == null || sala.Descricao.Equals("") == true)
            {
                throw new Exception("Você precisa informar uma Descrição para a Sala.");
            }

            if (sala.Valor <= 0)
            {
                throw new Exception("Você precisa informar o Valor da Sala.");
            }

            new SalaDados().AlterarSala(sala);
        }

        public List<Sala> ListarSala(Sala sala)
        {
            List<Sala> retorno = new List<Sala>();
            SalaDados dadosSala = new SalaDados();

            List<Sala> lista = dadosSala.ListarSala(sala);

            foreach(Sala sl in lista)
            {
                Sala novaSala = new Sala()
                {
                    SalaID = sl.SalaID,
                    SalaNome = sl.SalaNome,
                    Descricao = sl.Descricao,
                    Valor = sl.Valor
                };

                retorno.Add(novaSala);
            }
            return retorno;
        }
    }
}
