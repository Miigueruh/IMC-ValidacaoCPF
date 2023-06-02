using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lorem.Text = "";
            valido.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = nome.Text;
            string cpf = CPF.Text;
            string sex = sexo.Text;
            double weight = Convert.ToDouble(peso.Text);
            double height = Convert.ToDouble(altura.Text);
            double age = Convert.ToDouble(idade.Text);


            Usuario u = new Usuario(name, cpf, sex, weight, height, age);

            (double IMC, string classi, string grau) = u.CalcularIMC(weight, height);

            lorem.Text = $"IMC = {IMC.ToString("0.0")}\nClassificação = {classi}\nGrau = {grau}";


            bool resultadoCPF = Validacoes.ValidarCPF(cpf);
            if (resultadoCPF == true)
            {
                valido.Text = "CPF válido";
            }
            else
            {
                valido.Text = "CPF inválido";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            CPF.Text = "";
            sexo.Text = "";
            peso.Text = "";
            altura.Text = "";
            idade.Text = "";
            lorem.Text = "";
            valido.Text = "";
        }


        private void lorem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
