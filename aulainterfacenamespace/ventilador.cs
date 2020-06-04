using System;
namespace aulainterfacenamespace
{
    public class ventilador : ISom
    {
        public int Id { get; set; }
        public string marca { get; set; }
        public void emitirsom()
        {
            Console.WriteLine("shhhhhhhhh");
        }
            
    }
}
