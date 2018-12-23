/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/12/2018
 * Hora: 23:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace delegados
{
	delegate int Multicast();
	/// <summary>
	/// Description of MultiCastDelegate.
	/// </summary>
	public class MultiCastDelegate
	{
//		static void Main()
//		{
//			Multicast d = ReturnFive;
//			d += ReturnTen;
//			int value = d();
//			Console.WriteLine(value);
//			// TODO: Implement Functionality Here
//			
//			Console.Write("Press any key to continue . . . ");
//			Console.ReadKey(true);
//			//solo devuelve el ultimo valor de ReturTen.
//		}
		//segund modificacion, obteniendo todos los valores de la
		//lista de delegados enlazados a d Multicast.
//		static void Main()
//		{
//			Multicast d = ReturnFive;
//			d += ReturnTen;
//			List<int> ints = new List<int>();
//			foreach (Multicast del in d.GetInvocationList()) {
//				ints.Add(del());
//			}
//			foreach (var i in ints) {
//				Console.WriteLine(i);
//			}
//			// TODO: Implement Functionality Here
//			
//			Console.Write("Press any key to continue . . . ");
//			Console.ReadKey(true);
//		}
		//tercera modificacion. Extrayendo una funcion con delegado
		static void Main()
		{
			Multicast d = ReturnFive;
			d += ReturnTen;
			d += ReturnTwentyTwo;
			List<int>ints = GetAllReturnValues(d);
			foreach (var i in ints) {
				Console.WriteLine(i);
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static int ReturnFive(){return 5;}
		static int ReturnTen(){return 10;}
		static int ReturnTwentyTwo(){return 22;}
		
		static List<int>GetAllReturnValues(Multicast d){
			List<int> ints = new List<int>();
			foreach (Multicast del in d.GetInvocationList()) {
				ints.Add(del());
			}
			return ints;
		}
	}
	
}
