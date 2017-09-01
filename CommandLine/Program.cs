/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 24/08/2017
 * Hora: 14:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using CommandLine.Utility;

namespace CommandLine
{
	public class program
	{
		/// <summary>
		///  -size=100 /height:'400' -param1 "Nice stuff !" --debug
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			// Command line parsing
			Arguments CommandLine = new Arguments(args);

			// Look for specific arguments values and display them if they exist (return null if they don't)
			if (CommandLine["param1"] != null)
				Console.WriteLine("Param1 value: " + CommandLine["param1"]);
			else
				Console.WriteLine("Param1 not defined !");
			
			if (CommandLine["height"] != null)
				Console.WriteLine("Height value: " + CommandLine["height"]);
			else
				Console.WriteLine("Height not defined !");
			
			if (CommandLine["width"] != null)
				Console.WriteLine("Width value: " + CommandLine["width"]);
			else
				Console.WriteLine("Width not defined !");
			
			if (CommandLine["size"] != null)
				Console.WriteLine("Size value: " + CommandLine["size"]);
			else
				Console.WriteLine("Size not defined !");
			
			if (CommandLine["debug"] != null)
				Console.WriteLine("Debug value: " + CommandLine["debug"]);
			else
				Console.WriteLine("Debug not defined !");

			// Wait for key
			Console.Out.WriteLine("Arguments parsed. Press a key...");
			Console.ReadKey(true);
		}
	}
}