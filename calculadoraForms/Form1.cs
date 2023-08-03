using CalculadoraFormulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraForms
{

    public partial class Form1 : Form
    {
        ModelCalculadora modelo;
        public Form1()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadora();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Dividir(Convert.ToDouble(textBox1.Text));
        }// Botão divisão

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Multiplicar(Convert.ToDouble(textBox1.Text));
        }//Botão multiplicação

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(textBox1.Text));
        }//Botão subtração

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(textBox1.Text));

        }//Botao soma

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Raiz(Convert.ToDouble(textBox1.Text));

        }//Botão raiz

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Potência(Convert.ToDouble(textBox1.Text));
        }//botão potência
    }
}
