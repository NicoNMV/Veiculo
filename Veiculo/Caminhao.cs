using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class Caminhao : Veiculo
    {
        private string carreta;
        private string cabine;
        private int eixo;

        public Caminhao()
        {
            this.carreta = null;
            this.cabine = null;
            this.eixo = 0;
        }
        public Caminhao(int ano, string marca, string modelo, string cor, string placa, string chassis, string carreta, string cabine, int eixo)
        {
            this.carreta = carreta;
            this.cabine = cabine;
            this.eixo = eixo;
        }
        public string Carreta
        {
            get { return carreta; }
            set { carreta = value; }
        }
        public string Cabine
        {
            get { return cabine; }
            set { cabine = value; }
        }
        public int Eixo
        {
            get { return eixo; }
            set { eixo = value; }
        }
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Ano, "", this.Marca, "", this.Modelo, "", this.Cor, "", this.Placa, "", this.Chassis, "", this.Carreta, "", this.Cabine, "", this.Eixo);
            return s;
        }
    }
}
