using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minicalcu
{
    public partial class FrmPri : Form
    {
        public FrmPri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(valor1.Text);
            decimal numero2 = Convert.ToDecimal(valor2.Text);
            decimal resultado = 0;


            resultado = numero1 - numero2;
            lblresul.Text = resultado.ToString();
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void valor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(valor1.Text);
            decimal numero2 = Convert.ToDecimal(valor2.Text);
            decimal resultado = 0;


            resultado = numero1 + numero2;
            lblresul.Text = resultado.ToString();



            /*/
             * 
             * 
            if (numero2 == 0)
            {

                MessageBox.Show("Divisão por  0 proibida");
                lblresul.Text = "0";
            }
            else
            {
                resultado = numero1 / numero2;
                lblresul.Text = resultado.ToString();
            }
             */
        }

        private void divi_Click(object sender, EventArgs e)
        {

            decimal numero1 = Convert.ToDecimal(valor1.Text);
            decimal numero2 = Convert.ToDecimal(valor2.Text);
            decimal resultado = 0;

            if (numero2 == 0)
            {

                MessageBox.Show("Divisão por  0 proibida");
                lblresul.Text = "0";
            }
            else
            {
                resultado = numero1 / numero2;
                lblresul.Text = resultado.ToString();
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(valor1.Text);
            decimal numero2 = Convert.ToDecimal(valor2.Text);
            decimal resultado = 0;


            resultado = numero1 * numero2;
            lblresul.Text = resultado.ToString();
        }
    }
}
