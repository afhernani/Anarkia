/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/09/2016
 * Hora: 0:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace workInterface
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Pez pez = new Pez();
			Submarino submarino = new Submarino();
			Puerto puerto = new Puerto();
			
			puerto.HacerNadar(pez);
			puerto.HacerNadar(submarino);
			
			
			//
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	public interface Nadador
	{
		void Nadar();
	}
	
	public class Pez:Nadador
	{
		#region Nadador implementation
		public void Nadar()
		{
			Console.WriteLine("Nado como un Pez..");
		}
		#endregion
		
	}
	public class Submarino: Nadador
	{
		#region Nadador implementation
		public void Nadar()
		{
			Console.WriteLine("Nado como un submarino..");
		}
		#endregion
		
	}
	public class Puerto{
		
		public void HacerNadar(Nadador n) {
			n.Nadar();
		}
	}
}