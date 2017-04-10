/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 19/09/2016
 * Hora: 12:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace workdelegados
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		delegate void midelegado();
		void ActionClick(object sender, EventArgs e)
		{
			midelegado del = new midelegado(food);
			del();
			//lo asigna de igual manera
			midelegado sec = food;
			sec();
			Action act = food;
			act.Invoke();
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
		}
		void food(){
			richTextBox1.Text += "Food" + Environment.NewLine;
		}
		void writeRichText(string s){
			richTextBox1.Text += s + Environment.NewLine;
		}
		string writeFunctionPrint(string s){
			richTextBox1.Text += Environment.NewLine + s + Environment.NewLine;
			return "Hecho off";
		}
		static void InvokeDelegate(midelegado d){d();}
		static void InvokeDelegate(Action<string> d){d("invokedelegate action");}
		static string InvokeDelegateFunc(Func<string,string> d){return d("invokedelegate func");}
	}
}
