/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 24/08/2017
 * Hora: 14:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace args1
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0) {
				Console.WriteLine("No arguments submitted");
				Console.ReadLine();
				return;
			}
			// processing a single argument
			Console.WriteLine("Squared Argument" + Environment.NewLine);
			// create variables to hold arguments
			Int32 orginalValue = 0;
			Int32 squaredValue = 0;
			try {
				orginalValue = int.Parse(args[0].ToString()); //first argument only
				squaredValue = orginalValue * orginalValue;
				Console.WriteLine(Environment.NewLine +
				Convert.ToString(orginalValue) +
				" Squared = " + Convert.ToString(squaredValue) +
				Environment.NewLine);
				Console.ReadKey(true);
				return;
			} catch {
				// display indication of invalid input from command line
				Console.WriteLine(Environment.NewLine + "Invalid Input" +
				Environment.NewLine);
				Console.ReadKey(true);
				return;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}