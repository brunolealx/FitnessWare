using SeuProjeto.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessWare.Forms
{
    public partial class FormAlunos : Form
    {
        public FormAlunos()
        {
            InitializeComponent();
        }

        // Evento disparado ao carregar o Form
        private void FormAlunos_Load(object sender, EventArgs e)
        {

        }

        // ------------------------------
        // Botão Enviar Foto
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma foto";
                ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(ofd.FileName);
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // ------------------------------
        // Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação simples: Nome não vazio e Idade preenchida
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar objeto Aluno com os dados do Form
            Aluno novoAluno = new Aluno
            {
                Nome = txtNome.Text.Trim(),
                Idade = (int)txtIdade.Value,
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Endereco = txtEndereco.Text.Trim()
            };
            // Adiciona o aluno no DataGridView
            dgvAlunos.Rows.Add(
                novoAluno.Nome,
                novoAluno.Idade,
                novoAluno.Telefone,
                novoAluno.Email,
                novoAluno.Endereco
            );
            // Confirmação
            MessageBox.Show($"Aluno {novoAluno.Nome} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar campos
            LimparCampos();
        }

        // ------------------------------
        // Botão Cancelar
   

        // ------------------------------
        // Limpar campos do Form
        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Value = txtIdade.Minimum; // NumericUpDown não tem Clear
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            pbFoto.Image = null;
        }

        // ------------------------------
        // Eventos gerados pelo Designer (podem ficar vazios)
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            // Limpa os campos antes de fechar, opcional
            LimparCampos();

            // Fecha o FormAlunos, voltando para o Form principal
            this.Close();
        }
    }
}
