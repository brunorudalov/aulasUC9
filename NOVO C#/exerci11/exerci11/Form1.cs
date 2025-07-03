using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerci11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            double resto = 0;
            double resul = 0;
            double resultado = 0;
            double resultado2 = 0;

            resul = valor / 3;
            resto = valor % 3;
            resultado = resul;
            lblresult.Text = resultado.ToString();
            resultado2 = resto;
            lblresto.Text = resto.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
