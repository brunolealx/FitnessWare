using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessWare.Forms
{
    public partial class FormAlunos : Form
    {
        public FormAlunos()
        {
            InitializeComponent();
        }

        private void FormAlunos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um diálogo para o usuário escolher um arquivo
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Define o título da janela
                ofd.Title = "Selecione uma foto";

                // Define quais tipos de arquivos podem ser selecionados
                ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                // Mostra a janela de seleção e verifica se o usuário clicou em "OK"
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Carrega a imagem selecionada no PictureBox
                    pbFoto.Image = Image.FromFile(ofd.FileName);

                    // Ajusta a imagem para preencher o PictureBox sem distorcer muito
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
