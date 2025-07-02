using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exer10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtvalor.Text);
            double percetual = 0.05;
            double nvalor = 0;
            double renda = 0;
            double resultado = 0;

            nvalor = valor * percetual;
            renda = nvalor + percetual;
            resultado = renda;
            lblpou.Text = resultado.ToString();

        }
    }
}
