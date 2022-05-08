using System;

class Calculadora
{
    public int Suma(int num1, int num2)
    {
        return num1 + num2;
    } 

    public int Resta(int num1, int num2)
    {
        return num1 - num2;
    } 

    public int Mult(int num1, int num2)
    {
        return num1 * num2;
    } 

    public double Div(double num1, double num2)
    {
        if (num2 !=0 )
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("ERROR: No se puede dividir por 0");
            return 0;
        }
    }
    
}
