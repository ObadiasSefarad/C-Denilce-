using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;
        string resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Número Invalido... Digite um Número! ");
                txtPeso.Focus();
               
            }
            else if (peso <= 0)
            {
                MessageBox.Show("Número Invalido... Digite um Número maior que 0! ");
                txtPeso.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtImc.Text = "";
            txtSituacao.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Número Invalido... Digite um Número! ");
                txtAltura.Focus();

            }

           else  if (altura <= 0)
            {
                MessageBox.Show("Número Invalido... Digite um Número maior que 0! ");
                txtAltura.Focus();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imc = peso / Math.Pow(altura, 2);
            imc = Math.Round(imc, 1);

            if (imc <= 18.5)
            {
                resultado = "Magreza";
            } 
                else if (imc <= 24.9)
            {
                resultado = "Normal";
            } 
                else if (imc <= 29.9)
            {
                resultado = "SobrePeso";
            } 
                else if (imc <= 39.9)
            {
                resultado = "Obesidade";
            } 
                else if (imc >= 40)
            {
                resultado = "Obesidade Grave";
            }

            txtImc.Text = (imc.ToString());
            txtSituacao.Text = resultado;
        }
    }
}
