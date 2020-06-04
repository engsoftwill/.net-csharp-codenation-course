using System;
using System.Collections.Generic;

namespace aulaheranca
{
    public class Adulto:heranca
    {
        public Adulto(string nome) : base(nome)
        {

        }
         public override void andar()
        {
            var sexo = sexmas ? "o" : "a";
            Console.WriteLine ($"{nome} andou d{sexo}");
        }
        public static void dizerbomdia(string nome)
        {
            Console.WriteLine($"{nome} diga bom dia");
        }
        
    }
}