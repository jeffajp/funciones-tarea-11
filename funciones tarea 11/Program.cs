internal class Program
{
	private static void Main(string[] args)
	{
		// Mostrar un saludo en pantalla utilizando una función Saludar() que imprima “Hola, bienvenido”.
			void Saludar()
			{

			Console.WriteLine("ingrese un nombre: ");
			string nombre= Console.ReadLine();
            Console.WriteLine("hola, bienvenido  " + nombre);
			
			}
		Saludar();




	}
}