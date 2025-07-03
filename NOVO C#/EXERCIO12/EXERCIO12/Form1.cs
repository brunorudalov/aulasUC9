using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCIO12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            double kilos = Convert.ToDouble(txtkilos.Text);
            double gramas = 0;
            double dieta = 0;
            double dias = 0;

            gramas = kilos * 1000;
            dieta = gramas / 50;

            if (kilos > 0)
            {
                dias = dieta;
                lbldias.Text = dias.ToString();
            }
        }
    }
}
