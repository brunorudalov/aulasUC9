using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResul_Click(object sender, EventArgs e)
        {
       

            

        }

        private void CalcularBtm_Click(object sender, EventArgs e)
        {
            decimal lados = Convert.ToDecimal(txtlados.Text);
            decimal area = 0;
            decimal areaTotal = 0;
            decimal resultado = 0;

            area = lados * lados;
            areaTotal = area * 2;
            resultado = areaTotal;
            lblResul.Text = resultado.ToString();
        }
    }
}
