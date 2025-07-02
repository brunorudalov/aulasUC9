namespace exe6
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.btm1 = new System.Windows.Forms.Button();
            this.salariolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(62, 51);
            this.txtvalor.Multiline = true;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(127, 31);
            this.txtvalor.TabIndex = 0;
            // 
            // txthoras
            // 
            this.txthoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoras.Location = new System.Drawing.Point(295, 51);
            this.txthoras.Multiline = true;
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(109, 31);
            this.txthoras.TabIndex = 1;
            // 
            // btm1
            // 
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm1.Location = new System.Drawing.Point(183, 180);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(111, 49);
            this.btm1.TabIndex = 2;
            this.btm1.Text = "calcular";
            this.btm1.UseVisualStyleBackColor = true;
            this.btm1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salariolbl
            // 
            this.salariolbl.AutoSize = true;
            this.salariolbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salariolbl.Location = new System.Drawing.Point(200, 346);
            this.salariolbl.Name = "salariolbl";
            this.salariolbl.Size = new System.Drawing.Size(76, 25);
            this.salariolbl.TabIndex = 3;
            this.salariolbl.Text = "salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 526);
            this.Controls.Add(this.salariolbl);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtvalor);
            this.Name = "Form1";
            this.Text = "salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Label salariolbl;
    }
}

