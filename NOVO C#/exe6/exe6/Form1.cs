﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtvalor.Text);
            decimal horas = Convert.ToDecimal(txthoras.Text);
            decimal resultado = 0;
            decimal salario = 0;

            salario = valor * horas;
            resultado = salario;
            salariolbl.Text = resultado.ToString();

        }
    }
}
