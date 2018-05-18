using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteSala
{
    class SalaDados : ConexaoSQLServer, InterfaceSala
    {
       /*. public void AlterarSala(Sala sala)..
        {
            throw new NotImplementedException();
        }

        public void DeletarSala(Sala sala)
        {
            throw new NotImplementedException();
        }
        /*/
        public void InserirSala(Sala sala)
        {
            try
            {   
                //Abrir a conexao.
                this.AbrirConexao();
                //Instrucao do banco para substituir valores.
                string inserirSQL = "INSERT INTO Sala(codSala, Nome, Descricao, Valor)";
                inserirSQL += "VALUES(@codSala, @Nome, @Descricao, @Valor)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@codSala", SqlDbType.Int);
                execSQL.Parameters["@codSala"].Value = sala.CodSala;

                execSQL.Parameters.Add("@Nome", SqlDbType.VarChar);
                execSQL.Parameters["@Nome"].Value = sala.Nome;

                execSQL.Parameters.Add("@Descricao", SqlDbType.VarChar);
                execSQL.Parameters["@Descricao"].Value = sala.Descricao;

                execSQL.Parameters.Add("@Valor", SqlDbType.Decimal);
                execSQL.Parameters["@Valor"].Value = sala.Valor;

                //Executar Instrucao.
                execSQL.ExecuteNonQuery();
                //Liberar memoria.
                execSQL.Dispose();
                //Fechar conexao.
                this.FecharConexao();

            }
            catch (Exception exception)
            {
                throw new Exception("Erro ao Inserir Sala." + exception.Message);

            }

            
        }

        //public List<Sala> ListarHorario(Sala filtro)
        //{
            //throw new NotImplementedException();
        //}
    }
}
