/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/12/2018
 * Hora: 14:06
 * 
 */
using System;
using System.Collections.Generic;

namespace delegados
{
	delegate bool Compara(int n);
	/// <summary>
	/// Description of makina.
	/// </summary>
	public class makina
	{
		static bool a(int n)
		{
			return n < 5;
		}
		static bool b(int n)
		{
			return n < 10;
		}
		static bool c(int n)
		{
			return n == 10;
		}
		static void Main()
		{
			Console.WriteLine("parametrizando con delegados");
			Console.WriteLine("Menor que Cinco");
			int[] numbers = new int[]{ 2, 11, 5, 8, 9, 3, 19, 7, 6, 0, 10, 12, 17 };
			//utilizamos una expresion landa.
			IEnumerable<int> result = GetAllNumbres(numbers, n => n<5);
			foreach (var item in result) {
				Console.WriteLine(item);
			}
			Console.WriteLine("Menor que Diez");
			result = GetAllNumbres(numbers, b);
			foreach (var item in result) {
				Console.WriteLine(item);
			}
//			medelegate me = Foo;
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//funcion parametrica
		static IEnumerable<int> GetAllNumbres(IEnumerable<int> numbers, mediadel verifica)
		{
			foreach (var number in numbers) {
				if (verifica(number))
					yield return number;
			}
		}
	}
}
