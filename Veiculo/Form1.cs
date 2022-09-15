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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 carro = new Form2();
            carro.Show();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 caminhao = new Form3();
            caminhao.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
