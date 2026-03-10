//8. Mostrar el cuadrado de un número utilizando una función MostrarCuadrado(int n).
void MostrarCuadrado(int n)
{
	Console.WriteLine("ingrese un numero: ");
	int numero = int.Parse(Console.ReadLine());
	int resultado = numero * numero;
	Console.WriteLine(resultado);

}

MostrarCuadrado();