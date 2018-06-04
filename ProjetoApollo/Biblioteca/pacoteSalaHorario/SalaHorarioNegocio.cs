using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSalaHorario
{
    public class SalaHorarioNegocio : InterfaceSalaHorario
    {
        SalaHorarioDados dados = new SalaHorarioDados();

        public void AlterarSalaHorario(SalaHorario salaHorario)
        {
            if (salaHorario == null)
                throw new Exception("Informa a instancia");
            if (salaHorario.Codigo < 0)
                throw new Exception("Informa o Id");
            if (salaHorario.Data == null || salaHorario.Data.Equals("") == true)
                throw new Exception("Informa a Data");
            if (salaHorario.Valor < 0)
                throw new Exception("Informa o Valor");
            if (salaHorario.Sala.SalaID < 0)
                throw new Exception("Informa o Id da Sala");
            if (salaHorario.Horario.HorarioID < 0)
                throw new Exception("Informa o Id do Horario");
            if (salaHorario.Locacao.LocacaoID < 0)
                throw new Exception("Informa o Id da Locacao");
            dados.AlterarSalaHorario(salaHorario);
        }

        public void DeletarSalaHorario(SalaHorario salaHorario)
        {
            if (salaHorario == null)
                throw new Exception("Informa a instancia");
            if (salaHorario.Codigo < 0)
                throw new Exception("Informa o Id");
            dados.DeletarSalaHorario(salaHorario);
        }

        public void InserirSalaHorario(SalaHorario salaHorario)
        {
            if (salaHorario == null)
                throw new Exception("Informa a instancia");
            if (salaHorario.Codigo < 0)
                throw new Exception("Informa o Id");
            if (salaHorario.Data == null || salaHorario.Data.Equals("") == true)
                throw new Exception("Informa a Data");
            if (salaHorario.Valor < 0)
                throw new Exception("Informa o Valor");
            if (salaHorario.Sala.SalaID < 0)
                throw new Exception("Informa o Id da Sala");
            if (salaHorario.Horario.HorarioID < 0)
                throw new Exception("Informa o Id do Horario");
            if (salaHorario.Locacao.LocacaoID < 0)
                throw new Exception("Informa o Id da Locacao");
            dados.InserirSalaHorario(salaHorario);
        }

        public List<SalaHorario> ListarSalaHorario(SalaHorario filtro)
        {
            List<SalaHorario> retorno = new List<SalaHorario>();

            List<SalaHorario> lista = dados.ListarSalaHorario(filtro);
            foreach (SalaHorario salaHorario in lista)
            {
                SalaHorario novo = new SalaHorario()
                {
                    Codigo = salaHorario.Codigo,
                    Data = salaHorario.Data,
                    Valor = salaHorario.Valor,
                    Sala = salaHorario.Sala,
                    Horario = salaHorario.Horario,
                    Locacao = salaHorario.Locacao
                };
                retorno.Add(novo);
            }
            return retorno;
        }
    }
}
