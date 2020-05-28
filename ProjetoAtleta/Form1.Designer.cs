namespace ProjetoAtleta
{
    partial class pessoa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dados = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.datanascimento = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dados
            // 
            this.dados.Location = new System.Drawing.Point(15, 149);
            this.dados.Name = "dados";
            this.dados.Size = new System.Drawing.Size(195, 23);
            this.dados.TabIndex = 0;
            this.dados.Text = "Enviar Dados";
            this.dados.UseVisualStyleBackColor = true;
            this.dados.Click += new System.EventHandler(this.button1_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(15, 178);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(195, 23);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "Calcular Idade";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(110, 11);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 6;
            // 
            // datanascimento
            // 
            this.datanascimento.Location = new System.Drawing.Point(110, 39);
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.Size = new System.Drawing.Size(100, 20);
            this.datanascimento.TabIndex = 7;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(110, 67);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 20);
            this.altura.TabIndex = 8;
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(15, 231);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(195, 20);
            this.idade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso:";
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(110, 95);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 20);
            this.peso.TabIndex = 11;
            // 
            // pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 263);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.datanascimento);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.dados);
            this.Name = "pessoa";
            this.Text = "PESSOA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dados;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox datanascimento;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox peso;
    }
}

