using SistemaHotel.Models;
using System;
using System.Collections.Generic;

namespace SistemaHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- BEM VINDO AO HOTEL ----");

            //Cria a suite
            Suite suite = new Suite("Premium", 1, 15);
           
            
            //Lista de hospedes
            List<Pessoa> hospedes = new List<Pessoa>();
            Pessoa p1 = new Pessoa("Rodrigo", "Lima");
            Pessoa p2 = new Pessoa("Pedro", "Cabloco");

            hospedes.Add(p1);
            hospedes.Add(p2);


            //Cria reserva
            Reserva reserva = new Reserva(10);
            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarSuite(suite);
            


            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária total  : {reserva.CalcularValorTotal()}");
        }
    }
}
