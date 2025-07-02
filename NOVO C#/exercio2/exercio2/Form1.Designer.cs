namespace exercio2
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
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Valor3 = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.Valor4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valor1
            // 
            this.Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor1.Location = new System.Drawing.Point(98, 86);
            this.Valor1.Multiline = true;
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(95, 34);
            this.Valor1.TabIndex = 0;
            this.Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Valor3
            // 
            this.Valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor3.Location = new System.Drawing.Point(411, 86);
            this.Valor3.Multiline = true;
            this.Valor3.Name = "Valor3";
            this.Valor3.Size = new System.Drawing.Size(95, 34);
            this.Valor3.TabIndex = 1;
            this.Valor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Valor2
            // 
            this.Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor2.Location = new System.Drawing.Point(252, 86);
            this.Valor2.Multiline = true;
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(95, 34);
            this.Valor2.TabIndex = 2;
            this.Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Valor4
            // 
            this.Valor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor4.Location = new System.Drawing.Point(583, 86);
            this.Valor4.Multiline = true;
            this.Valor4.Name = "Valor4";
            this.Valor4.Size = new System.Drawing.Size(95, 34);
            this.Valor4.TabIndex = 3;
            this.Valor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(375, 342);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(75, 25);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "média";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Valor4);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor3);
            this.Controls.Add(this.Valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1;
        private System.Windows.Forms.TextBox Valor3;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.TextBox Valor4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMedia;
    }
}

