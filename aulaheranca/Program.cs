using System;

namespace aulaheranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Adulto will = new Adulto("will")
            {
                datanasc    =   new DateTime(1990,10,15),
                Id          =   111120,
                sexmas      =   true
            };
            will.comer();
            will.tomarbanho();
            will.andar();

            Adulto jess = new Adulto("Jessica")
            {
                datanasc    =   new DateTime(1995,05,06),
                Id          =   111121,
                sexmas      =   false
            };
            jess.comer();
            jess.tomarbanho();

            bebe sophie = new bebe(123,"Stella")
            {
                datanasc    =   new DateTime(2020,12,26),
                sexmas      =   false
            };
            sophie.comer();
            sophie.tomarbanho();

            Console.WriteLine(calculo.Somar(10,15));
            
            Adulto.dizerbomdia(jess.nome);



        }
    }
}
