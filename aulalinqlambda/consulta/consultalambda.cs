using System;
using System.Collections.Generic;
using System.Linq;

namespace linqlambda
{
    public class ConsultaLambdas
    {
        private List<Aluno> TabelaAlunos { get; set; }
        private List<Curso> TabelaCursos { get; set; }
        private List<Turma> TabelaTurmas { get; set; }
        private List<Professor> TabelaProfessores { get; set; }
        public ConsultaLambdas()
        {
            TabelaAlunos        =   PreenchimentoDeDados.CriarAlunos();
            TabelaCursos        =   PreenchimentoDeDados.CriarCursos();
            TabelaTurmas        =   PreenchimentoDeDados.CriarTurma();
            TabelaProfessores   =   PreenchimentoDeDados.CriarProfessor();
        }
        public List<string> SelecionarNomesDosAlunos()
        {
            return TabelaAlunos.Select(x=> x.Nome).ToList(); //meétodo Select do system.lynq pega da coleção TabelaAlunos o campo Nome
        }
        public List<string> SelecionarProfessorPorCurso(int idcurso)
        {
            return TabelaProfessores
            .Where(x => x.aptoparacursos.Contains(idcurso))    //condicional para a minha consulta neste caso os que cotenham o idcurso selecionado
            .Select(x=> x.Nome).ToList();
        }
        public bool  VerificarSeCursoExiste(string palavrachave)
        {
            return TabelaCursos.Any(x => x.nomecurso.Contains(palavrachave)); //verifica se alguem corresponde ao condicional informado
        }
        public object SelecionarDadosDaTurma()
        {
            return TabelaTurmas.Join(
                TabelaProfessores,
                turma => turma.idprofessor, //id.professor eh a chave estrangeira
                prof => prof.id,            //chave primaria , por meio desta ele ira trazer a informação desejada
                (turma,prof) => new {Turma=turma, Prof=prof}); //propriedade Turma do tipo turma e Prof do tipo prof
        }
    }
}