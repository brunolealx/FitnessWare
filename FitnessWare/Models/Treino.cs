using System.Collections.Generic;


namespace FitnessWare.Models
{
    public class Treino
    {
        public Aluno Aluno { get; set; }
        public List<Exercicio> Exercicios { get; set; } = new List<Exercicio>();
    }
}
