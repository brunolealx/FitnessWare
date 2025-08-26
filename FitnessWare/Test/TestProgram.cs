// Importa as classes Models (Aluno, Treino, Mensalidade) do projeto
using SeuProjeto.Models;

// Importa os Services que gerenciam a lógica dos Models
using SeuProjeto.Services;

// Importa funcionalidades do System, como Console.WriteLine
using System;

namespace FitnessWare.Testes
{
    // Classe estática que serve para testar os Services do projeto
    public static class TestProgram
    {
        // Método principal que executa todos os testes
        public static void Executar()
        {
            // ================== TESTE DE ALUNO ==================

            // Cria o Service de Alunos, que gerencia a lista interna de alunos
            var alunoService = new AlunoService();

            // Cria objetos Aluno com nome, idade, telefone e situação da mensalidade
            var aluno1 = new Aluno("Bruno", 25, "99999-9999", true);   // aluno com mensalidade em dia
            var aluno2 = new Aluno("Ana", 30, "88888-8888", false);    // aluno com mensalidade pendente

            // Adiciona os alunos criados no Service
            alunoService.AdicionarAluno(aluno1);
            alunoService.AdicionarAluno(aluno2);

            // Mostra no console a lista de todos os alunos cadastrados
            Console.WriteLine("=== LISTA DE ALUNOS ===");
            foreach (var aluno in alunoService.ListarAlunos())
            {
                // Exibe nome, idade e situação da mensalidade de cada aluno
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos - Mensalidade em dia: {aluno.MensalidadeEmDia}");
            }

            // ================== TESTE DE TREINO ==================

            // Cria o Service de Treinos, que gerencia os treinos dos alunos
            var treinoService = new TreinoService();

            // Cria objetos Treino associando a um aluno, descrição do treino e duração em minutos
            var treino1 = new Treino("Bruno", "Musculação - Peito", 60);
            var treino2 = new Treino("Ana", "Cardio - Corrida", 45);

            // Adiciona os treinos no Service
            treinoService.AdicionarTreino(treino1);
            treinoService.AdicionarTreino(treino2);

            // Lista os treinos do aluno "Bruno"
            Console.WriteLine("\n=== TREINOS DO BRUNO ===");
            foreach (var treino in treinoService.ListarTreinosPorAluno("Bruno"))
            {
                // Exibe a descrição do treino e a duração
                Console.WriteLine($"{treino.Descricao} - {treino.DuracaoMinutos} minutos");
            }

            // ================== TESTE DE MENSALIDADE ==================

            // Cria o Service de Mensalidades, que gerencia pagamentos
            var mensalidadeService = new MensalidadeService();

            // Cria objetos Mensalidade com nome do aluno, valor e status de pagamento
            var mensalidade1 = new Mensalidade("Bruno", 150.0m, true);   // já paga
            var mensalidade2 = new Mensalidade("Ana", 150.0m, false);    // pendente

            // Adiciona as mensalidades no Service
            mensalidadeService.RegistrarMensalidade(mensalidade1);
            mensalidadeService.RegistrarMensalidade(mensalidade2);

            // Lista apenas as mensalidades que estão pendentes
            Console.WriteLine("\n=== MENSALIDADES PENDENTES ===");
            foreach (var m in mensalidadeService.ListarPendentes())
            {
                // Exibe o nome do aluno e o valor da mensalidade pendente
                Console.WriteLine($"{m.NomeAluno} - R$ {m.Valor}");
            }
        }
    }
}
