namespace Trabalho9_10Sexta
{
    partial class Form2
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
            this.Botao1 = new System.Windows.Forms.Button();
            this.Texto1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao1.Location = new System.Drawing.Point(276, 101);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(125, 48);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Clique";
            this.Botao1.UseVisualStyleBackColor = true;
            this.Botao1.Click += new System.EventHandler(this.Botao1_Click);
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.Font = new System.Drawing.Font("Gabriola", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.Location = new System.Drawing.Point(267, 183);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(120, 50);
            this.Texto1.TabIndex = 1;
            this.Texto1.Text = "Mensagem";
            this.Texto1.Click += new System.EventHandler(this.Texto1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.Botao1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.Label Texto1;
    }
}