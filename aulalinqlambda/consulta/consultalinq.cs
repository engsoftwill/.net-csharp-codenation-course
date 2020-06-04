using System;
using System.Collections.Generic;
using System.Linq;

namespace linqlambda
{
    public class ConsultaLinq
    {
        private List<Aluno> TabelaAlunos { get; set; }
        private List<Curso> TabelaCursos { get; set; }
        private List<Turma> TabelaTurmas { get; set; }
        private List<Professor> TabelaProfessores { get; set; }
        public ConsultaLinq()
        {
            TabelaAlunos        =   PreenchimentoDeDados.CriarAlunos();
            TabelaCursos        =   PreenchimentoDeDados.CriarCursos();
            TabelaTurmas        =   PreenchimentoDeDados.CriarTurma();
            TabelaProfessores   =   PreenchimentoDeDados.CriarProfessor();
        }
        public List<string> SelecionarNomesDosAlunos()
        {
            return (from tabAlunos in TabelaAlunos 
            select tabAlunos.Nome)
            .ToList();
        }
        public List<string> SelecionarProfessorPorCurso(int idcurso)
        {
            return (from tabProf in TabelaProfessores
            where tabProf.aptoparacursos.Contains(idcurso)
            select tabProf.Nome)
            .ToList();
        }
        public bool VerificarSeCursoExiste(string keyword)
        {
            return (from tabcurso in TabelaCursos
            select tabcurso)
            .Any(x => x.descricao                           //existe algum dentre = any
            .Contains(keyword));
        }

        public object SelecionarDadosDaTurma()
        {
            return (from tabTurma in TabelaTurmas
            join tabProf in TabelaProfessores on tabTurma.idprofessor equals tabProf.id
            select new {Turma = tabTurma , Prof = tabProf})
            .ToList();
        }
    }
}