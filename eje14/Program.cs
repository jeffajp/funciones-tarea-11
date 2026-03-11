
using System;

double Dividir(double a, double b)
{
    return a * b;

}
Console.WriteLine("ingrese un numero: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese segundo numero: ");
double b = double.Parse(Console.ReadLine());

double resultado = Dividir(a, b);
Console.WriteLine(resultado);
