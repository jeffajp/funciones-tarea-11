//10. Imprimir un texto varias veces utilizando una función ImprimirRepetido(string texto, int veces).

void ImprimirRepetido(string texto, int veces)
{
	for (int i = 1; i < veces; i++)
	{
		Console.WriteLine(texto);
	}
	
}
Console.WriteLine("ingrese una frase: ");
string texto= Console.ReadLine();
Console.WriteLine("ingrese las veces que se repita: ");
int veces = int.Parse(Console.ReadLine());
Console.WriteLine(texto);

ImprimirRepetido(texto, veces);