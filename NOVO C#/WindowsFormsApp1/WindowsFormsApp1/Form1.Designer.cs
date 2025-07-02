namespace WindowsFormsApp1
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
            this.txtmilhas = new System.Windows.Forms.TextBox();
            this.btm = new System.Windows.Forms.Button();
            this.lblkm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmilhas
            // 
            this.txtmilhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmilhas.Location = new System.Drawing.Point(335, 75);
            this.txtmilhas.Multiline = true;
            this.txtmilhas.Name = "txtmilhas";
            this.txtmilhas.Size = new System.Drawing.Size(163, 37);
            this.txtmilhas.TabIndex = 0;
            this.txtmilhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmilhas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btm
            // 
            this.btm.BackColor = System.Drawing.Color.Tomato;
            this.btm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm.Location = new System.Drawing.Point(358, 188);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(104, 34);
            this.btm.TabIndex = 1;
            this.btm.Text = "Calcular";
            this.btm.UseVisualStyleBackColor = false;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.BackColor = System.Drawing.Color.Gold;
            this.lblkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.Location = new System.Drawing.Point(382, 333);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(57, 25);
            this.lblkm.TabIndex = 2;
            this.lblkm.Text = "km/s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.txtmilhas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmilhas;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Label lblkm;
    }
}

