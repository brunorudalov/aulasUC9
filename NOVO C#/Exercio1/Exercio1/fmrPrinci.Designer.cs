namespace Exercio1
{
    partial class fmrPrinci
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btm1 = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(182, 106);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(128, 31);
            this.txtValor1.TabIndex = 3;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(514, 106);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(128, 31);
            this.txtValor2.TabIndex = 4;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btm1
            // 
            this.btm1.BackColor = System.Drawing.Color.DarkCyan;
            this.btm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm1.Location = new System.Drawing.Point(367, 222);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(114, 34);
            this.btm1.TabIndex = 5;
            this.btm1.Text = "Calcular\r\n";
            this.btm1.UseVisualStyleBackColor = false;
            this.btm1.Click += new System.EventHandler(this.btm1_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.BackColor = System.Drawing.Color.Cornsilk;
            this.lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresul.Location = new System.Drawing.Point(408, 324);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(113, 29);
            this.lblresul.TabIndex = 6;
            this.lblresul.Text = "resultado";
            // 
            // fmrPrinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "fmrPrinci";
            this.Text = "soma";
            this.Load += new System.EventHandler(this.fmrPrinci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Label lblresul;
    }
}

