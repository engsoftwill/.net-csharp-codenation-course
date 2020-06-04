using System;
using System.Collections.Generic;
using System.Text;

namespace aulaclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            animal doris = new animal();
            doris.CorPelo = "preta";
            doris.mae = "Jessica de Carvalho Xavier";
            doris.Id = 1;
            doris.nome = "Doris Carvalho Xavier";
            doris.porte = "medio";

            doris.comer();
            Console.WriteLine(doris.latir());
            doris.passear(true);
            Console.WriteLine(doris.desobedecer());

        }
    }
}
