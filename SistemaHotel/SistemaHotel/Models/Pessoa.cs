using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
    }
}
