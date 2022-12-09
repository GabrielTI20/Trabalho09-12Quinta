namespace Trabalho9_10Sexta
{
    partial class Form3
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
            this.Botao2 = new System.Windows.Forms.Button();
            this.Botao3 = new System.Windows.Forms.Button();
            this.Mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.BackColor = System.Drawing.Color.Gray;
            this.Botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao1.ForeColor = System.Drawing.Color.White;
            this.Botao1.Location = new System.Drawing.Point(51, 40);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(109, 34);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Dia";
            this.Botao1.UseVisualStyleBackColor = false;
            this.Botao1.Click += new System.EventHandler(this.Botao1_Click);
            // 
            // Botao2
            // 
            this.Botao2.BackColor = System.Drawing.Color.Gray;
            this.Botao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao2.ForeColor = System.Drawing.Color.White;
            this.Botao2.Location = new System.Drawing.Point(51, 116);
            this.Botao2.Name = "Botao2";
            this.Botao2.Size = new System.Drawing.Size(109, 34);
            this.Botao2.TabIndex = 1;
            this.Botao2.Text = "Mês";
            this.Botao2.UseVisualStyleBackColor = false;
            this.Botao2.Click += new System.EventHandler(this.Botao2_Click);
            // 
            // Botao3
            // 
            this.Botao3.BackColor = System.Drawing.Color.Gray;
            this.Botao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao3.ForeColor = System.Drawing.Color.White;
            this.Botao3.Location = new System.Drawing.Point(51, 188);
            this.Botao3.Name = "Botao3";
            this.Botao3.Size = new System.Drawing.Size(109, 35);
            this.Botao3.TabIndex = 2;
            this.Botao3.Text = "Ano";
            this.Botao3.UseVisualStyleBackColor = false;
            this.Botao3.Click += new System.EventHandler(this.Botao3_Click);
            // 
            // Mensagem1
            // 
            this.Mensagem1.AutoSize = true;
            this.Mensagem1.BackColor = System.Drawing.Color.Gray;
            this.Mensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem1.ForeColor = System.Drawing.Color.White;
            this.Mensagem1.Location = new System.Drawing.Point(252, 295);
            this.Mensagem1.Name = "Mensagem1";
            this.Mensagem1.Size = new System.Drawing.Size(76, 25);
            this.Mensagem1.TabIndex = 3;
            this.Mensagem1.Text = "label1";
            this.Mensagem1.Click += new System.EventHandler(this.Mensagem1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mensagem1);
            this.Controls.Add(this.Botao3);
            this.Controls.Add(this.Botao2);
            this.Controls.Add(this.Botao1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.Button Botao2;
        private System.Windows.Forms.Button Botao3;
        private System.Windows.Forms.Label Mensagem1;
    }
}