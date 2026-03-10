//12.Restar dos números utilizando una función Restar(int a, int b) que retorne el resultado.

int Restar(int a, int b)
{
	return a - b;
}
Console.WriteLine("ingrese un numero: ");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero: ");
int b= int.Parse(Console.ReadLine());

int resta = Restar(a, b);
Console.WriteLine(resta);