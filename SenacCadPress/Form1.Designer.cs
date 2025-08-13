namespace SenacCadPress
{
    partial class Form1
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
            mensagens = new GroupBox();
            richTextBox1 = new RichTextBox();
            Cadastro = new GroupBox();
            ComprarEImprimir = new GroupBox();
            Nome = new Label();
            CPF = new Label();
            Cadastrar = new Button();
            CampoNome = new TextBox();
            CampoCPF = new TextBox();
            PesquisaCPF = new TextBox();
            CPFdaPesquisa = new Label();
            PesquisarCPFbuttom = new Button();
            QuantidadeImprimir = new NumericUpDown();
            Imprimir = new Button();
            LabelQauntidadeImprimir = new Label();
            LabelComprarImpressao = new Label();
            Comprar25impressao = new Button();
            Comprar50impressão = new Button();
            mensagens.SuspendLayout();
            Cadastro.SuspendLayout();
            ComprarEImprimir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantidadeImprimir).BeginInit();
            SuspendLayout();
            // 
            // mensagens
            // 
            mensagens.Controls.Add(richTextBox1);
            mensagens.Location = new Point(12, 12);
            mensagens.Name = "mensagens";
            mensagens.Size = new Size(245, 426);
            mensagens.TabIndex = 0;
            mensagens.TabStop = false;
            mensagens.Text = "Mensagens";
            mensagens.Enter += groupBox1_Enter;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(233, 398);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(CampoCPF);
            Cadastro.Controls.Add(CampoNome);
            Cadastro.Controls.Add(Cadastrar);
            Cadastro.Controls.Add(CPF);
            Cadastro.Controls.Add(Nome);
            Cadastro.Location = new Point(278, 12);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(510, 159);
            Cadastro.TabIndex = 1;
            Cadastro.TabStop = false;
            Cadastro.Text = "Cadastro";
            // 
            // ComprarEImprimir
            // 
            ComprarEImprimir.Controls.Add(Comprar50impressão);
            ComprarEImprimir.Controls.Add(Comprar25impressao);
            ComprarEImprimir.Controls.Add(LabelComprarImpressao);
            ComprarEImprimir.Controls.Add(LabelQauntidadeImprimir);
            ComprarEImprimir.Controls.Add(Imprimir);
            ComprarEImprimir.Controls.Add(QuantidadeImprimir);
            ComprarEImprimir.Controls.Add(PesquisarCPFbuttom);
            ComprarEImprimir.Controls.Add(CPFdaPesquisa);
            ComprarEImprimir.Controls.Add(PesquisaCPF);
            ComprarEImprimir.Location = new Point(278, 177);
            ComprarEImprimir.Name = "ComprarEImprimir";
            ComprarEImprimir.Size = new Size(510, 261);
            ComprarEImprimir.TabIndex = 2;
            ComprarEImprimir.TabStop = false;
            ComprarEImprimir.Text = "Comprar e Imprimir";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(23, 25);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(23, 70);
            CPF.Name = "CPF";
            CPF.Size = new Size(28, 15);
            CPF.TabIndex = 1;
            CPF.Text = "CPF";
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(23, 117);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(75, 23);
            Cadastrar.TabIndex = 2;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            // 
            // CampoNome
            // 
            CampoNome.Location = new Point(23, 43);
            CampoNome.Name = "CampoNome";
            CampoNome.Size = new Size(438, 23);
            CampoNome.TabIndex = 3;
            // 
            // CampoCPF
            // 
            CampoCPF.Location = new Point(23, 88);
            CampoCPF.Name = "CampoCPF";
            CampoCPF.Size = new Size(438, 23);
            CampoCPF.TabIndex = 4;
            // 
            // PesquisaCPF
            // 
            PesquisaCPF.Location = new Point(23, 37);
            PesquisaCPF.Name = "PesquisaCPF";
            PesquisaCPF.Size = new Size(438, 23);
            PesquisaCPF.TabIndex = 5;
            // 
            // CPFdaPesquisa
            // 
            CPFdaPesquisa.AutoSize = true;
            CPFdaPesquisa.Location = new Point(23, 19);
            CPFdaPesquisa.Name = "CPFdaPesquisa";
            CPFdaPesquisa.Size = new Size(102, 15);
            CPFdaPesquisa.TabIndex = 6;
            CPFdaPesquisa.Text = "Pesquisar por CPF";
            // 
            // PesquisarCPFbuttom
            // 
            PesquisarCPFbuttom.Location = new Point(23, 66);
            PesquisarCPFbuttom.Name = "PesquisarCPFbuttom";
            PesquisarCPFbuttom.Size = new Size(75, 23);
            PesquisarCPFbuttom.TabIndex = 7;
            PesquisarCPFbuttom.Text = "Pesquisar";
            PesquisarCPFbuttom.UseVisualStyleBackColor = true;
            // 
            // QuantidadeImprimir
            // 
            QuantidadeImprimir.Location = new Point(23, 150);
            QuantidadeImprimir.Name = "QuantidadeImprimir";
            QuantidadeImprimir.Size = new Size(120, 23);
            QuantidadeImprimir.TabIndex = 8;
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(23, 179);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(120, 55);
            Imprimir.TabIndex = 9;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = true;
            // 
            // LabelQauntidadeImprimir
            // 
            LabelQauntidadeImprimir.AutoSize = true;
            LabelQauntidadeImprimir.Location = new Point(23, 121);
            LabelQauntidadeImprimir.Name = "LabelQauntidadeImprimir";
            LabelQauntidadeImprimir.Size = new Size(146, 15);
            LabelQauntidadeImprimir.TabIndex = 10;
            LabelQauntidadeImprimir.Text = "Quantidade a ser Impressa";
            // 
            // LabelComprarImpressao
            // 
            LabelComprarImpressao.AutoSize = true;
            LabelComprarImpressao.Location = new Point(292, 121);
            LabelComprarImpressao.Name = "LabelComprarImpressao";
            LabelComprarImpressao.Size = new Size(116, 15);
            LabelComprarImpressao.TabIndex = 11;
            LabelComprarImpressao.Text = "Comprar Impressões";
            // 
            // Comprar25impressao
            // 
            Comprar25impressao.Location = new Point(228, 159);
            Comprar25impressao.Name = "Comprar25impressao";
            Comprar25impressao.Size = new Size(120, 55);
            Comprar25impressao.TabIndex = 12;
            Comprar25impressao.Text = "Comprar 25 Impressões";
            Comprar25impressao.UseVisualStyleBackColor = true;
            Comprar25impressao.Click += button1_Click;
            // 
            // Comprar50impressão
            // 
            Comprar50impressão.Location = new Point(354, 159);
            Comprar50impressão.Name = "Comprar50impressão";
            Comprar50impressão.Size = new Size(120, 55);
            Comprar50impressão.TabIndex = 13;
            Comprar50impressão.Text = "Comprar 50 Impressões";
            Comprar50impressão.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComprarEImprimir);
            Controls.Add(Cadastro);
            Controls.Add(mensagens);
            Name = "Form1";
            Text = "Form1";
            mensagens.ResumeLayout(false);
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            ComprarEImprimir.ResumeLayout(false);
            ComprarEImprimir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantidadeImprimir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox mensagens;
        private RichTextBox richTextBox1;
        private GroupBox Cadastro;
        private GroupBox ComprarEImprimir;
        private TextBox CampoCPF;
        private TextBox CampoNome;
        private Button Cadastrar;
        private Label CPF;
        private Label Nome;
        private Label CPFdaPesquisa;
        private TextBox PesquisaCPF;
        private Button PesquisarCPFbuttom;
        private Button Comprar50impressão;
        private Button Comprar25impressao;
        private Label LabelComprarImpressao;
        private Label LabelQauntidadeImprimir;
        private Button Imprimir;
        private NumericUpDown QuantidadeImprimir;
    }
}
