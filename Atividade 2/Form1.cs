namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            double vlrRaio;

            if (!double.TryParse(txtRaio.Text, out vlrRaio))
                MessageBox.Show("raio inválido");
            else
                if (vlrRaio <= 0)
                MessageBox.Show("Raio deve ser maior que zero!");
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double vlrAltura;

            if (!double.TryParse(txtAltura.Text, out vlrAltura))
                MessageBox.Show("Altura deve ser maior que zero!");
            else
                if (vlrAltura <= 0)
                MessageBox.Show("Altura deve ser maior que zero!");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vlrRaio, vlrAltura;

            if ((!double.TryParse(txtRaio.Text, out vlrRaio))
                || (!double.TryParse(txtAltura.Text, out vlrAltura)))

            {
                MessageBox.Show("valores inválidos");
                txtRaio.Focus();

            }
            else
                if (vlrRaio <= 0 || vlrAltura <= 0)

            {
                MessageBox.Show("valores devem ser maior que zero!");
                txtRaio.Focus();
            }
            else
            {
                double volume;
                volume = Math.PI * Math.Pow(vlrRaio, 2) *vlrAltura;
                txtVolume.Text = volume.ToString("N2");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
