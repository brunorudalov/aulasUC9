using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercio1
{
    public partial class fmrPrinci : Form
    {
        public fmrPrinci()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm1_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtValor1.Text);
            decimal numero2 = Convert.ToDecimal(txtValor2.Text);
            decimal resultado = 0;

            resultado = numero1 + numero2;
            lblresul.Text = resultado.ToString();
        }

        private void fmrPrinci_Load(object sender, EventArgs e)
        {

        }
    }
}
