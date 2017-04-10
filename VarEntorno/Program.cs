/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 05/11/2016
 * Hora: 23:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace VarEntorno
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			//Ruta hasta la carpeta System32 de Windows
			Console.WriteLine(Environment.SystemDirectory);
			//Nombre de la máquina
			Console.WriteLine(Environment.MachineName);
			//Ruta del directorio desde donde se está trabajando
			Console.WriteLine(Environment.CurrentDirectory);
			//Sistema operativo y versión
			Console.WriteLine(Environment.OSVersion.ToString());

			//Todas las variables de entorno y sus valores respectivos
			IDictionary variablesEntorno = Environment.GetEnvironmentVariables();
			foreach (DictionaryEntry item in variablesEntorno)
				Console.WriteLine(item.Key + ": " + item.Value);
			string variable = Environment.GetEnvironmentVariable("Path");
			
			Console.WriteLine("cadena Path: "+variable);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}