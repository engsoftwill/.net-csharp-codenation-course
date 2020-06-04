using System;
using System.Collections.Generic;
namespace linqlambda
{
    public static class PreenchimentoDeDados
    {
        public static List<Aluno> CriarAlunos()                 //funcao da classe é criar objetos para o programa
        {
            return new List<Aluno>()                           //método para criar lista de alunos
            {
                new Aluno()
                {
                    id = 1,
                    Nome = "Will",
                    Telefone = "99999999",
                    email = "will@will.com",
                    DataNasc = new DateTime(1990,10,15)
                },
                new Aluno()
                {
                    id = 2,
                    Nome = "Jess",
                    Telefone = "99999998",
                    email = "jess@will.com",
                    DataNasc = new DateTime(1995,05,06)
                },

            };
        }
        public static List<Curso> CriarCursos()                 //funcao da classe é criar objetos para o programa
        {
            return new List<Curso>()                           //método para criar lista de alunos
            {
                new Curso()
                {
                    id = 1,
                    nomecurso = "AceleraDev C#",
                    descricao = "Curso intensivo de C#",
                },
                new Curso()
                {
                    id = 2,
                    nomecurso = "AceleraDev Python",
                    descricao = "Curso intensivo de Python",
                },

            };
        }
        public static List<Professor> CriarProfessor()                 //funcao da classe é criar objetos para o programa
        {
            return new List<Professor>()                           //método para criar lista de alunos
            {
                new Professor()
                {
                    id = 1,
                    Nome = "Dolores",
                    Telefone = "111111111",
                    email = "dolores@wstwld.com",
                    DataNasc = new DateTime(1970,05,06),
                    aptoparacursos = new List<int>(){1}
                
                },
                new Professor()
                {
                    id = 2,
                    Nome = "Bernard",
                    Telefone = "222222222",
                    email = "bernard@wstwld.com",
                    DataNasc = new DateTime(1968,05,06),
                    aptoparacursos = new List<int>(){1,2}
                },
            };
        }
        public static List<Turma> CriarTurma()                 //funcao da classe é criar objetos para o programa
        {
            return new List<Turma>()                           //método para criar lista de alunos
            {
                new Turma()
                {
                    id = 1,
                    alunos = new List<int>() {1,2},
                    idcurso = 1,
                    idprofessor = 1,
                    nometurma = "Turma de C#"
                },
            };
        }
    }
}