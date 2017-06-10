/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 01/05/2017
 * Hora: 11:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Parser
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Parser ...");
			
			// TODO: Implement Functionality Here
			Console.WriteLine("- Readcharacters -");
			ReadCharacters();
			Console.WriteLine("- charfromstring -");
			charfromstring();
			Console.WriteLine("- UsingMatchesRegex -");
			string s = @"<p>Hi #Name#,You should come and see this #PLACE# - From #SenderName#</p>";
			UsingMatchesRegex(s);
			Console.WriteLine("- usingSteam -");
			UseStream();
			Console.WriteLine("- UseTokenTest -");
			UseTokenTest();
			Console.WriteLine("- testEvaluaExpresion -");
			testEvaluaExpresion();
			Console.WriteLine("- Loop -");
			Loop();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void ReadCharacters()
		{
			StringBuilder stringToRead = new StringBuilder();
			stringToRead.AppendLine("Characters in 1st line to read");
			stringToRead.AppendLine("and 2nd line");
			stringToRead.AppendLine("and the end");

			using (StringReader reader = new StringReader(stringToRead.ToString())) {
				char ch;
				//int pos = 0;
				do {
					ch = Convert.ToChar(reader.Read());
					Console.WriteLine(ch.ToString());
				} while (reader.Peek() != -1);
				//char ch = (char)reader.Read();
				//string readText = reader.ReadToEnd();
				//Console.WriteLine(readText);
			}
		}
		static void charfromstring()
		{
			string str = "Some number of characters";
			char[] b = new char[str.Length];
	
			using (StringReader sr = new StringReader(str)) {
				// Read 13 characters from the string into the array.
				sr.Read(b, 0, 13);
				Console.WriteLine(b);
	
				// Read the rest of the string starting at the current string position.
				// Put in the array starting at the 6th array member.
				sr.Read(b, 5, str.Length - 13);
				Console.WriteLine(b);
			}
		}
		/// <summary>
		/// Convertir un string en un stream para leer
		/// </summary>
		/// <param name="contents"></param>
		static StreamReader ConvertStringToStream(string contents)
		{
			// convert string to stream
			byte[] byteArray = Encoding.UTF8.GetBytes(contents);
			//byte[] byteArray = Encoding.ASCII.GetBytes(contents);
			MemoryStream stream = new MemoryStream(byteArray);
			// convert stream to string
			StreamReader reader = new StreamReader(stream);
			return reader; //si queremos devolver el stream.
			//string text = reader.ReadToEnd();
			//Console.WriteLine(text);
		}
		//
		static void SendStreamToString(Action<StreamWriter> action, out string destination)
		{
			using (var stream = new MemoryStream())
			using (var writer = new StreamWriter(stream, Encoding.Unicode)) {
				action(writer);
				writer.Flush();
				stream.Position = 0;
				destination = Encoding.Unicode.GetString(stream.GetBuffer(), 0, (int)stream.Length);
			}
		}
		private void usingSendStreamToString()
		{
			string myString;
			SendStreamToString(writer => {
				var ints = new List<int> { 1, 2, 3 };
				writer.WriteLine("My ints");
				foreach (var integer in ints) {
					writer.WriteLine(integer);
				}
			}, out myString);
		}
		//
		static void UsingMatchesRegex(string mytext)
		{
			// using System.Text.RegularExpressions;
			// pattern = any number of arbitrary characters between #.
			const string pattern = @"#(.*?)#";
			var matches = Regex.Matches(mytext, pattern);
			
			foreach (Match m in matches) {
				Console.WriteLine(m.Groups[1]);
			}	
		}
		//
		static void UseStream()
		{
			const string cad = "21.8+3-5";
			using (StreamReader str = ConvertStringToStream(cad)) {
				while (!str.EndOfStream) {
					char ch = Convert.ToChar(str.Read());
					Console.WriteLine(ch);
				}
			}
		}
		//
		static void UseTokenTest()
		{
			string cad = "21.8+3-5/3.11*(10+6+2)+4";
			cad = TextUtils.DelEmptyString(cad);
			TokenStream tkenstr = new TokenStream(cad.Trim());
			Token t;
			while (!tkenstr.EndOfStream) {
				t = tkenstr.get();
				if (t != null)
					Console.WriteLine("{0} : {1}", t.Kind, t.Val);
			}
					
		}
		static void testEvaluaExpresion()
		{
			string cad = "21.8+3-5/3.11*(10+6+2)+4";
			cad = TextUtils.DelEmptyString(cad);
			Console.WriteLine("Evalua la expresion --> " + cad);
			try {
				Expression expr = new Expression(new TokenStream(cad.Trim()));
				double d = expr.EvaluaExpression();
				Console.WriteLine(d);
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}	
		}
		//
		static void Loop()
		{
			bool userWantsToExit = false;
			TextReader cin = Console.In;
			TextWriter Out = Console.Out;
			Expression expr = new Expression();
			string cad;
			//get input
			while (!userWantsToExit) 
			{
				{
					Out.Write('>');
					cad = cin.ReadLine();
				}
				try 
				{
					expr.AddTokenStream(new TokenStream(cad.Trim()));
					expr.Calculate();
				} 
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}	
				if (cad.ToUpper().Equals("exit".ToUpper()))
					userWantsToExit = true;
			}
		}
		//
		
	}
}