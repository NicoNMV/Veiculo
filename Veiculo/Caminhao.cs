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
            this.Ano = ano;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Placa = placa;
            this.Chassis = chassis;
            this.Carreta = carreta;
            this.Cabine = cabine;
            this.Eixo = eixo;
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
            s = String.Concat("Informações do Caminhão", "\r\n", "\r\n", "Ano: ", this.Ano, "\r\n", "Marca: ", this.Marca, "\r\n", "Modelo: ", this.Modelo, "\r\n", "Cor: ", this.Cor, "\r\n", "Placa: ", this.Placa, "\r\n", "Chassis: ", this.Chassis, "\r\n", "Carreta: ", this.Carreta, "\r\n", "Cabine: ", this.Cabine, "\r\n", "Eixo: ", this.Eixo);
            return s;
        }
    }
}
