namespace LeituraVetores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnVetor1 = new System.Windows.Forms.Button();
            this.btnVetor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerador de números 1° vetor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gerador de números 2° vetor";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(286, 252);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(183, 61);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Gerar soma";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnVetor1
            // 
            this.btnVetor1.Location = new System.Drawing.Point(152, 157);
            this.btnVetor1.Name = "btnVetor1";
            this.btnVetor1.Size = new System.Drawing.Size(213, 45);
            this.btnVetor1.TabIndex = 7;
            this.btnVetor1.Text = "Vetor 1";
            this.btnVetor1.UseVisualStyleBackColor = true;
            this.btnVetor1.Click += new System.EventHandler(this.BtnVetor1_Click);
            // 
            // btnVetor2
            // 
            this.btnVetor2.Location = new System.Drawing.Point(380, 157);
            this.btnVetor2.Name = "btnVetor2";
            this.btnVetor2.Size = new System.Drawing.Size(192, 45);
            this.btnVetor2.TabIndex = 8;
            this.btnVetor2.Text = "Vetor 2";
            this.btnVetor2.UseVisualStyleBackColor = true;
            this.btnVetor2.Click += new System.EventHandler(this.BtnVetor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 451);
            this.Controls.Add(this.btnVetor2);
            this.Controls.Add(this.btnVetor1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnVetor1;
        private System.Windows.Forms.Button btnVetor2;
    }
}

