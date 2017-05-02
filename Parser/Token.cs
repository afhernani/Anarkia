/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 01/05/2017
 * Hora: 11:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Parser
{
	/// <summary>
	/// Description of Token.
	/// </summary>
	public class Token
	{
		//constantes globales.
		public const char number = '8';
		// t.kind==number means that t is a number Token
		public const char quit = 'q';
		// t.kind==quit means that t is a quit Token
		public const char print = ';';
		//t.kind==print means that t is a print Token
		public const string pront = "> ";
		//pront de consola
		public const string result = "= ";
		//indicar resultado
		//contantes token.
		/// <summary>
		/// what kind of token
		/// </summary>
		public char Kind{ get; set; }
		/// <summary>
		/// for numbers: a value 
		/// </summary>
		public double Val{ get; set; }
		/// <summary>
		/// make a Token from a char and a double
		/// </summary>
		/// <param name="ch"></param>
		/// <param name="val"></param>
		public Token(char ch, double val)
		{
			Kind = ch;
			Val = val;
		}
		/// <summary>
		/// make a Token from a char
		/// </summary>
		/// <param name="ch"></param>
		public Token(char ch)
			: this(ch, 0)
		{
		}
	}
	
	/// <summary>
	/// clase tokenstream
	/// </summary>
	public class TokenStream
	{
		private static StreamReader Str{ get; set; }
		public TokenStream(string cad)
			: this()
		{
			// convert string to stream
			byte[] byteArray = Encoding.UTF8.GetBytes(cad);
			//byte[] byteArray = Encoding.ASCII.GetBytes(contents);
			MemoryStream stream = new MemoryStream(byteArray);
			// convert stream to string
			Str = new StreamReader(stream);
		}
		public TokenStream(StreamReader str)
			: this()
		{
			Str = str;
		}
		/// <summary>
		/// make a Token_stream that reads from
		/// The constructor just sets full to indicate 
		/// that the buffer is empty:
		/// </summary>
		public TokenStream()
		{
			this.full = false;
			this.buffer = null; //no Token in buffer
		}
		/// <summary>
		/// end of TokenStream ture.
		/// </summary>
		public bool EndOfStream {
			get {
				return Str.EndOfStream;
			}
		}
		/// <summary>
		/// get a Token (get() is defined elsewhere)
		/// </summary>
		/// <returns></returns>
		public Token get()
		{
			if (full) { //do we already have a Token ready?
				full = false; //remove Token from buffer
				return buffer;
			}
			char ch;
			if (Str.EndOfStream)
				return null;
			ch = Convert.ToChar(Str.Read());
			switch (ch) {
				case '\0':
					return new Token(ch);
					break;
				case Token.print:
				case Token.quit:
				case '(': 
				case ')': 
				case '+': 
				case '-': 
				case '*': 
				case '/': 
				case '%':
					return new Token(ch);        // let each character represent itself
					break;
				case '.':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					{
						StringBuilder strb = new StringBuilder();
						strb.Append(ch);
						
						while (!Str.EndOfStream) {
							if (TextUtils.IsNumeric(ch = Convert.ToChar(Str.Peek())) || Convert.ToChar(Str.Peek()) == '.') {
								ch = Convert.ToChar(Str.Read());
								strb.Append(ch);
							} else {
								break;
							}
						}
						
						Debug.WriteLine(strb.ToString());
						return new Token(Token.number, Convert.ToDouble(strb.ToString(), System.Globalization.CultureInfo.InvariantCulture));
					}
					break;
				default:
					throw new Exception("exception get");
					break;					
			}
		}
		/// <summary>
		/// put a Token back
		/// </summary>
		/// <param name="t"></param>
		public void putback(Token t)
		{
			if (full)
				throw new Exception("putback() into a full buffer");
			buffer = t; // copy t to buffer
			full = true; // buffer is now full
		}
		/// <summary>
		/// discard tokens up to an including a c
		/// </summary>
		/// <param name="ch"></param>
		public void Ignore(char ch)
		{		
		}
		/// <summary>
		/// is there a Token in the buffer?
		/// </summary>
		private bool full{ get; set; }
		/// <summary>
		/// here is where we keep a Token put back using putback()
		/// </summary>
		private Token buffer{ get; set; }
	}
}
