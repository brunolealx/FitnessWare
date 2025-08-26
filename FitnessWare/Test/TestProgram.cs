using SeuProjeto.Models;
using SeuProjeto.Services;
using System;

namespace FitnessWare.Testes
{
    public static class TestProgram
    {
        public static void Executar()
        {
            // ================== TESTE DE ALUNO ==================
            var alunoService = new AlunoService();

            // Cria alunos usando object initializer
            var aluno1 = new Aluno
            {
                Nome = "Bruno",
                Idade = 25,
                Telefone = "99999-9999",
                Email = "bruno@email.com",
                Endereco = "Rua A, 123"
            };

            var aluno2 = new Aluno
            {
                Nome = "Ana",
                Idade = 30,
                Telefone = "88888-8888",
                Email = "ana@email.com",
                Endereco = "Rua B, 456"
            };

            // Adiciona os alunos no Service
            alunoService.AdicionarAluno(aluno1);
            alunoService.AdicionarAluno(aluno2);

            // Mostra no console a lista de alunos
            Console.WriteLine("=== LISTA DE ALUNOS ===");
            foreach (var aluno in alunoService.ListarAlunos())
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos - Email: {aluno.Email} - Endereço: {aluno.Endereco}");
            }

            // ================== TESTE DE TREINO ==================
            var treinoService = new TreinoService();
            var treino1 = new Treino("Bruno", "Musculação - Peito", 60);
            var treino2 = new Treino("Ana", "Cardio - Corrida", 45);

            treinoService.AdicionarTreino(treino1);
            treinoService.AdicionarTreino(treino2);

            Console.WriteLine("\n=== TREINOS DO BRUNO ===");
            foreach (var treino in treinoService.ListarTreinosPorAluno("Bruno"))
            {
                Console.WriteLine($"{treino.Descricao} - {treino.DuracaoMinutos} minutos");
            }

            // ================== TESTE DE MENSALIDADE ==================
            var mensalidadeService = new MensalidadeService();
            var mensalidade1 = new Mensalidade("Bruno", 150.0m, true);  // paga
            var mensalidade2 = new Mensalidade("Ana", 150.0m, false);   // pendente

            mensalidadeService.RegistrarMensalidade(mensalidade1);
            mensalidadeService.RegistrarMensalidade(mensalidade2);

            Console.WriteLine("\n=== MENSALIDADES PENDENTES ===");
            foreach (var m in mensalidadeService.ListarPendentes())
            {
                Console.WriteLine($"{m.NomeAluno} - R$ {m.Valor}");
            }
        }
    }
}
