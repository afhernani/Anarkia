/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 16/06/2017
 * Hora: 21:59
 * documentation extracted from the network
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Una interface llamada IMyInterface.
namespace DefineIMyInterface
{
	using System;

	public interface IMyInterface
	{
		// Cualquier clase que implemente IMyInterface debe definir
		// un método que cumpla con la siguiente signatura.
		void MethodB();
	}
}

// Definimos métodos de extensión para IMyInterface.
namespace Extensions
{
	using System;
	using DefineIMyInterface;

	// Los siguientes métodos de extensión pueden ser accesados
	// por instancias de cualquier clase que implementa IMyInterface.
	public static class Extension
	{
		public static void MethodA(this IMyInterface myInterface, int i)
		{
			Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, int i)");
		}

		public static void MethodA(this IMyInterface myInterface, string s)
		{
			Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, string s)");
		}

		// Este método nunca es llamado en ExtensionMethodsDemo1,
		// debido a que cada una de las 3 clases A, B, y C
		// implementan un método llamado MethodB que tiene la
		// misma signatura.
		public static void MethodB(this IMyInterface myInterface)
		{
			Console.WriteLine
                ("Extension.MethodB(this IMyInterface myInterface)");
		}
	}
}

// Definimos 3 clases que implementan IMyInterface, y las usamos
// para probar los métodos de extensión.
namespace ExtensionMethodsDemo1
{
	using System;
	using Extensions;
	using DefineIMyInterface;

	class A : IMyInterface
	{
		public void MethodB()
		{
			Console.WriteLine("A.MethodB()");
		}
	}

	class B : IMyInterface
	{
		public void MethodB()
		{ 
			Console.WriteLine("B.MethodB()"); 
		}
		public void MethodA(int i)
		{ 
			Console.WriteLine("B.MethodA(int i)"); 
		}
	}

	class C : IMyInterface
	{
		public void MethodB()
		{
			Console.WriteLine("C.MethodB()");
		}
		public void MethodA(object obj)
		{
			Console.WriteLine("C.MethodA(object obj)");
		}
	}

	class ExtMethodDemo
	{
		static void Main(string[] args)
		{
			// Declaramos una instancia de cada clase (A, B, y C).
			A a = new A();
			B b = new B();
			C c = new C();

			// Para las 3 clases (a, b, y c), llamamos 
			// los siguientes métodos:
			//      -- MethodA con un argumento int
			//      -- MethodA con un argumento string 
			//      -- MethodB sin argumentos.

			// A no contiene MethodA, así que cada llamado al método
			// MethodA ejecuta el método de extensión que tiene la
			// signatura correspondiente.
			a.MethodA(1);        // Extension.MethodA(object, int)
			a.MethodA("hello");  // Extension.MethodA(object, string)

			// A tiene un método de instancia que se corresponde 
			// con la signatura del siguiente llamado al 
			// método MethodB.
			a.MethodB();            // A.MethodB()

			// B tiene un método de instancia que se corresponde 
			// con la signatura del siguiente llamados.
			b.MethodA(1);           // B.MethodA(int)
			b.MethodB();            // B.MethodB()

			// B no tiene un método de instancia que se corresponde 
			// con la signatura del siguiente llamado, pero la 
			// clase Extension si.
			b.MethodA("hello");  // Extension.MethodA(object, string)

			// C contiene un método de instancia que coincide 
			// con cada uno de los siguientes llamados.
			c.MethodA(1);           // C.MethodA(object)
			c.MethodA("hello");     // C.MethodA(object)
			c.MethodB();            // C.MethodB()


			System.Console.WriteLine("\nPulse cualquier " +
			"tecla para terminar...");
			System.Console.ReadKey(true);
		}
	}
}
