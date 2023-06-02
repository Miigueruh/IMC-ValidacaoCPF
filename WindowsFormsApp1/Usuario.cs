using System;

public class Usuario
{
    private string nome;
    private string cpf;
    private string sexo;
    private double peso;
    private double altura;
    private double idade;
      
    public Usuario(string nome, string cpf, string sexo, double peso, double altura, double idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
        this.idade = idade;
    }

    public (double, string, string) CalcularIMC(double peso, double altura)
    {
        double IMC = peso / Math.Pow(altura, 2);
        string classi = "";
        string grau = "";

        if (IMC < 18.5 )
        {
            classi = "Magreza";
            grau = "0";
        }
        else if (IMC > 18.5 && IMC < 24.9)
        {
            classi = "Normal";
            grau = "0";
        }
        else if (IMC > 24.9 && IMC < 29.9)
        {
            classi = "Sobrepeso";
            grau = "I";
        }
        else if (IMC > 29.9 && IMC < 39.9)
        {
            classi = "Obesidade";
            grau = "II";
        }
        else if (IMC > 39.9)
        {
            classi = "Obesidade Grave";
            grau = "III";
        }



        return (IMC, classi, grau);
    }

}