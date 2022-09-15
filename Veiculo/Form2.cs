using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veiculo
{
    public partial class Form2 : Form
    {
        Carro carro;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            carro = new Carro(Convert.ToInt32(txtAno.Text), txtMarca.Text, txtModelo.Text, txtCor.Text, txtPlaca.Text, txtChassis.Text, (Convert.ToInt32(txtPortas.Text)), Convert.ToInt32(txtMala.Text), txtCombust.Text);
            
            txtAno.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtPlaca.Clear();
            txtChassis.Clear();
            txtPortas.Clear();
            txtMala.Clear();
            txtCombust.Clear();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ImprimeDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form principal = new Form();
            principal.Show();
        }
    }
}
