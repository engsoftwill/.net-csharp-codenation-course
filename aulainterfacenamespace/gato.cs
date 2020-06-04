using System;

namespace aulainterfacenamespace
{
    public class gato : ISom
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string raca { get; set; }

        public void emitirsom()
        {
            Console.WriteLine("Miau");
        }
    }
}