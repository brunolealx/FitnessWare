using FitnessWare.Forms;

namespace FitnessWare
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            using (FormAlunos formAlunos = new FormAlunos())
            {
                formAlunos.ShowDialog(); // modal: o usuário fecha o form antes de voltar
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fecha todo o aplicativo
            Application.Exit();
        }
    }
}
