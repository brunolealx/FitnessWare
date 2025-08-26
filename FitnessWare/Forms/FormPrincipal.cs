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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            // Aqui você coloca o que quer que aconteça ao clicar no botão
            MessageBox.Show("Botão Faturas clicado!");
        }
    }

}
