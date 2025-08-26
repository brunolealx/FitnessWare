namespace SeuProjeto.Models
{
    // Representa um aluno cadastrado no sistema
    public class Aluno
    {
        // Nome completo do aluno
        public string Nome { get; set; }

        // Idade (número inteiro)
        public int Idade { get; set; }

        // Telefone de contato
        public string Telefone { get; set; }

        // E-mail do aluno
        public string Email { get; set; }

        // Endereço (rua, número, bairro, etc.)
        public string Endereco { get; set; }

        // Construtor com parâmetros: para criar o objeto já preenchido de uma vez
        public Aluno(string nome, int idade, string telefone, string email, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }

        // Construtor vazio: útil para popular via inicialização por propriedades (object initializer)
        public Aluno() { }
    }
}
