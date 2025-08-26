using FitnessWare.Models;   // Importa as classes do domínio, como Aluno, Treino, Exercicio
using FitnessWare.Services; // Importa os serviços que manipulam a lógica de negócios (CRUD)
using System;
using System.Collections.Generic;

namespace FitnessWare.Testes
{
    /// <summary>
    /// Classe estática de testes que simula a criação e manipulação de alunos e treinos
    /// sem depender de interface gráfica ou banco de dados.
    /// </summary>
    public static class TestProgram
    {
        /// <summary>
        /// Método principal de execução dos testes.
        /// </summary>
        public static void Executar()
        {
            // ==============================================================
            // 1️⃣ TESTE DE ALUNO
            // ==============================================================
            // Criamos uma instância do serviço de alunos. O serviço funciona
            // como uma camada de abstração entre a lógica de negócios e os dados,
            // mantendo a lista de alunos encapsulada.
            var alunoService = new AlunoService();

            // Criação de objetos Aluno usando Object Initializer.
            // Object Initializer é uma forma elegante de instanciar objetos e
            // inicializar suas propriedades de forma concisa.
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

            // Adiciona os alunos no serviço
            // Isso garante que todos os métodos que acessarem a lista de alunos
            // usem uma fonte consistente (encapsulada pelo serviço).
            alunoService.AdicionarAluno(aluno1);
            alunoService.AdicionarAluno(aluno2);

            // Listagem de alunos no console para validar a criação
            Console.WriteLine("=== LISTA DE ALUNOS ===");
            foreach (var aluno in alunoService.ListarAlunos())
            {
                // String interpolada para exibir informações completas
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos - Email: {aluno.Email} - Endereço: {aluno.Endereco}");
            }

            // ==============================================================
            // 2️⃣ TESTE DE TREINO
            // ==============================================================
            // Cria o serviço de treinos, que funciona como uma camada de controle
            // para manipulação da lista de treinos (inserir, listar, filtrar por aluno, etc.)
            var treinoService = new TreinoService();

            // Criamos objetos Exercicio para cada aluno
            // Cada Exercicio tem nome, quantidade de repetições e status de conclusão.
            // O status Concluido é útil para evoluir o treino e marcar progresso.
            var exercicioBruno = new Exercicio
            {
                Nome = "Musculação - Peito",
                Repeticoes = 60,
                Concluido = false // Inicialmente falso, pois o aluno ainda não fez
            };

            var exercicioAna = new Exercicio
            {
                Nome = "Cardio - Corrida",
                Repeticoes = 45,
                Concluido = false
            };

            // Criação de objetos Treino associando cada aluno a seus exercícios
            // Cada Treino encapsula a relação entre Aluno e a lista de Exercicios
            var treino1 = new Treino
            {
                Aluno = aluno1, // Associação direta com o objeto Aluno
                Exercicios = new List<Exercicio> { exercicioBruno } // Lista permite expansão futura
            };

            var treino2 = new Treino
            {
                Aluno = aluno2,
                Exercicios = new List<Exercicio> { exercicioAna }
            };

            // Adiciona os treinos no serviço de treinos
            // Isso garante que a lista interna seja gerenciada centralmente
            treinoService.AdicionarTreino(treino1);
            treinoService.AdicionarTreino(treino2);

            // Listagem de treinos de um aluno específico
            // Demonstrando como filtrar treinos usando o serviço
            Console.WriteLine("\n=== TREINOS DO BRUNO ===");
            foreach (var treino in treinoService.ListarTreinosPorAluno("Bruno"))
            {
                // Cada treino pode conter múltiplos exercícios
                foreach (var ex in treino.Exercicios)
                {
                    // Exibe o nome do exercício e a quantidade de repetições
                    Console.WriteLine($"{ex.Nome} - {ex.Repeticoes} minutos");
                }
            }

            // ==============================================================
            // 3️⃣ FINALIZAÇÃO DO TESTE
            // ==============================================================
            // Mensagem final para indicar que o teste foi concluído
            Console.WriteLine("\nTeste de alunos e treinos concluído!");
        }
    }
}
