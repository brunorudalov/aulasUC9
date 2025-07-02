namespace exercio3
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
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.btm = new System.Windows.Forms.Button();
            this.resul1 = new System.Windows.Forms.Label();
            this.resul2 = new System.Windows.Forms.Label();
            this.resulFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valor1
            // 
            this.Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor1.Location = new System.Drawing.Point(156, 82);
            this.Valor1.Multiline = true;
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(118, 36);
            this.Valor1.TabIndex = 0;
            this.Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Valor2
            // 
            this.Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor2.Location = new System.Drawing.Point(521, 82);
            this.Valor2.Multiline = true;
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(118, 36);
            this.Valor2.TabIndex = 1;
            this.Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btm
            // 
            this.btm.BackColor = System.Drawing.Color.Gold;
            this.btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm.Location = new System.Drawing.Point(370, 216);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(105, 32);
            this.btm.TabIndex = 2;
            this.btm.Text = "Calcular";
            this.btm.UseVisualStyleBackColor = false;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // resul1
            // 
            this.resul1.AutoSize = true;
            this.resul1.BackColor = System.Drawing.Color.Orange;
            this.resul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resul1.Location = new System.Drawing.Point(239, 297);
            this.resul1.Name = "resul1";
            this.resul1.Size = new System.Drawing.Size(131, 25);
            this.resul1.TabIndex = 3;
            this.resul1.Text = "Resultado1";
            this.resul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resul2
            // 
            this.resul2.AutoSize = true;
            this.resul2.BackColor = System.Drawing.Color.Orange;
            this.resul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resul2.Location = new System.Drawing.Point(486, 297);
            this.resul2.Name = "resul2";
            this.resul2.Size = new System.Drawing.Size(131, 25);
            this.resul2.TabIndex = 4;
            this.resul2.Text = "Resultado2";
            this.resul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resulFinal
            // 
            this.resulFinal.AutoSize = true;
            this.resulFinal.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.resulFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulFinal.Location = new System.Drawing.Point(342, 353);
            this.resulFinal.Name = "resulFinal";
            this.resulFinal.Size = new System.Drawing.Size(177, 25);
            this.resulFinal.TabIndex = 5;
            this.resulFinal.Text = "Resultado Final";
            this.resulFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resulFinal);
            this.Controls.Add(this.resul2);
            this.Controls.Add(this.resul1);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Label resul1;
        private System.Windows.Forms.Label resul2;
        private System.Windows.Forms.Label resulFinal;
    }
}

