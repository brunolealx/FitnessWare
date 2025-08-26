namespace FitnessWare.Forms
{
    partial class FormTreino
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
            cmbAlunos = new ComboBox();
            label1 = new Label();
            ctrBoxTreino = new NumericUpDown();
            pictureBox1 = new PictureBox();
            lblRepeticao = new Label();
            checkBox1 = new CheckBox();
            lblTituloTreino = new Label();
            ((System.ComponentModel.ISupportInitialize)ctrBoxTreino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbAlunos
            // 
            cmbAlunos.FormattingEnabled = true;
            cmbAlunos.Location = new Point(12, 38);
            cmbAlunos.Name = "cmbAlunos";
            cmbAlunos.Size = new Size(121, 23);
            cmbAlunos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 14);
            label1.TabIndex = 1;
            label1.Text = "Aluno";
            // 
            // ctrBoxTreino
            // 
            ctrBoxTreino.Location = new Point(281, 256);
            ctrBoxTreino.Name = "ctrBoxTreino";
            ctrBoxTreino.Size = new Size(34, 23);
            ctrBoxTreino.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Supino;
            pictureBox1.Location = new Point(158, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblRepeticao
            // 
            lblRepeticao.AutoSize = true;
            lblRepeticao.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepeticao.ForeColor = SystemColors.Control;
            lblRepeticao.Location = new Point(158, 258);
            lblRepeticao.Name = "lblRepeticao";
            lblRepeticao.Size = new Size(79, 14);
            lblRepeticao.TabIndex = 4;
            lblRepeticao.Text = "Repetições";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(158, 19);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblTituloTreino
            // 
            lblTituloTreino.AutoSize = true;
            lblTituloTreino.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTreino.ForeColor = SystemColors.Control;
            lblTituloTreino.Location = new Point(179, 18);
            lblTituloTreino.Name = "lblTituloTreino";
            lblTituloTreino.Size = new Size(136, 18);
            lblTituloTreino.TabIndex = 6;
            lblTituloTreino.Text = "Supino Sentado";
            // 
            // FormTreino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloTreino);
            Controls.Add(checkBox1);
            Controls.Add(lblRepeticao);
            Controls.Add(pictureBox1);
            Controls.Add(ctrBoxTreino);
            Controls.Add(label1);
            Controls.Add(cmbAlunos);
            Name = "FormTreino";
            Text = "FormTreino";
            Load += FormTreino_Load;
            ((System.ComponentModel.ISupportInitialize)ctrBoxTreino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlunos;
        private Label label1;
        private NumericUpDown ctrBoxTreino;
        private PictureBox pictureBox1;
        private Label lblRepeticao;
        private CheckBox checkBox1;
        private Label lblTituloTreino;
    }
}