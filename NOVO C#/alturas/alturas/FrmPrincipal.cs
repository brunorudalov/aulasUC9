using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alturas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            lblMEDIA.Text = Convert.ToString((Convert.ToDecimal(txtBox1.Text)+Convert.ToDecimal(txtBox2.Text)+Convert.ToDecimal(txtBox3.Text)) / 3);
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMEDIA_Click(object sender, EventArgs e)
        {

        }
    }
}
