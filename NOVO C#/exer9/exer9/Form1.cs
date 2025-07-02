using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtsalario.Text);
            double percentual = 15.0/100;
            double novoValor = 0;
            double resultado = 0;
            double total = 0;

            novoValor = valor * percentual;
            total = valor + novoValor;
            resultado = total;
            lblnsalario.Text = resultado.ToString();

        }
    }
}
