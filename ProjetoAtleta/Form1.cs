using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class pessoa : Form
    {
        public pessoa()
        {
            InitializeComponent();
        }

        atleta obj = new atleta();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.NOME = nome.Text;
                obj.DataNascimento = DateTime.Parse(datanascimento.Text);
                obj.ALTURA = double.Parse(altura.Text);
                obj.PESO = double.Parse(peso.Text);
                MessageBox.Show("Dados Armazenados.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double imc, peso1, altura1;

            peso1 = double.Parse(peso.Text);
            altura1 = double.Parse(altura.Text);
            imc = peso1 / (altura1 * altura1);

            MessageBox.Show("Dados 1 Obtidos: " + obj.ImprimeDados() +
                "\n\nSeu IMC: " + imc +
                "\n\nIdade: " + obj.CalcularIdade().ToString("00"));
            idade.Text = obj.CalcularIdade().ToString();
        }
    }
}
