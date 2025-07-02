namespace exer5
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
            this.txtlados = new System.Windows.Forms.TextBox();
            this.CalcularBtm = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlados
            // 
            this.txtlados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlados.Location = new System.Drawing.Point(123, 70);
            this.txtlados.Multiline = true;
            this.txtlados.Name = "txtlados";
            this.txtlados.Size = new System.Drawing.Size(151, 47);
            this.txtlados.TabIndex = 0;
            this.txtlados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcularBtm
            // 
            this.CalcularBtm.Location = new System.Drawing.Point(160, 165);
            this.CalcularBtm.Name = "CalcularBtm";
            this.CalcularBtm.Size = new System.Drawing.Size(92, 43);
            this.CalcularBtm.TabIndex = 1;
            this.CalcularBtm.Text = "Calcular";
            this.CalcularBtm.UseVisualStyleBackColor = true;
            this.CalcularBtm.Click += new System.EventHandler(this.CalcularBtm_Click);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.BackColor = System.Drawing.Color.Red;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(165, 298);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(75, 31);
            this.lblResul.TabIndex = 2;
            this.lblResul.Text = "Area";
            this.lblResul.Click += new System.EventHandler(this.lblResul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 498);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.CalcularBtm);
            this.Controls.Add(this.txtlados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlados;
        private System.Windows.Forms.Button CalcularBtm;
        private System.Windows.Forms.Label lblResul;
    }
}

