using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class atleta
    {
        private string nome;
        private DateTime datanascimento;
        private double altura;
        private double peso;

        public string Nome { get => nome; set => nome = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }

        public string NOME
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("É obrigatorio colocar seu nome.");
                }
            }
            get { return this.nome; }
        }
        
        public DateTime DataNascimento
        {
            set { this.datanascimento = value; }
            get { return this.datanascimento; }
        }
        public double ALTURA
        {
            set
            {
                if(value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1.00 m.");
                }
            }
            get { return this.altura; }
        }

        public double PESO
        {
            set
            {
                if (value >= 1.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("Acrescente um peso acima de 0");
                }
            }
            get { return this.peso; }
        }

        public string ImprimeDados()
        {
            return "Dados da Pessoa: \n\nNome: " + this.nome +
                "\nData de Nascimento: " + this.datanascimento.ToString("dd/MM/yyyy") +
                "\nAltura: " + this.altura.ToString("0.00") + "m." +
                "\nPeso: " + this.peso.ToString("0.00") + "Kg.";
        }
        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.datanascimento.Year;
        }

    }
}
