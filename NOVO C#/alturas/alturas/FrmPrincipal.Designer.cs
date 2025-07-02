namespace alturas
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.btmOK = new System.Windows.Forms.Button();
            this.lblMEDIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBox1.Location = new System.Drawing.Point(90, 90);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(123, 30);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBox2.Location = new System.Drawing.Point(282, 90);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(123, 30);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // txtBox3
            // 
            this.txtBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBox3.Location = new System.Drawing.Point(466, 90);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(123, 30);
            this.txtBox3.TabIndex = 2;
            this.txtBox3.TextChanged += new System.EventHandler(this.txtBox3_TextChanged);
            // 
            // btmOK
            // 
            this.btmOK.BackColor = System.Drawing.Color.SlateBlue;
            this.btmOK.FlatAppearance.BorderSize = 0;
            this.btmOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btmOK.Location = new System.Drawing.Point(297, 222);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(128, 46);
            this.btmOK.TabIndex = 3;
            this.btmOK.Text = "Calcular";
            this.btmOK.UseVisualStyleBackColor = false;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // lblMEDIA
            // 
            this.lblMEDIA.AutoSize = true;
            this.lblMEDIA.BackColor = System.Drawing.Color.Violet;
            this.lblMEDIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMEDIA.Location = new System.Drawing.Point(324, 331);
            this.lblMEDIA.Name = "lblMEDIA";
            this.lblMEDIA.Size = new System.Drawing.Size(62, 24);
            this.lblMEDIA.TabIndex = 4;
            this.lblMEDIA.Text = "Media";
            this.lblMEDIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMEDIA.Click += new System.EventHandler(this.lblMEDIA_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblMEDIA);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "altura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Label lblMEDIA;
    }
}

