namespace exer9
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
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btm = new System.Windows.Forms.Button();
            this.lblnsalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(120, 61);
            this.txtsalario.Multiline = true;
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(161, 31);
            this.txtsalario.TabIndex = 0;
            this.txtsalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btm
            // 
            this.btm.BackColor = System.Drawing.Color.Chocolate;
            this.btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm.Location = new System.Drawing.Point(146, 172);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(111, 45);
            this.btm.TabIndex = 1;
            this.btm.Text = "calcular";
            this.btm.UseVisualStyleBackColor = false;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // lblnsalario
            // 
            this.lblnsalario.AutoSize = true;
            this.lblnsalario.BackColor = System.Drawing.Color.LightPink;
            this.lblnsalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnsalario.Location = new System.Drawing.Point(141, 304);
            this.lblnsalario.Name = "lblnsalario";
            this.lblnsalario.Size = new System.Drawing.Size(129, 25);
            this.lblnsalario.TabIndex = 2;
            this.lblnsalario.Text = "novo salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(397, 524);
            this.Controls.Add(this.lblnsalario);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.txtsalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Label lblnsalario;
    }
}

