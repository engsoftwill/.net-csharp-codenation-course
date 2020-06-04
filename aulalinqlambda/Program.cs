using System;
using System.Collections.Generic;
using System.Linq;

namespace linqlambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaLambdas lambdas = new ConsultaLambdas();
            lambdas.SelecionarNomesDosAlunos().ForEach( x => 
            {
                Console.WriteLine($"Alunos por lambda {x}");
            });
            lambdas.SelecionarProfessorPorCurso(2).ForEach( x => 
            {
                Console.WriteLine($"lambda professor por curso id 1 : {x}");
            });

            Console.WriteLine("lambda" + lambdas.VerificarSeCursoExiste("AceleraDev C#"));      //lambda esta pesquisando por descricao

            ConsultaLinq linq = new ConsultaLinq();
            lambdas.SelecionarNomesDosAlunos().ForEach( x => 
            {
                Console.WriteLine($"Alunos por linq {x}");
            });
            linq.SelecionarProfessorPorCurso(1).ForEach( x => 
            {
                Console.WriteLine($"linq professor por curso id 1 : {x}");
            });
            Console.WriteLine("linq" + linq.VerificarSeCursoExiste("Curso intensivo de Python")); //linq esta pesquisando por descricao

            var turmaLambda = lambdas.SelecionarDadosDaTurma();
            var turmaLinq = linq.SelecionarDadosDaTurma();
            
        }
    }
}