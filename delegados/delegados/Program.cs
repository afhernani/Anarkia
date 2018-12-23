/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 21/12/2018
 * Hora: 23:06
 */
using System;
using System.Collections.Generic;

namespace delegados
{
	delegate void medelegate();
	delegate void miDelegado(string[] args);
	delegate bool mediadel(int n);
	class Program
	{
		public static void Main(string[] args)
		{
			medelegate del = new medelegate(Foo);
			del(); //llamada.
			del.Invoke();//llamada.
			Console.WriteLine(del.Method);
			Console.WriteLine(del.Target);
//			visto vt = new visto();
			del = visto.Foo;
			Console.WriteLine(del.Method);
			Console.WriteLine(del.Target);
			//otro metodo.
			Console.WriteLine("Another method constructor delegate");
			medelegate dos = Foo;
			dos();
			dos.Invoke();
			Console.WriteLine("InvokeTheDelegate");
			//otro - creando función delegada.
			InvokeTheDelegate(del);
			//pasando el nombre la función a delegar.
			Console.WriteLine("pass name function to function delegate");
			InvokeTheDelegate(Goo);
			InvokeTheDelegate(new medelegate(Foo));
			//cualquier funcion estatica es un delegado por si
			Console.WriteLine("invocando el delegado Main");
			miDelegado delega = Argument;
			delega(new string[]{ "good", "ok", "sdf" });
			//llamada con función de delegados y parametros.
			InvokeTheDelegate(delega, new string[]{ "good", "ok", "sdf" });
			
			//parametrizando con delegados
			Console.WriteLine("parametrizando con delegados");
			Console.WriteLine("Menor que Cinco");
			int[] numbers = new int[]{ 2, 11, 5, 8, 9, 3, 19, 7, 6, 0, 10, 12, 17 };
			IEnumerable<int> result = GetAllNumbres(numbers, MenorQueCinco);
			foreach (var item in result) {
				Console.WriteLine(item);
			}
			Console.WriteLine("Menor que Diez");
			result = GetAllNumbres(numbers, MenorQueDiez);
			foreach (var item in result) {
				Console.WriteLine(item);
			}
			
			//enlazar delegados.
			Console.WriteLine("Enlace de delegados: ");
			medelegate su = Foo;
			su = (medelegate)Delegate.Combine(su, new medelegate(Goo));
			su += Goo;
			su += Sue;
			su += Foo;
			su();
			Console.WriteLine("Imprimir la lista de delegados");
			foreach (var m in su.GetInvocationList()) {
				Console.WriteLine(m.Target + ": " + m.Method);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static bool MenorQueCinco(int n){ return n < 5; }
		static bool MenorQueDiez(int n){ return n < 10;	}

		//funcion parametrica
		static IEnumerable<int> GetAllNumbres(IEnumerable<int> numbers, mediadel verifica)
		{
			foreach (var number in numbers) {
				if (verifica(number))
					yield return number;
			}
		}
		static void InvokeTheDelegate(medelegate dele)
		{
			dele();
		}
		static void InvokeTheDelegate(miDelegado dele, string[] args)
		{
			dele(args);
		}
		static void Argument(string[]args)
		{
			foreach (var item in args) {
				Console.Write(item + "  ");
			}
			Console.Write(Environment.NewLine);
		}
		public static void Foo()
		{
			Console.WriteLine("Food()");
		}
		static void Goo()
		{
			Console.WriteLine("Good()");
		}
		static void Sue()
		{
			Console.WriteLine("Sue()");
		}			
	}
	static class visto
	{
		public static void Goo()
		{
			Console.WriteLine("Good()");
		}
		public static void Foo()
		{
			Console.WriteLine("Food()");
		}
	}
}