namespace exer10
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
            this.btm = new System.Windows.Forms.Button();
            this.lblpou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(128, 61);
            this.txtvalor.Multiline = true;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(141, 42);
            this.txtvalor.TabIndex = 0;
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btm
            // 
            this.btm.BackColor = System.Drawing.Color.AliceBlue;
            this.btm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm.Location = new System.Drawing.Point(150, 200);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(95, 34);
            this.btm.TabIndex = 1;
            this.btm.Text = "calcular";
            this.btm.UseVisualStyleBackColor = false;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // lblpou
            // 
            this.lblpou.AutoSize = true;
            this.lblpou.BackColor = System.Drawing.Color.LightBlue;
            this.lblpou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpou.Location = new System.Drawing.Point(136, 331);
            this.lblpou.Name = "lblpou";
            this.lblpou.Size = new System.Drawing.Size(122, 25);
            this.lblpou.TabIndex = 2;
            this.lblpou.Text = "invetimento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(379, 560);
            this.Controls.Add(this.lblpou);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.txtvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Label lblpou;
    }
}

