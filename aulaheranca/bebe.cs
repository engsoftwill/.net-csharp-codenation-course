using System;
using System.Collections.Generic;

namespace aulaheranca
{
    public class bebe : heranca
    {
        public bebe(int id, string nome) : base(nome)
        {

        }
        public override void andar()
        {
            var sexo = sexmas ? "o" : "a";
            Console.WriteLine ($"{nome} andou d{sexo}");
        }

        public override void comer()
        {
            var sexo = sexmas ? "o" : "a";
            Console.WriteLine ($"Jéssica Lopes iniciou alimentacao d{sexo} {nome}");
        }
        public override void tomarbanho()
        {
            var sexo = sexmas ? "o" : "a";
            Console.WriteLine ($"Jéssica Lopes iniciou o banho d{sexo} {nome}");
        }

    }
}