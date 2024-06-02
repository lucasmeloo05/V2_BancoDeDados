using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_BD
{
    internal class Moto
    {
        private string nome;
        private string marca;
        private int ano;
        private double valor;
        private double km;
        private string cor;
        private string estilo;
        private string marchas;

        public Moto(string nome, string marca, int ano, double valor, double km, string cor, string estilo, string marchas)
        {
            this.Nome = nome;
            this.Marca = marca;
            this.Ano = ano;
            this.Valor = valor;
            this.Km = km;
            this.Cor = cor;
            this.Estilo = estilo;
            this.Marchas = marchas;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Ano { get => ano; set => ano = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Km { get => km; set => km = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Estilo { get => estilo; set => estilo = value; }
        public string Marchas { get => marchas; set => marchas = value; }
    }
}
