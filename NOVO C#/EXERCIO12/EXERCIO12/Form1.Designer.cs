namespace EXERCIO12
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
            this.txtkilos = new System.Windows.Forms.TextBox();
            this.btm1 = new System.Windows.Forms.Button();
            this.lbldias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkilos
            // 
            this.txtkilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkilos.Location = new System.Drawing.Point(132, 64);
            this.txtkilos.Multiline = true;
            this.txtkilos.Name = "txtkilos";
            this.txtkilos.Size = new System.Drawing.Size(115, 38);
            this.txtkilos.TabIndex = 0;
            this.txtkilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btm1
            // 
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm1.Location = new System.Drawing.Point(132, 188);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(99, 34);
            this.btm1.TabIndex = 1;
            this.btm1.Text = "calcular";
            this.btm1.UseVisualStyleBackColor = true;
            this.btm1.Click += new System.EventHandler(this.btm1_Click);
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbldias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.Location = new System.Drawing.Point(180, 335);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(25, 25);
            this.lbldias.TabIndex = 2;
            this.lbldias.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 540);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.txtkilos);
            this.Name = "Form1";
            this.Text = "EXERCIO 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkilos;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Label lbldias;
    }
}

