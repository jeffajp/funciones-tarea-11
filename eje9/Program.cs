//9. Sumar dos números utilizando una función SumarMostrar(int a, int b) y mostrar el resultado.
int SumarMostrar(int a, int b)
{
	return  a + b;

}
Console.WriteLine("ingrese un digito");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("ingrese otro digito");
int b=int.Parse(Console.ReadLine());

int r =SumarMostrar(a, b);
Console.WriteLine(r);