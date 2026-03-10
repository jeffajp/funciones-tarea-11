//11.Sumar dos números utilizando una función Sumar(int a, int b) que retorne el resultado.

int Sumar(int a, int b)
{
	return a + b;

}
Console.WriteLine("ingrese el primer operando: ");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("ingrese segundo operando: ");
int b= int.Parse(Console.ReadLine());

int rsultado= Sumar(a, b);
Console.WriteLine(rsultado);