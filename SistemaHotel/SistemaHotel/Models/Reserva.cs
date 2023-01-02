using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Models;

namespace SistemaHotel.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        #region Métodos

        public void CadastrarHospedes(List<Pessoa> pessoa)
        {
            Hospedes = pessoa;
        }

        public void CadastrarSuite(Suite suite)
        {
            
            if (suite.Capacidade < Hospedes.Count)
            {
                Console.WriteLine("Suite não comporta todos os hóspedes.");
                throw new Exception();
            }

            Suite = suite;
                
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public float CalcularValorTotal()
        {
            float valorTotal = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados > 10)
            {
                valorTotal = (float)(valorTotal * 0.9);
                return valorTotal;
            }
            return valorTotal;
        }

        
        #endregion

    }
}
