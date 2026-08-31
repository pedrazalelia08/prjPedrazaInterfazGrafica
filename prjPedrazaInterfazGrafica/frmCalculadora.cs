using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjPedrazaInterfazGrafica
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);

            //calculo suma
            double calculo = numero1 + numero2;

            lblTotal.Text = calculo.ToString();


        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);

            //Calculo resta
            double calculo = numero1 - numero2;

            lblTotal.Text = calculo.ToString();

        }

        private void btnMultiplicación_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);

            //calculo multiplicación
            double calculo = numero1 * numero2;

            lblTotal.Text = calculo.ToString();

        }
    }
}
