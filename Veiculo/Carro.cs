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
            this.Ano = ano;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Placa = placa;
            this.Chassis = chassis;
            this.Numporta = numporta;
            this.Espacomala = espacomala;
            this.Combustivel = combustivel;
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
            s = String.Concat("Informações do Carro", "\r\n", "\r\n", "Ano: ", this.Ano, "\r\n", "Marca: ", this.Marca, "\r\n", "Modelo: ", this.Modelo, "\r\n", "Cor: ", this.Cor, "\r\n", "Placa: ", this.Placa, "\r\n", "Chassis: ", this.Chassis, "\r\n", "Número de Portas: ", this.Numporta, "\r\n", "Espaço da Mala: ", this.Espacomala, "\r\n", "Combustível: ", this.Combustivel);
            return s;
        }
    }
}
