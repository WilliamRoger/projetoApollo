﻿using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteHorario
{
    public class HorarioDados: ConexaoSQLServer, InterfaceHorario
    {
        //Inserir Horario
        public void InserirHorario(Horario horario)
        {
            try
            {
                //Abrindo a Conexão
                this.AbrirConexao();
                //Instruções SQL
                string inserirSQL = "INSERT INTO Horario (HorarioInicial, HorarioFinal) ";
                inserirSQL += "VALUES (@HorarioInicial, @HorarioFinal)";

                SqlCommand execSQL = new SqlCommand(inserirSQL, this.sqlConn);

                execSQL.Parameters.Add("@HorarioIncial", SqlDbType.Time);
                execSQL.Parameters["@HorarioInicial"].Value = horario.HorarioInicio;

                execSQL.Parameters.Add("@HorarioFinal", SqlDbType.Time);
                execSQL.Parameters["@HorarioFinal"].Value = horario.HorarioFim;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível cadastrar Horário!" + exception.Message);
            }
        }

        //Deletar Horario
        public void DeletarHorario(Horario horario)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string deletarSQL = "DELETE FROM Horario WHERE HorarioID = @HorarioID";

                SqlCommand execSQL = new SqlCommand(deletarSQL, this.sqlConn);

                execSQL.Parameters.Add("@HorarioID", SqlDbType.Int);
                execSQL.Parameters["@HorarioID"].Value = horario.HorarioID;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();

            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível deletar Horário!" + exception.Message);
            }
        }

        //Alterar Horario
        public void AlterarHorario(Horario horario)
        {
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string alterarSQL = "UPDATE Horario SET ";
                alterarSQL += " HorarioInicial = @HorarioInicial, ";
                alterarSQL += " HorarioFinal = @HorarioFinal ";
                alterarSQL += " WHERE HorarioID = @HorarioIDParam";

                SqlCommand execSQL = new SqlCommand(alterarSQL, this.sqlConn);

                execSQL.Parameters.Add("@HorarioInicial", SqlDbType.Time);
                execSQL.Parameters["@HorarioInicial"].Value = horario.HorarioInicio;

                execSQL.Parameters.Add("@HorarioFinal", SqlDbType.Time);
                execSQL.Parameters["@HorarioFinal"].Value = horario.HorarioFim;

                //Executando as Instruções
                execSQL.ExecuteNonQuery();
                //Liberando a memória
                execSQL.Dispose();
                //Fechando a Conexão
                this.FecharConexao();
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível alterar Horário!" + exception.Message);
            }
        }

        //Listar Horario
        public List<Horario> ListarHorario(Horario filtro)
        {
            List<Horario> retorno = new List<Horario>();
            try
            {
                //Abrindo Conexão
                this.AbrirConexao();
                //Instruções SQL
                string listarSQL = "SELECT HorarioID, HorarioIncial, HorarioFinal FROM Horario WHERE HorarioID = HorarioID";

                if (filtro.HorarioID > 0)
                {
                    listarSQL += " AND HorarioID = @HorarioID";
                }

                SqlCommand execSQL = new SqlCommand(listarSQL, this.sqlConn);

                if (filtro.HorarioID > 0)
                {
                    execSQL.Parameters.Add("@HorarioID", SqlDbType.Int);
                    execSQL.Parameters["@HorarioID"].Value = filtro.HorarioID;
                }

                //Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = execSQL.ExecuteReader();

                //Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Horario horario = new Horario()
                    {
                        HorarioID = DbReader.GetInt32(DbReader.GetOrdinal("HorarioID"));
                        HorarioInicio = DbReader.GetString(DbReader.GetOrdinal("HorarioInicio"));
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Erro de conexão impossível listar Clientes!" + exception.Message);
            }
        }
    }
}
