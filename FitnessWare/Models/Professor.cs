namespace FitnessWare.Models
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Professor(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}
