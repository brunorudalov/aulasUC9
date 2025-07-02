namespace minicalcu
{
    partial class FrmPri
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
            this.valor1 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.Location = new System.Drawing.Point(226, 77);
            this.valor1.Multiline = true;
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(133, 38);
            this.valor1.TabIndex = 0;
            this.valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor1.TextChanged += new System.EventHandler(this.numero1_TextChanged);
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(226, 213);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 51);
            this.soma.TabIndex = 2;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(458, 213);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 51);
            this.multi.TabIndex = 3;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(339, 213);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 51);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.button3_Click);
            // 
            // divi
            // 
            this.divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divi.Location = new System.Drawing.Point(564, 213);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(75, 51);
            this.divi.TabIndex = 5;
            this.divi.Text = "/";
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.divi_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.BackColor = System.Drawing.Color.Peru;
            this.lblresul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresul.Location = new System.Drawing.Point(367, 329);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(146, 33);
            this.lblresul.TabIndex = 6;
            this.lblresul.Text = "Resultado";
            // 
            // valor2
            // 
            this.valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.Location = new System.Drawing.Point(467, 77);
            this.valor2.Multiline = true;
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(133, 38);
            this.valor2.TabIndex = 7;
            this.valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valor2.TextChanged += new System.EventHandler(this.valor2_TextChanged);
            // 
            // FrmPri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.valor1);
            this.Name = "FrmPri";
            this.Text = "calcul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.TextBox valor2;
    }
}

