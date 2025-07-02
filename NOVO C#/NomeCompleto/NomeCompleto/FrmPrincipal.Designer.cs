namespace NomeCompleto
{
    partial class FrmPrincipal
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btmOK = new System.Windows.Forms.Button();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNome.Location = new System.Drawing.Point(118, 164);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 30);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSobrenome.Location = new System.Drawing.Point(365, 164);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(191, 30);
            this.txtSobrenome.TabIndex = 1;
            // 
            // btmOK
            // 
            this.btmOK.BackColor = System.Drawing.Color.Red;
            this.btmOK.FlatAppearance.BorderSize = 0;
            this.btmOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btmOK.Location = new System.Drawing.Point(283, 268);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(100, 31);
            this.btmOK.TabIndex = 2;
            this.btmOK.Text = "Perigo";
            this.btmOK.UseVisualStyleBackColor = false;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.BackColor = System.Drawing.Color.Gold;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCompleto.Location = new System.Drawing.Point(148, 97);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(364, 23);
            this.lblNomeCompleto.TabIndex = 3;
            this.lblNomeCompleto.Text = "Nome Completo";
            this.lblNomeCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmPrincipal";
            this.Text = "Nome Completo";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Label lblNomeCompleto;
    }
}

