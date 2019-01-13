using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;

namespace ApiIndicadores
{
    public class IndicadoresDAO
    {
        private IConfiguration _config;

        public IndicadoresDAO(IConfiguration config)
        {
            _config = config;
        }

        // public IEnumerable<Indicador> Obter()
        // {
        //     using(SqlConnection conexao = new SqlConnection(
        //         _config.GetConnectionString("BaseIndicadores")
        //     ))
        //     {
        //         return conexao.Query<Indicador>(
        //             "SELECT * FROM dbo.Indicadores;"
        //         );
        //     }
        // }

        public IEnumerable<Indicador> Obter()
        {
            using(SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")
            ))
            {
                return conexao.GetAll<Indicador>();
            }
        }

        // public Indicador ObterPorId(string codIndicador)
        // {
        //     using(SqlConnection conexao = new SqlConnection(
        //         _config.GetConnectionString("BaseIndicadores")
        //     ))
        //     {
        //         return conexao.QueryFirstOrDefault<Indicador>(
        //             "SELECT Sigla, NomeIndicador, UltimaAtualizacao, Valor " +
        //             "FROM dbo.Indicadores " +
        //             "WHERE Sigla = @CodIndicador ",
        //             new { CodIndicador = codIndicador }
        //         );
        //     }
        // }

        public Indicador ObterPorId(string codIndicador)
        {
            using(SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")
            ))
            {
                return conexao.Get<Indicador>(codIndicador);
            }
        }

        public void Incluir(Indicador indicador)
        {
            using(SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")
            ))
            {
                conexao.Insert(indicador);
            }
        }

        public void Excluir(string sigla)
        {
            using(SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseIndicadores")
            ))
            {
                conexao.Delete(new Indicador { Sigla = sigla });
            }
        }
    }
}