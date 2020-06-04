using System;
using System.Collections.Generic;
using System.Text;

namespace aulaclasse
{
    public class animal
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string porte { get; set; }
        public string CorPelo { get; set; }

        public string mae { get; set; }

        public void comer()
        {
            Console.WriteLine($" O cachorro {nome} começou a comer");
        }

        public string latir()
        {
            return "au au au au";
        }

        public void passear( bool chovendo)
        {
            if (chovendo)
                Console.WriteLine($"Sinto muito mas o {nome} não poderá passear");
            else
                Console.WriteLine($"o cachorro {nome} foi passear");
        }

        public string desobedecer()
        {
            return $"sua mãe {mae} irá te dar um coro {nome}";
        }
    }
}