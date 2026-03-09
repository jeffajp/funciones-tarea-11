//8. Mostrar el cuadrado de un número utilizando una función MostrarCuadrado(int n).
void MostrarCuadrado(int n)
{
	int resultado = n * n;
	Console.WriteLine(resultado);

}
Console.WriteLine("ingrese un numero: ");
int numero= int.Parse(Console.ReadLine());
MostrarCuadrado(numero);