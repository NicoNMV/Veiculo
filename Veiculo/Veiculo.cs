using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal abstract class Veiculo
    {
        private int ano;
        private string marca;
        private string modelo;
        private string cor;
        private string placa;
        private string chassis;

        public Veiculo()
        {
            this.ano = 0;
            this.marca = null;
            this.modelo = null;
            this.cor = null;
            this.placa = null;
            this.chassis = null;

        }

        public Veiculo(int ano, string marca, string modelo, string cor, string placa, string chassis)
        {
            this.ano = ano;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.chassis = chassis;
        }

        public int Ano
        {
            get { return this.ano; }
            set { this.ano = value; }
        }
        public string Marca
        {
            get { return this.marca; }  
            set { this.marca = value; }
        }
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public string Cor
        {
            get { return this.cor; }
            set { this.cor = value; }
        }
        public string Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }
        public string Chassis
        {
            get { return this.chassis; }
            set { this.chassis = value; }
        }

        public abstract String ImprimeDados();
    }

   
}
