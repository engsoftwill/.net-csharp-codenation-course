using System; //    List SortedLIst Dictionary Queue Stack
using System.Collections.Generic;
//list é o tipo de colecao mais adotado no mercado, fortemente tipado; assim como generico
namespace aulacolecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();        //instanciando a lista
            nomes.Add("Willian");
            nomes.Add("Jessica");
            nomes.Add("Doug");
            nomes.Add("Thayna");
            nomes.ForEach(x => {
                x+= "!";
                Console.WriteLine(x);
            });

            SortedList<int,int> dados = new SortedList<int, int>(); //<Tkey,Tvalue>
            dados.Add(5,15);
            dados.Add(1,11);
            dados.Add(2,12);
            dados.Add(4,14);
            dados.Add(3,13);
            Console.WriteLine(dados[1]);//solicitaçao pela chave
        
            Dictionary<string,string>   departamentos = new Dictionary<string, string>();
            departamentos.Add("TI","Tecnologia Da Informacao");
            departamentos.Add("RH","Recursos Humanos");
            departamentos.Add("Mkt","Marketing");

            Console.WriteLine(departamentos["RH"]);

            Queue<int> senhasfila = new Queue<int>();   //first in first out
            senhasfila.Enqueue(1);                      //adiciona o valor 1 na primeira posicao da fila
            senhasfila.Enqueue(7);
            senhasfila.Enqueue(3);
            senhasfila.Enqueue(4);

            senhasfila.Dequeue();                       //remove e exibe o valor na primeira posicao da fila
            Console.WriteLine(senhasfila.Peek());       // exibe o valor na primeira posicao da fila

            Stack<int>  senhaspilha = new Stack<int>(); //LIFO last in first out
            senhaspilha.Push(1);                        //adiciona o valor 1 na primeira posicao da pilha
            senhaspilha.Push(2);
            senhaspilha.Push(3);
            senhaspilha.Push(4);

            senhaspilha.Pop();                          //remove e exibe o valor na primeira posicao da fila
            Console.WriteLine(senhaspilha.Peek());      // exibe o valor na primeira posicao da fila


        }
    }
}
