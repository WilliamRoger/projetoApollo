using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteHorario
{
    public class HorarioNegocio: InterfaceHorario
    {
        public void InserirHorario(Horario horario)
        {
            if (horario == null)
            {
                throw new Exception("O objeto Horário não foi instanciado.");
            }

            if (horario.HorarioInicial == null || horario.HorarioInicial.Equals("") == true)
            {
                throw new Exception("Você precisa informar um Horário Inicial.");
            }

            if (horario.HorarioFinal == null || horario.HorarioFinal.Equals("") == true)
            {
                throw new Exception("Você precisa informar um Horário Final.");
            }

            new HorarioDados().InserirHorario(horario);
        }

        public void DeletarHorario(Horario horario)
        {
            if (horario == null)
            {
                throw new Exception("O objeto Horário não foi instanciado.");
            }

            if (horario.HorarioID <= 0 || horario.HorarioID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Horário.");
            }

            new HorarioDados().DeletarHorario(horario);
        }

        public void AlterarHorario(Horario horario)
        {
            if (horario.HorarioID <= 0 || horario.HorarioID.Equals("") == true)
            {
                throw new Exception("Você precisa informar o ID do Cliente.");
            }

            if (horario.HorarioInicial == null || horario.HorarioInicial.Equals("") == true)
            {
                throw new Exception("Você precisa informar um Horário Inicial.");
            }

            if (horario.HorarioFinal == null || horario.HorarioFinal.Equals("") == true )
            {
                throw new Exception("Você precisa informar um Horário Inicial.");
            }

            new HorarioDados().AlterarHorario(horario);
        }

        public List<Horario> ListarHorario(Horario horario)
        {
            List<Horario> retorno = new List<Horario>();

            List<Horario> lista = new HorarioDados().ListarHorario(horario);

            foreach (Horario hora in  lista)
            {
                Horario novoHorario = new Horario()
                {
                    HorarioID = hora.HorarioID,
                    HorarioInicial = hora.HorarioInicial,
                    HorarioFinal = hora.HorarioFinal
                };

                retorno.Add(novoHorario);
            }
            return retorno;
        }
    }
}
