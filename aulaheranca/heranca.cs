using System;
using System.Collections.Generic;
namespace aulaheranca
{
    public abstract class heranca
    {
        public heranca (string Nome) //construtor exige a entrada do atributo nome
        {nome = Nome;}
    
        public int Id { get; set; }
        public DateTime datanasc { get; set; }
        public string nome { get; set; }
        public bool sexmas { get; set; }

        public virtual void comer()
        {
            Console.WriteLine($"{nome} começou a refeicao");
        }

        public virtual void tomarbanho()
        {
            Console.WriteLine($"{nome} iniciou o banho");
        }

        public abstract void andar();

    }
}