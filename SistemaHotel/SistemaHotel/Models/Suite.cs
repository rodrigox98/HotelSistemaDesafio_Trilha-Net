using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Models
{
    internal class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public float ValorDiaria { get; set; }

        public Suite()
        {
            
        }

        public Suite(string tipoSuite, int capacidade, float valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
