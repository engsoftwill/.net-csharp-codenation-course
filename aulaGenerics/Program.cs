using System; 

namespace aulaGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            try //tratamento de erro
            {
            
            carrousado      palio       =   new carrousado();
            desenvsoft      dev         =   new desenvsoft();
            kilobuffet      restaurante =   new kilobuffet();
            calculogenerico<carrousado> calcpalio      = new calculogenerico<carrousado>();
            calculogenerico<desenvsoft> calcdev     = new calculogenerico<desenvsoft>();
            calculogenerico<kilobuffet> calcrest     = new calculogenerico<kilobuffet>();
            calcpalio.calcularvalorunitario(palio);
            calcdev.calcularvalorunitario(dev);
            calcrest.calcularvalorunitario(restaurante);
            Console.WriteLine($"O valor final do carro é {palio.ValorFinal}");
            Console.WriteLine($"O valor final da hora da carro é {dev.ValorFinal}");
            Console.WriteLine($"O valor final do kilo na Lilegal é {restaurante.ValorFinal}");
            //**************************
            //As linhas 23 e 24 se referem ao método de extensão.
            var texto = "Olá seu nome é Willian   ???? Se sim... o Sobrenome é Xavier";
            Console.WriteLine($"A frase possui {texto.ContadorDePalavras()} palavras");
            string erro = null;
            // erro.ContadorDePalavras(); basta descomentar para ver o try catch com o erro
            }
            catch (Exception ex)
            {
                //gravar log de erro ex.Message
                Console.WriteLine($"deu ruim, entre em contato com o dev");
            }
            finally
            {
                Console.WriteLine("isso ocorre independente de dar erro ou nao");
            }
        }
    }
}