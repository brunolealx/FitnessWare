namespace FitnessWare.Models
{
    public class Mensalidade
    {
        // Nome do aluno associado a esta mensalidade
        public string NomeAluno { get; set; }

        // Valor da mensalidade
        public decimal Valor { get; set; }

        // Indica se a mensalidade foi paga ou não
        public bool Pago { get; set; }

        // Construtor da classe Mensalidade
        // Inicializa as propriedades com os valores recebidos como parâmetro
        public Mensalidade(string nomeAluno, decimal valor, bool pago)
        {
            NomeAluno = nomeAluno;  // Define o nome do aluno
            Valor = valor;          // Define o valor da mensalidade
            Pago = pago;            // Define se está paga ou não
        }
    }
}
