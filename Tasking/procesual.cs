/*The following example defines a ShowThreadInfo method that displays the Thread.ManagedThreadIdof the current thread. It is called directly from the application thread, and is called from the Action delegate passed to the Run(Action) method.
*/
using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

public class Example
{
	public static void Main()
	{
		ShowThreadInfo("Application");

		var t = Task.Factory.StartNew(() => ShowThreadInfo("Task"));
		t.Wait();
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}

	static void ShowThreadInfo(String s)
	{
		Console.WriteLine("{0} Thread ID: {1}",
			s, Thread.CurrentThread.ManagedThreadId);
	}
}
// The example displays the following output:
//       Application thread ID: 1
//       Task thread ID: 3
/*The following example is similar to the previous one, except that it uses a lambda expression to define the code that the task is to execute.
*/
public class LandaExample
{
	public static void Main()
	{
		Console.WriteLine("Application thread ID: {0}",
			Thread.CurrentThread.ManagedThreadId);
		var t = Task.Factory.StartNew(() => {
			Console.WriteLine("Task thread ID: {0}",
				Thread.CurrentThread.ManagedThreadId);
		});
		t.Wait();
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
// The example displays the following output:
//       Application thread ID: 1
//       Task thread ID: 3


/*The examples show that the asynchronous task executes on a different 
 * thread than the main application thread.
 * 
The call to the Wait method ensures that the task completes and 
displays its output before the application ends. Otherwise, it is 
possible that the Main method will complete before the task finishes.

The following example illustrates the Run(Action) method. It defines 
an array of directory names and starts a separate task to retrieve
the file names in each directory. All tasks write the file names to a 
single ConcurrentBag<T> object. The example then calls 
the WaitAll(Task[]) method to ensure that all tasks have 
completed, and then displays a count of the total number of 
file names written to the ConcurrentBag<T> object.
*/
public class asynchronousExample
{
	public static void Main()
	{
		var list = new ConcurrentBag<string>();
		string[] dirNames = { ".", ".." };
		List<Task> tasks = new List<Task>();
		foreach (var dirName in dirNames) {
			Task t = Task.Factory.StartNew(() => {
				foreach (var path in Directory.GetFiles(dirName))
					list.Add(path);
			});
			tasks.Add(t);
		}
		Task.WaitAll(tasks.ToArray());
		foreach (Task t in tasks)
			Console.WriteLine("Task {0} Status: {1}", t.Id, t.Status);

		Console.WriteLine("Number of files read: {0}", list.Count);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
// The example displays output like the following:
//       Task 1 Status: RanToCompletion
//       Task 2 Status: RanToCompletion
//       Number of files read: 23