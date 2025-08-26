namespace FitnessWare.Forms
{
    partial class FormAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunos));
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            txtIdade = new NumericUpDown();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            pbFoto = new PictureBox();
            button1 = new Button();
            cmbStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(374, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(86, 41);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(53, 23);
            txtIdade.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(87, 70);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(373, 23);
            txtTelefone.TabIndex = 3;
            txtTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(86, 128);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(374, 23);
            txtEndereco.TabIndex = 5;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(12, 212);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(100, 120);
            pbFoto.TabIndex = 6;
            pbFoto.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 338);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Enviar Foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(339, 212);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 14);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 14);
            label2.TabIndex = 10;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(69, 14);
            label3.TabIndex = 11;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(54, 14);
            label4.TabIndex = 12;
            label4.Text = "E-mail:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(73, 14);
            label6.TabIndex = 14;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(279, 215);
            label7.Name = "label7";
            label7.Size = new Size(54, 14);
            label7.TabIndex = 15;
            label7.Text = "Status:";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 386);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStatus);
            Controls.Add(button1);
            Controls.Add(pbFoto);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "FormAlunos";
            Text = "FormAlunos";
            Load += FormAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNome;
        private NumericUpDown txtIdade;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private PictureBox pbFoto;
        private Button button1;
        private ComboBox cmbStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}