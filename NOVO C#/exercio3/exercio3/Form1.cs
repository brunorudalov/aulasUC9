using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Valor1.Text);
            decimal numero2 = Convert.ToDecimal(Valor2.Text);
            decimal resultado1 = 0;
            decimal resultado2 = 0;
            decimal resultadofinal = 0;

            resultado1 = numero1 * numero1;
            resul1.Text = resultado1.ToString();

            resultado2 = numero2 * numero2;
            resul2.Text = resultado2.ToString();

            resultadofinal = resultado1 + resultado2;
            resulFinal.Text = resultadofinal.ToString();
        }
    }
}
