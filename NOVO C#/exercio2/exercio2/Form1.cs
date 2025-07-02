using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Valor1.Text);
            decimal numero2 = Convert.ToDecimal(Valor2.Text);
            decimal numero3 = Convert.ToDecimal(Valor3.Text);
            decimal numero4 = Convert.ToDecimal(Valor4.Text);
            decimal resultado = 0;

            resultado = (numero1 + numero2 + numero3 + numero4) / 4;
            lblMedia.Text = resultado.ToString();
        }
    }
}
