//7. Mostrar el doble de un número utilizando una función MostrarDoble(int n).
void MostrarDoble(int n)
{
	int resultado = n * 2;
	Console.WriteLine(resultado);
}

Console.WriteLine("ingrese un numero: ");
int numero= int.Parse(Console.ReadLine());
MostrarDoble(numero);