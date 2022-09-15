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
    public partial class Form3 : Form
    {
        Caminhao caminhao;
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(Convert.ToInt32(txtAno.Text), txtMarca.Text, txtModelo.Text, txtCor.Text, txtPlaca.Text, txtChassis.Text, txtCarreta.Text, txtCabine.Text, Convert.ToInt32(txtEixo.Text));

            txtAno.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtPlaca.Clear();
            txtChassis.Clear();
            txtCarreta.Clear();
            txtCabine.Clear();
            txtEixo.Clear();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.ImprimeDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Veiculos principal = new Veiculos();
            principal.Show();
        }

        private void txtEixo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
