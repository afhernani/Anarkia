/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 20:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Azar.
	/// </summary>
	public class Azar
	{
		public Azar()
		{
		}
		public static void main()
		{
			int[] ndigitos = new int[10];
			int n;
    
			Random rnd = new Random();

			// Inicializar el array
			for (int i = 0; i < 10; i++) {
				ndigitos[i] = 0;
			}

			// verificar que los números aleatorios están uniformente distribuídos
			for (long i = 0; i < 100000L; i++) {
			// genera un número aleatorio entre 0 y 9
				n = (int)(rnd.NextDouble() * 10.0);
			//Cuenta las veces que aparece un número
				ndigitos[n]++;
			}

			// imprime los resultados
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(i + ": " + ndigitos[i]);
			}

			//Dos secuencias de 5 número (distinta semilla)
			Console.WriteLine("Primera secuencia");
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("\t" + rnd.NextDouble());
			}
			Console.WriteLine("");

			Console.WriteLine("Segunda secuencia");
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("\t" + rnd.NextDouble());
			}
			Console.WriteLine("");

			//Dos secuencias de 5 número (misma semilla)
			rnd = new Random(3816);
			Console.WriteLine("Primera secuencia");
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("\t" + rnd.NextDouble());
			}
			Console.WriteLine("");

			rnd = new Random(3816);
			Console.WriteLine("Segunda secuencia");
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("\t" + rnd.NextDouble());
			}
			Console.WriteLine("");
		}
	}
}
