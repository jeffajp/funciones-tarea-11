//Mostrar un menú simple utilizando una función MostrarMenu() con tres opciones.

internal class Program
{
	private static void Main(string[] args)
	{
		static void Menu()
		{
			Console.WriteLine("1. nombre: ");
			Console.WriteLine("2. grado: ");
			Console.WriteLine("3. salir: ");

		}

		Menu();
	}
}