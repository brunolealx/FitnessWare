namespace SeuProjeto.Models
{
    public class Aluno
    {
        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public bool MensalidadeEmDia { get; set; }

        // Construtor
        public Aluno(string nome, int idade, string telefone, bool mensalidadeEmDia)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
            MensalidadeEmDia = mensalidadeEmDia;
        }
    }
}
