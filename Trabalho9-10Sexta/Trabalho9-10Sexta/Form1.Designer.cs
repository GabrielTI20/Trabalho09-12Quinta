namespace Trabalho9_10Sexta
{
    partial class Form1
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
            this.Botao1 = new System.Windows.Forms.Button();
            this.Botao2 = new System.Windows.Forms.Button();
            this.Texto1 = new System.Windows.Forms.Label();
            this.Texto2 = new System.Windows.Forms.Label();
            this.Digite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao1.Location = new System.Drawing.Point(132, 189);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(151, 34);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Comun";
            this.Botao1.UseVisualStyleBackColor = true;
            this.Botao1.Click += new System.EventHandler(this.Botao1_Click);
            // 
            // Botao2
            // 
            this.Botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao2.Location = new System.Drawing.Point(338, 189);
            this.Botao2.Name = "Botao2";
            this.Botao2.Size = new System.Drawing.Size(152, 34);
            this.Botao2.TabIndex = 1;
            this.Botao2.Text = "Diferente";
            this.Botao2.UseVisualStyleBackColor = true;
            this.Botao2.Click += new System.EventHandler(this.Botao2_Click);
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.Location = new System.Drawing.Point(129, 90);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(182, 25);
            this.Texto1.TabIndex = 2;
            this.Texto1.Text = "Digite um nome:";
            // 
            // Texto2
            // 
            this.Texto2.AutoSize = true;
            this.Texto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto2.Location = new System.Drawing.Point(131, 281);
            this.Texto2.Name = "Texto2";
            this.Texto2.Size = new System.Drawing.Size(114, 25);
            this.Texto2.TabIndex = 3;
            this.Texto2.Text = "O nome...";
            // 
            // Digite
            // 
            this.Digite.Location = new System.Drawing.Point(136, 144);
            this.Digite.Name = "Digite";
            this.Digite.Size = new System.Drawing.Size(151, 20);
            this.Digite.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Digite);
            this.Controls.Add(this.Texto2);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.Botao2);
            this.Controls.Add(this.Botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.Button Botao2;
        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.Label Texto2;
        private System.Windows.Forms.TextBox Digite;
    }
}

