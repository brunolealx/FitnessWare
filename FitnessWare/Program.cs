using FitnessWare.Forms;

namespace FitnessWare
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal do aplicativo.
        /// </summary>
        [STAThread] // Indica que o aplicativo usa modelo de thread STA necessário para Windows Forms
        static void Main()
        {
            // Inicializa as configurações do Windows Forms, como DPI e fonte padrão
            ApplicationConfiguration.Initialize();

            // ==================== EXECUTA TESTES ====================
            // Chama o TestProgram para testar os Services (Alunos, Treinos, Mensalidades)
            // Os resultados serão exibidos no console
            FitnessWare.Testes.TestProgram.Executar();

            // ==================== INICIA O FORMULARIO PRINCIPAL ====================
            // Executa o FormPrincipal da aplicação
            Application.Run(new FormPrincipal());
        }
    }
}
