using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medias
{
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtmCalcular_Click(object sender, EventArgs e)
        {
           

            int numero1 = Convert.ToInt16(txtValor1.Text);
            int numero2 = Convert.ToInt16(txtValor2.Text);
            int numero3 = Convert.ToInt16(txtValor3.Text);
            decimal media = (numero1 + numero2 + numero3) / 3;

            if (numero1 < media)
            {
                txtValor1.ForeColor = Color.Blue;
            }
            if (numero2 < media)
            {
               txtValor2.ForeColor = Color.Blue;
            }
            if (numero3 < media)
            {  
                txtValor3.ForeColor = Color.Blue;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
