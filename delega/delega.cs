/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/09/2016
 * Hora: 23:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace delega
{
	/// <summary>
	/// Description of delega.
	/// </summary>
	public class delega
	{
		public delega()
		{
			
		}
		public bool MenorQueCinco(int a){return a < 5;}
		public bool MayorQueDiez(int b){return b>10;}
		delegate bool MayDelegate(int n);
		static void Main(){
			delega d = new delega();
			int[] numbers =new []{2, 15, 7, 0, 3, 9, 5, 1, 8, 13, 11, 19};
			IEnumerable<int> result = GetAllNumbersLessThanFive(numbers, d.MayorQueDiez);
			foreach (var n in result) {
				Console.WriteLine(n);
			}
			
			Console.Read();
		}

		static IEnumerable<int> GetAllNumbersLessThanFive(int[] arr, MayDelegate bandera)
		{
			foreach (var number in arr) {
				if(bandera(number)) yield return number;
			}
		}
	}
}
