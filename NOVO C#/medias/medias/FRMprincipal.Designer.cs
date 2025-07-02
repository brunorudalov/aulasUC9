namespace medias
{
    partial class FRMprincipal
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
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.dtmCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(130, 47);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(129, 45);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.Text = "0";
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(330, 47);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(129, 45);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.Text = "0";
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(543, 47);
            this.txtValor3.Multiline = true;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(129, 45);
            this.txtValor3.TabIndex = 2;
            this.txtValor3.Text = "0";
            this.txtValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor3.TextChanged += new System.EventHandler(this.txtValor3_TextChanged);
            // 
            // dtmCalcular
            // 
            this.dtmCalcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dtmCalcular.FlatAppearance.BorderSize = 2;
            this.dtmCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtmCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmCalcular.Location = new System.Drawing.Point(330, 198);
            this.dtmCalcular.Name = "dtmCalcular";
            this.dtmCalcular.Size = new System.Drawing.Size(130, 45);
            this.dtmCalcular.TabIndex = 3;
            this.dtmCalcular.Text = "Calcular";
            this.dtmCalcular.UseVisualStyleBackColor = false;
            this.dtmCalcular.Click += new System.EventHandler(this.dtmCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // FRMprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmCalcular);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "FRMprincipal";
            this.Text = "medias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button dtmCalcular;
        private System.Windows.Forms.Label label1;
    }
}

