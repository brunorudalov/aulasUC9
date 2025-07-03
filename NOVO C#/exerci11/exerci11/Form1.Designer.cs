namespace exerci11
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btmp = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblresto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btmp
            // 
            this.btmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmp.Location = new System.Drawing.Point(171, 149);
            this.btmp.Name = "btmp";
            this.btmp.Size = new System.Drawing.Size(106, 48);
            this.btmp.TabIndex = 1;
            this.btmp.Text = "Calcular";
            this.btmp.UseVisualStyleBackColor = false;
            this.btmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.Coral;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(97, 331);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(24, 25);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "0";
            // 
            // lblresto
            // 
            this.lblresto.AutoSize = true;
            this.lblresto.BackColor = System.Drawing.Color.Coral;
            this.lblresto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresto.Location = new System.Drawing.Point(337, 331);
            this.lblresto.Name = "lblresto";
            this.lblresto.Size = new System.Drawing.Size(24, 25);
            this.lblresto.TabIndex = 3;
            this.lblresto.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.lblresto);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btmp);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btmp;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblresto;
    }
}

