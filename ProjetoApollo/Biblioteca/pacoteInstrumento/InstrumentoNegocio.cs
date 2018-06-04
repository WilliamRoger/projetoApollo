using Biblioteca.pacoteTipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteInstrumento
{
    public class InstrumentoNegocio : InterfaceInstrumento
    {
        InstrumentoDados dados = new InstrumentoDados();

        public void AlterarInstrumento(Instrumento instrumento)
        {
            if (instrumento == null)
                throw new Exception("Instrumento não instanciado");
            if (instrumento.InstrumentoID <= 0)
                throw new Exception("Informa o ID do instrumento");
            if (instrumento.Nome.Equals("") == true || instrumento.Nome == null)
                throw new Exception("Informa o nome do instrumento");
            if (instrumento.Valor <= 0)
                throw new Exception("Informa o valor do instrumento");
            if (instrumento.TipoID.TipoID <= 0)
                throw new Exception("Informa o tipoID do instrumento");

            dados.AlterarInstrumento(instrumento);
        }

        public void DeletarInstrumento(Instrumento instrumento)
        {
            if (instrumento == null)
                throw new Exception("Instrumento não instanciado");
            if (instrumento.InstrumentoID <= 0 )
                throw new Exception("Id inválido");

            dados.DeletarInstrumento(instrumento);
        }

        public void InserirInstrumento(Instrumento instrumento)
        {
            if (instrumento == null)
                throw new Exception("Instrumento não instanciado");
            if (instrumento.Nome.Equals("") == true || instrumento.Nome == null)
                throw new Exception("Informa o nome do instrumento");
            if (instrumento.Valor <= 0)
                throw new Exception("Informa o valor do instrumento");
            if(instrumento.TipoID.TipoID <= 0)
                throw new Exception("Informa o tipoID do instrumento");

            dados.InserirInstrumento(instrumento);
        }

        public List<Instrumento> ListarInstrumento(Instrumento filtro)
        {
            List<Instrumento> retorno = new List<Instrumento>();
            InstrumentoDados dados = new InstrumentoDados();

            List<Instrumento> lista = dados.ListarInstrumento(filtro);

            foreach (Instrumento instr in lista)
            {
                Instrumento novo = new Instrumento()
                {
                    InstrumentoID = instr.InstrumentoID,
                    Nome = instr.Nome,
                    Valor = instr.Valor,
                    TipoID = instr.TipoID
                };
                retorno.Add(novo);
            }
            return retorno;
        }
    }
}
