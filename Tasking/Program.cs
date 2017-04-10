/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 01/04/2017
 * Hora: 10:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Tasking
{
	/*En el ejemplo siguiente se crea 20 tareas que se reproducción hasta que se incrementa 
* un contador en un valor de 2 millones. Cuando las 10 primeras tareas llegar 
* a millones de 2, el token de cancelación se cancela y se cancelan todas las tareas 
* cuyos contadores no hayan alcanzado 2 millones. El ejemplo a continuación, examina 
* el Task.Status propiedad de cada tarea para indicar si la tarea ha finalizado 
* correctamente o se ha cancelado. Para aquellos que se han completado, muestra 
* el valor devuelto por la tarea.
*/
	using System;
	using System.Threading;
	using System.Collections.Concurrent;
	using System.Collections.Generic;
	using System.IO;
	using System.Threading.Tasks;

	public class Tasking
	{
		public static void Main()
		{
			var tasks = new List<Task<int>>();
			var source = new CancellationTokenSource();
			var token = source.Token;
			int completedIterations = 0;

			for (int n = 0; n <= 19; n++)
				tasks.Add(Task.Factory.StartNew(() => {
					int iterations = 0;
					for (int ctr = 1; ctr <= 2000000; ctr++) {
						token.ThrowIfCancellationRequested();
						iterations++;
					}
					Interlocked.Increment(ref completedIterations);
					if (completedIterations >= 10)
						source.Cancel();
					return iterations;
				}, token));

			Console.WriteLine("Waiting for the first 10 tasks to complete...\n");
			try {
				Task.WaitAll(tasks.ToArray());
			} catch (AggregateException) {
				Console.WriteLine("Status of tasks:\n");
				Console.WriteLine("{0,10} {1,20} {2,14:N0}", "Task Id",
					"Status", "Iterations");
				foreach (var t in tasks)
					Console.WriteLine("{0,10} {1,20} {2,14}",
						t.Id, t.Status,
						t.Status != TaskStatus.Canceled ? t.Result.ToString("N0") : "n/a");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}