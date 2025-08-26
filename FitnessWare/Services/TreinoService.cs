using System.Collections.Generic;
using FitnessWare.Models;

namespace FitnessWare.Services
{
    public class TreinoService
    {
        // Lista interna que armazena todos os treinos
        private List<Treino> treinos = new List<Treino>();

        // Adiciona um treino à lista
        public void AdicionarTreino(Treino treino)
        {
            treinos.Add(treino); // Adiciona o treino recebido como parâmetro
        }

        // Lista todos os treinos
        public List<Treino> ListarTreinos()
        {
            return treinos; // Retorna a lista interna de treinos
        }

        // Lista treinos de um aluno específico
        public List<Treino> ListarTreinosPorAluno(string nomeAluno)
        {
            // Corrigido: acessa o nome do aluno dentro do objeto Aluno
            return treinos.FindAll(t => t.Aluno.Nome == nomeAluno);
        }
    }
}
