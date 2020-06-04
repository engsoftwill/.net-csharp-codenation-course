using System;
namespace aulainterfacenamespace
{
    public class carro : ISom
    {
        public int id { get; set; }
        public string modelo { get; set; }


        public void emitirsom()
        {
            Console.WriteLine("Vrummmm");
        }
    }
}

