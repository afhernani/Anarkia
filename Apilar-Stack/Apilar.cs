/*
 * Created by SharpDevelop.
 * User: hernani
 * Date: 23/04/2017
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Apilar_Stack
{
/*En el ejemplo de código siguiente se muestra varios métodos de la Stack<T> clase genérica. 
 * El ejemplo de código crea una pila de cadenas con capacidad predeterminada y utiliza el 
* Push método para insertar cinco cadenas en la pila. Se enumeran los elementos de la pila, 
* que no cambia el estado de la pila. El Pop método se utiliza para extraer la primera 
* cadena de la pila. El Peek método se utiliza para buscar el siguiente elemento en la pila y,
* a continuación, el Pop método se usa para extraer.
* El ToArray método se usa para crear una matriz y copiar los elementos de la pila en él, 
* a continuación, la matriz se pasa a la Stack<T> constructor que toma IEnumerable<T>, 
* crear una copia de la pila con el orden de los elementos invertidos. Se muestran los 
* elementos de la copia.
* Dos veces el tamaño de la pila se crea una matriz y la CopyTo método se usa para copiar 
* los elementos de matriz, empezando por el centro de la matriz. El Stack<T> constructor 
* se utiliza de nuevo para crear una copia de la pila con el orden de los elementos 
* invertidos; por lo tanto, los tres elementos null se encuentran al final.
* El Contains método se usa para mostrar que la cadena "four" está en la primera 
* copia de la pila, después del cual el Clear método borra la copia y el Count 
* propiedad muestra que la pila está vacía.
*/
	class Example
	{
		public static void Apilar()
		{
			Stack<string> numbers = new Stack<string>();
			numbers.Push("one");
			numbers.Push("two");
			numbers.Push("three");
			numbers.Push("four");
			numbers.Push("five");

			// A stack can be enumerated without disturbing its contents.
			foreach (string number in numbers) {
				Console.WriteLine(number);
			}

			Console.WriteLine("\nPopping '{0}'", numbers.Pop());
			Console.WriteLine("Peek at next item to destack: {0}", 
				numbers.Peek());
			Console.WriteLine("Popping '{0}'", numbers.Pop());

			// Create a copy of the stack, using the ToArray method and the
			// constructor that accepts an IEnumerable<T>.
			Stack<string> stack2 = new Stack<string>(numbers.ToArray());

			Console.WriteLine("\nContents of the first copy:");
			foreach (string number in stack2) {
				Console.WriteLine(number);
			}

			// Create an array twice the size of the stack and copy the
			// elements of the stack, starting at the middle of the 
			// array. 
			string[] array2 = new string[numbers.Count * 2];
			numbers.CopyTo(array2, numbers.Count);

			// Create a second stack, using the constructor that accepts an
			// IEnumerable(Of T).
			Stack<string> stack3 = new Stack<string>(array2);

			Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
			foreach (string number in stack3) {
				Console.WriteLine(number);
			}

			Console.WriteLine("\nstack2.Contains(\"four\") = {0}", 
				stack2.Contains("four"));

			Console.WriteLine("\nstack2.Clear()");
			stack2.Clear();
			Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
		}
	}

	/* This code example produces the following output:

five
four
three
two
one

Popping 'five'
Peek at next item to destack: four
Popping 'four'

Contents of the first copy:
one
two
three

Contents of the second copy, with duplicates and nulls:
one
two
three




stack2.Contains("four") = False

stack2.Clear()

stack2.Count = 0
 */
}
