using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm_Click(object sender, EventArgs e)
        {
            decimal milhas = Convert.ToDecimal(txtmilhas.Text);
            decimal kmcon = Convert.ToDecimal (1.609);
            decimal resultado = 0;
            decimal km = 0;

            km = milhas * kmcon;
            resultado = km;
            lblkm.Text = resultado.ToString();


        }
    }
}
