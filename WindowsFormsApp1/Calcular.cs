using System;

public class Calcular
{
    //método calcular IMC
    public double CalcularIMC(double peso, double altura)
    {
        double IMC = peso / Math.Pow(altura, 2);
        return IMC;
    }






}