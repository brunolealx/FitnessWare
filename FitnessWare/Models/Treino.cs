namespace SeuProjeto.Models
{
    public class Treino
    {
        public string NomeAluno { get; set; }
        public string Descricao { get; set; }
        public int DuracaoMinutos { get; set; }

        public Treino(string nomeAluno, string descricao, int duracaoMinutos)
        {
            NomeAluno = nomeAluno;
            Descricao = descricao;
            DuracaoMinutos = duracaoMinutos;
        }
    }
}
