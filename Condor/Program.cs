/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 28/03/2017
 * Hora: 8:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Condor
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			List<string> arr = new List<string>();
			arr.Add("argi");arr.Add("sol");arr.Add("candy");arr.Add("open");
			string res = String.Join(",",arr.ToArray());
			Console.WriteLine(res);
			string[] str ={"pelo","condor", "loco", "soldier"};
			string resa = String.Join(",", str);
			Console.WriteLine(resa);
			//usando stringBuilder
			System.Text.StringBuilder build = new System.Text.StringBuilder();
			foreach (string cat in arr) {
				build.Append(cat).Append('|');
			}
			res = build.ToString();
			Console.WriteLine(res);
			
			//list to string 
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}