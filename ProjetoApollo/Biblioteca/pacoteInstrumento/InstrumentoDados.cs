using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlInstrumento;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pacoteConexao;

namespace Biblioteca.pacoteInstrumento
{
    public class InstrumentoDados: ConexaoSQLServer, InterfaceInstrumento
    {   //Inserir Instrumento
        //public void InserirInstrumento(Instrumento instrumento)
        //{
        //    try
        //    {
        //        //Abrindo a Conexão
        //        this.AbrirConexao();
        //        //Instruções SQL
        //        string inserirSQL = "INSERT INTO Instrumento(Nome, Valor)";
        //        inserirSQL += "VALUES (@ClienteNome, @Valor)";

        //        SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

        //        execSQL.Parameters.Add("@Nome", SqlDbType.VarChar);
        //        execSQL.Parameters["@Nome"].Value = instrumento.Nome;

        //        execSQL.Parameters.Add("@Valor", SqlDbType.VarChar);
        //        execSQL.Parameters["@Valor"].Value = instrumento.Valor;
                            

        //        //Executando as Instruções
        //        execSQL.ExecuteNonQuery();
        //        //Liberando a memória
        //        execSQL.Dispose();
        //        //Fechando a Conexão
        //        this.FecharConexao();
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception("Erro de conexão impossível cadastrar Instrumento!" + exception.Message);
        //    }
        //}

        //Deletar Instrumento
        //public void DeletarInstrumento(Instrumento instrumento)
        //{
        //    try
        //    {
        //        //Abrindo Conexão
        //        this.AbrirConexao();
        //        //Instruções SQL
        //        string deletarSQL = "DELETE FROM Instrumento WHERE CodInstrumento = @CodInstrumento";
        //        SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

        //        execSQL.Parameters.Add("@CodInstrumento", SqlDbType.Int);
        //        execSQL.Parameters["@CodInstrumento"].Value = instrumento.CodInstrumento;

        //        //Executando as Instruções
        //        execSQL.ExecuteNonQuery();
        //        //Liberando a memória
        //        execSQL.Dispose();
        //        //Fechando a Conexão
        //        this.FecharConexao();
        //    }
        //    catch (Exception exception)
        //    {

        //        throw new Exception("Erro de conexão impossível deletar Instrumento!" + exception.Message);
        //    }
        //}

        //Alterar Instrumento
        //public void AlterarInstrumento(Instrumento instrumento)
        //{
        //    try
        //    {
        //        //Abrindo Conexão
        //        this.AbrirConexao();
        //        //Instruções SQL
        //        string alterarSQL = "UPDATE Instrumento SET CodInstrumento = @CodInstrumento, CodTipo = @CodTipo, Nome = @Nome, Valor = @Valor WHERE CodInstrumento == @CodInstrumentoParam";
        //        SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

        //        execSQL.Parameters.Add("@CodInstrumento", SqlDbType.Int);
        //        execSQL.Parameters["@CodInstrumento"].Value = instrumento.CodInstrumento;

        //        execSQL.Parameters.Add("@CodTipo", SqlDbType.Int);
        //        execSQL.Parameters["@CodTipo"].Value = instrumento.CodTipo;

        //        execSQL.Parameters.Add("@Nome", SqlDbType.VarChar);
        //        execSQL.Parameters["@Nome"].Value = instrumento.Nome;

        //        execSQL.Parameters.Add("@Valor", SqlDbType.VarChar);
        //        execSQL.Parameters["@Valor"].Value = instrumento.Valor;

        //        execSQL.Parameters.Add("@CodInstrumentoParam", SqlDbType.VarChar);
        //        execSQL.Parameters["@CodInstrumentoParam"].Value = instrumento.CodInstrumento;

        //        //Executando as Instruções
        //        execSQL.ExecuteNonQuery();
        //        //Liberando a memória
        //        execSQL.Dispose();
        //        //Fechando a Conexão
        //        this.FecharConexao();
        //    }
        //    catch (Exception exception)
        //    {

        //        throw new Exception("Erro de conexão impossível alterar Instrumento!" + exception.Message);
        //    }
        //}

        //Listar Instrumento
        //public List<Cliente> ListarCliente(Cliente filtro)
        //{
        //    List<Cliente> retorno = new List<Cliente>();
        //    try
        //    {
        //        //Abrindo Conexão
        //        this.AbrirConexao();
        //        //Instruções SQL
        //        string listarSQL = "SELECT ClienteID, ClienteNome, Telefone, Email FROM Cliente WHERE ClienteID = ClienteID";
        //        if (filtro.ClienteID > 0)
        //        {
        //            listarSQL += " AND ClienteID = @ClienteID";
        //        }
        //        if (filtro.ClienteNome != null && filtro.ClienteNome.Trim().Equals("") == false)
        //        {
        //            listarSQL += " AND ClienteNome LIKE @ClienteNome";
        //        }

        //        SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

        //        if (filtro.ClienteID > 0)
        //        {
        //            execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
        //            execSQL.Parameters["@ClienteID"].Value = filtro.ClienteID;
        //        }
        //        if (filtro.ClienteNome != null && filtro.ClienteNome.Trim().Equals("") == false)
        //        {
        //            execSQL.Parameters.Add("@ClienteNome", SqlDbType.VarChar);
        //            execSQL.Parameters["@ClienteNome"].Value = "%" + filtro.ClienteNome + "%";
        //        }

        //        //Executando a instrucao e colocando o resultado em um leitor
        //        SqlDataReader DbReader = execSQL.ExecuteReader();

        //        //Lendo o resultado da consulta
        //        while (DbReader.Read())
        //        {
        //            Cliente cliente = new Cliente();
        //            //Acessando os valores das colunas do resultado
        //            cliente.ClienteID = DbReader.GetInt32(DbReader.GetOrdinal("ClienteID"));
        //            cliente.ClienteNome = DbReader.GetString(DbReader.GetOrdinal("ClienteNome"));
        //            cliente.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
        //            cliente.Email = DbReader.GetString(DbReader.GetOrdinal("Email"));

        //            retorno.Add(cliente);
        //        }

        //        //Fechando o leitor de resultados
        //        DbReader.Close();
        //        //liberando a memoria 
        //        execSQL.Dispose();
        //        //fechando a conexao
        //        this.FecharConexao();
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception("Erro de conexão impossível listar Clientes!" + exception.Message);
        //    }
        //}

        //Verificar se existe duplicidade de cliente
        //public bool VerificaDuplicidade(Cliente cliente)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        //Abrindo Conexão
        //        this.AbrirConexao();
        //        //Instruções SQL
        //        string verificarSQL = "SELECT ClienteID, ClienteNome, Telefone, Email FROM Cliente WHERE ClienteID = @ClienteID";
        //        SqlCommand execSQL = new SqlCommand(verificarSQL, this.sqlConn);

        //        execSQL.Parameters.Add("@ClienteID", SqlDbType.Int);
        //        execSQL.Parameters["@ClienteID"].Value = cliente.ClienteID;

        //        //Executando a instrucao e colocando o resultado em um leitor
        //        SqlDataReader DbReader = execSQL.ExecuteReader();

        //        //lendo o resultado da consulta
        //        while (DbReader.Read())
        //        {
        //            retorno = true;
        //            break;
        //        }
        //        //fechando o leitor de resultados
        //        DbReader.Close();
        //        //liberando a memoria 
        //        execSQL.Dispose();
        //        //fechando a conexao
        //        this.FecharConexao();
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception("Erro de conexão impossível verificar duplicidade de Clientes!" + exception.Message);
        //    }
        //}
    }
}