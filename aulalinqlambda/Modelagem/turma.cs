using System;
using System.Collections.Generic;

namespace linqlambda
{
    public class Turma
    {
        public int id { get; set; }
        public string nometurma { get; set; }
        public int idcurso { get; set; }
        public int idprofessor { get; set; }
        public List<int> alunos { get; set; }
    }
}