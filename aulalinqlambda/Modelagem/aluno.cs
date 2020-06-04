namespace linqlambda
{
    public class Aluno : Pessoa
    {
        public bool aprovado { get; set; }
        public decimal media { get; set; }
        public int Faltas { get; set; }
    }
}