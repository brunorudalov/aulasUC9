using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercios4._2
{
    public partial class frmPrin : Form
    {
        public frmPrin()
        {
            InitializeComponent();
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            decimal metros = Convert.ToDecimal(txtmetros.Text);
            decimal resultado = 0;

            resultado = metros * 100;
            resul.Text = resultado.ToString();
        }
    }
}
