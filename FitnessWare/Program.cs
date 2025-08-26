using FitnessWare.Forms;

namespace FitnessWare
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal do aplicativo.
        /// </summary>
        [STAThread] // Indica que o aplicativo usa modelo de thread STA necess�rio para Windows Forms
        static void Main()
        {
            // Inicializa as configura��es do Windows Forms, como DPI e fonte padr�o
            ApplicationConfiguration.Initialize();

            // ==================== EXECUTA TESTES ====================
            // Chama o TestProgram para testar os Services (Alunos, Treinos, Mensalidades)
            // Os resultados ser�o exibidos no console
            FitnessWare.Testes.TestProgram.Executar();

            // ==================== INICIA O FORMULARIO PRINCIPAL ====================
            // Executa o FormPrincipal da aplica��o
            Application.Run(new FormPrincipal());
        }
    }
}
