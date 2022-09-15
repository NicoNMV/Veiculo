using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Carro : Veiculo
    {
        private int numporta;
        private int espacomala;
        private string combustivel;

        public Carro()
        {
            this.numporta = 0;
            this.espacomala = 0;
            this.combustivel = null;
        }
        public Carro(int ano, string marca, string modelo, string cor, string placa, string chassis, int numporta, int espacomala, string combustivel)
        {
            this.numporta = numporta;
            this.espacomala = espacomala;
            this.combustivel = combustivel;
        }
        public int Numporta
        {
            get { return numporta; }
            set { numporta = value; }
        }
        public int Espacomala
        {
            get { return espacomala; }
            set { espacomala = value; }
        }
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Ano, "", this.Marca, "", this.Modelo, "", this.Cor, "", this.Placa, "", this.Chassis, "", this.Numporta, "", this.Espacomala, "", this.Combustivel);
            return s;
        }
    }
}
