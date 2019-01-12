using System;
using Dapper.Contrib.Extensions;

namespace ApiIndicadores
{
    [Table("dbo.Indicadores")]
    public class Indicador
    {
        [ExplicitKey]
        public string Sigla { get; private set; }
        public string NomeIndicador { get; private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public decimal Valor { get; private set; }
    }
}