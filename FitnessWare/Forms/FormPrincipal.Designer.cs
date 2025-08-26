namespace FitnessWare
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnAlunos = new Button();
            btnFechar = new Button();
            btnTreinos = new Button();
            btnFaturas = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new Point(251, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAlunos
            // 
            btnAlunos.Location = new Point(367, 293);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(75, 23);
            btnAlunos.TabIndex = 1;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = true;
            btnAlunos.Click += btnAlunos_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(367, 409);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnTreinos
            // 
            btnTreinos.Location = new Point(367, 322);
            btnTreinos.Name = "btnTreinos";
            btnTreinos.Size = new Size(75, 23);
            btnTreinos.TabIndex = 3;
            btnTreinos.Text = "Treinos";
            btnTreinos.UseVisualStyleBackColor = true;
            btnTreinos.Click += button1_Click;
            // 
            // btnFaturas
            // 
            btnFaturas.Location = new Point(367, 351);
            btnFaturas.Name = "btnFaturas";
            btnFaturas.Size = new Size(75, 23);
            btnFaturas.TabIndex = 4;
            btnFaturas.Text = "Faturas";
            btnFaturas.UseVisualStyleBackColor = true;
            btnFaturas.Click += this.btnFaturas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(367, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Painel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(367, 380);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnFaturas);
            Controls.Add(btnTreinos);
            Controls.Add(btnFechar);
            Controls.Add(btnAlunos);
            Controls.Add(pictureBox1);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAlunos;
        private Button btnFechar;
        private Button btnTreinos;
        private Button btnFaturas;
        private Button button1;
        private Button button2;
    }
}
