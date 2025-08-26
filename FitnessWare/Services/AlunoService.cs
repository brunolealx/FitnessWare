using System.Collections.Generic; // Necessário para usar List<T>
using FitnessWare.Models;          // Importa as classes Models do projeto

namespace FitnessWare.Models
{
    public class AlunoService
    {
        // Lista interna que armazena os alunos cadastrados
        private List<Aluno> alunos = new List<Aluno>();

        // Método para adicionar um aluno à lista
        public void AdicionarAluno(Aluno aluno)
        {
            // Adiciona o objeto aluno passado como parâmetro na lista
            alunos.Add(aluno);
        }

        // Método que retorna todos os alunos cadastrados
        public List<Aluno> ListarAlunos()
        {
            // Retorna a lista interna de alunos
            return alunos;
        }

        // Método para procurar um aluno pelo nome
        public Aluno ProcurarAluno(string nome)
        {
            // Busca o primeiro aluno na lista que tenha o nome informado
            return alunos.Find(a => a.Nome == nome);
        }

        // Método que retorna a quantidade de alunos cadastrados
        public int ContarAlunos()
        {
            return alunos.Count; // Count retorna o tamanho da lista
        }
    }
}
