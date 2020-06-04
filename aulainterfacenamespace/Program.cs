using System;

namespace aulainterfacenamespace //aula interface e namespace professora Thamirys Gameiro curso aceleradevC# Codenation Stone				
{
    class Program
    {
        static void Main(string[] args)
        {
            carro palio = new carro()
            {
                id = 12,
                modelo = "megane"
            };
            gato meow = new gato()
            {
                nome = "meow",
                raca = "persa"
            };
            ventilador turbofan = new ventilador()
            {
                Id = 12,
                marca = "megane"
            };

            palio.emitirsom();
            meow.emitirsom();
            turbofan.emitirsom();
            
            new carro().emitirsom();
            new gato().emitirsom();
            new ventilador().emitirsom();
        }
    }
}
