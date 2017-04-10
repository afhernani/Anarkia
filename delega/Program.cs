/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 19/09/2016
 * Hora: 13:30
 *
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace delega
{
	class Program
	{
		delegate void midelegado();
		delegate void midelega(int a);
		public static void Main()
		{
			Console.WriteLine("Hello World!");
		    bool res = Directory.Exists("ffmpeg");
            Console.WriteLine(res.ToString());
            Console.WriteLine(" XX-XX-XX");
			// TODO: Implement Functionality Here
			midelegado del = new midelegado(food);
			del();
			//lo asigna de igual manera
			midelegado sec = food;
			sec();
			Action act = food;
			act();
			Action<string> print = writeRichText;
			print("Hola delegado Action");
			Func<string,string> printx = writeFunctionPrint;
			string s = printx("Hola delegado Func");
			print("ahora viene el valor devuelto por Func .... ");
			print(s);
			writeRichText("invokando un delegado atraves de una funcion");
			InvokeDelegate(food);
			InvokeDelegate(writeRichText);
			s = InvokeDelegateFunc(writeFunctionPrint);
			writeRichText(s);
			//vamos a hacer una llamada recursiva. Main()
			//midelegado main = Main;
			//main();
			// esto produce un bloque interminable.
			// en el caso de no introducir metodos estaticos lo sorteamos
			// llamando a una clase que lo contenga.
			Program prog = new Program();
			midelega mi = prog.goo;
			mi(5);
			mi(6);
			//vamos ha hecharle un vistazo al metodo y al traget
			Console.WriteLine("Method and Target de: gelegate mi");
			Console.WriteLine(mi.Method);
			Console.WriteLine(mi.Target);
			//para otro caso estatico. -ejemplo print
			Console.WriteLine("Method and Target de: delegate print");
			Console.WriteLine(print.Method);
			Console.WriteLine(print.Target);
			//para el caso del delegado del, declarado al principio.
			Console.WriteLine("Method and Target de: delegate del");
			Console.WriteLine(del.Method);
			Console.WriteLine(del.Target);
			//TODO.

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		void goo(int a){Console.WriteLine(a);}
		static void food(){
			Console.WriteLine( "Food" + Environment.NewLine);
		}
		static void writeRichText(string s){
			Console.WriteLine( s + Environment.NewLine);
		}
		static string writeFunctionPrint(string s){
			Console.WriteLine( Environment.NewLine + s + Environment.NewLine);
			return "Hecho off";
		}
		static void InvokeDelegate(midelegado d){d();}
		static void InvokeDelegate(Action<string> d){d("invokedelegate action");}
		static string InvokeDelegateFunc(Func<string,string> d){return d("invokedelegate func");}
	}
}
