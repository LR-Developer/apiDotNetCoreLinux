using System;

namespace ApiIndicadores
{
    public class Indicador
    {
        public string Sigla { get; private set; }
        public string NomeIndicador { get; private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public decimal Valor { get; private set; }
    }
}