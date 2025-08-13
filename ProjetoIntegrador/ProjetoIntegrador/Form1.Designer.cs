namespace ProjetoIntegrador
{
    partial class FormNomeAluno
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
            NomeAluno = new Label();
            textBox1 = new TextBox();
            CadastrarAluno = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            Saldo = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            button6 = new Button();
            CadastrarAluno.SuspendLayout();
            Saldo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // NomeAluno
            // 
            NomeAluno.AutoSize = true;
            NomeAluno.Location = new Point(6, 18);
            NomeAluno.Name = "NomeAluno";
            NomeAluno.Size = new Size(40, 15);
            NomeAluno.TabIndex = 0;
            NomeAluno.Text = "Nome";
            NomeAluno.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Cross;
            textBox1.Location = new Point(6, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 23);
            textBox1.TabIndex = 1;
            // 
            // CadastrarAluno
            // 
            CadastrarAluno.Controls.Add(textBox2);
            CadastrarAluno.Controls.Add(label1);
            CadastrarAluno.Controls.Add(button1);
            CadastrarAluno.Controls.Add(NomeAluno);
            CadastrarAluno.Controls.Add(textBox1);
            CadastrarAluno.Location = new Point(258, 12);
            CadastrarAluno.Name = "CadastrarAluno";
            CadastrarAluno.Size = new Size(485, 148);
            CadastrarAluno.TabIndex = 2;
            CadastrarAluno.TabStop = false;
            CadastrarAluno.Text = "Cadastro de Aluno";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.Cross;
            textBox2.Location = new Point(6, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "CPF";
            // 
            // button1
            // 
            button1.Location = new Point(147, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Saldo
            // 
            Saldo.Controls.Add(button6);
            Saldo.Controls.Add(richTextBox1);
            Saldo.Location = new Point(12, 12);
            Saldo.Name = "Saldo";
            Saldo.Size = new Size(240, 426);
            Saldo.TabIndex = 3;
            Saldo.TabStop = false;
            Saldo.Text = "Mensagem";
            Saldo.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 15);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(228, 348);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(258, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 272);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imprimir e Adicionar";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // button4
            // 
            button4.Location = new Point(299, 187);
            button4.Name = "button4";
            button4.Size = new Size(171, 62);
            button4.TabIndex = 6;
            button4.Text = "Adicionar 50 impressões";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 149);
            button2.Name = "button2";
            button2.Size = new Size(171, 45);
            button2.TabIndex = 5;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.Cross;
            textBox3.Location = new Point(51, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // button3
            // 
            button3.Location = new Point(299, 36);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(299, 111);
            button5.Name = "button5";
            button5.Size = new Size(171, 63);
            button5.TabIndex = 7;
            button5.Text = "Adicionar 25 impressões";
            button5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(51, 111);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(6, 369);
            button6.Name = "button6";
            button6.Size = new Size(228, 51);
            button6.TabIndex = 6;
            button6.Text = "Exibir saldo de todos os alunos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FormNomeAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(groupBox1);
            Controls.Add(Saldo);
            Controls.Add(CadastrarAluno);
            Cursor = Cursors.IBeam;
            Name = "FormNomeAluno";
            Text = "Form1";
            CadastrarAluno.ResumeLayout(false);
            CadastrarAluno.PerformLayout();
            Saldo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label NomeAluno;
        private TextBox textBox1;
        private GroupBox CadastrarAluno;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private GroupBox Saldo;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button button4;
        private Button button2;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private Button button6;
    }
}
