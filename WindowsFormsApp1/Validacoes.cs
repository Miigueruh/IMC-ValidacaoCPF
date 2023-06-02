using System;
using System.Windows.Forms;
public static class Validacoes
{

    public static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");


        if (cpf.Length != 11)
        {
            return false;
        }

        int pos1 = Convert.ToInt32(cpf[0].ToString()) * 10;
        int pos2 = Convert.ToInt32(cpf[1].ToString()) * 9;
        int pos3 = Convert.ToInt32(cpf[2].ToString()) * 8;
        int pos4 = Convert.ToInt32(cpf[3].ToString()) * 7;
        int pos5 = Convert.ToInt32(cpf[4].ToString()) * 6;
        int pos6 = Convert.ToInt32(cpf[5].ToString()) * 5;
        int pos7 = Convert.ToInt32(cpf[6].ToString()) * 4;
        int pos8 = Convert.ToInt32(cpf[7].ToString()) * 3;
        int pos9 = Convert.ToInt32(cpf[8].ToString()) * 2;


        int ver = (pos1 + pos2 + pos3 + pos4 + pos5 + pos6 + pos7 + pos8 + pos9);
        int veri = (ver % 11);          
       

        if (veri < 2)
        {
            if(cpf[9] != 0)
            {
                return false;
            }
            
        }
        else if (veri >= 2)
        {
            if (cpf[9] != 11 - veri) 
            {
                return false;
            }
                               
        }

        int posi1 = Convert.ToInt32(cpf[0].ToString()) * 11;
        int posi2 = Convert.ToInt32(cpf[1].ToString()) * 10;
        int posi3 = Convert.ToInt32(cpf[2].ToString()) * 9;
        int posi4 = Convert.ToInt32(cpf[3].ToString()) * 8;
        int posi5 = Convert.ToInt32(cpf[4].ToString()) * 7;
        int posi6 = Convert.ToInt32(cpf[5].ToString()) * 6;
        int posi7 = Convert.ToInt32(cpf[6].ToString()) * 5;
        int posi8 = Convert.ToInt32(cpf[7].ToString()) * 4;
        int posi9 = Convert.ToInt32(cpf[8].ToString()) * 3;
        int posi10 = Convert.ToInt32(cpf[9].ToString()) * 2;

        int ver2 = (posi1 + posi2 + posi3 + posi4 + posi5 + posi6 + posi7 + posi8 + posi9 + posi10);
        int veri2 = (ver2 % 11);
        

        if (veri2 < 2)
        {
            if (cpf[10] != 0)
            {
                return false;
            }
            
        }
        else if (veri2 >= 2)
        {
            if (cpf[10] != 11 - veri2)
            {
                return false;
            }
            
        }              
        return true;
    }   
}