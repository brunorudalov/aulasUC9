namespace exercios4._2
{
    partial class frmPrin
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
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.btm1 = new System.Windows.Forms.Button();
            this.resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmetros
            // 
            this.txtmetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetros.Location = new System.Drawing.Point(95, 58);
            this.txtmetros.Multiline = true;
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.Size = new System.Drawing.Size(125, 38);
            this.txtmetros.TabIndex = 0;
            this.txtmetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btm1
            // 
            this.btm1.BackColor = System.Drawing.Color.DarkCyan;
            this.btm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm1.Location = new System.Drawing.Point(95, 156);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(132, 49);
            this.btm1.TabIndex = 1;
            this.btm1.Text = "Conveter";
            this.btm1.UseVisualStyleBackColor = false;
            this.btm1.Click += new System.EventHandler(this.btm1_Click);
            // 
            // resul
            // 
            this.resul.AutoSize = true;
            this.resul.BackColor = System.Drawing.Color.MediumTurquoise;
            this.resul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resul.Location = new System.Drawing.Point(133, 283);
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(47, 29);
            this.resul.TabIndex = 2;
            this.resul.Text = "cm";
            // 
            // frmPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(316, 427);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.txtmetros);
            this.Name = "frmPrin";
            this.Text = "conveter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmetros;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Label resul;
    }
}

