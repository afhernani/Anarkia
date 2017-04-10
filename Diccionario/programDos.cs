/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 05/04/2017
 * Hora: 6:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;


namespace Diccionario
{
	/// <summary>
	/// Description of programDos.
	/// </summary>
	public class programDos
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			Console.WriteLine("Uso de diccionario.");
			var ser = new Dictionary<string, string>();
			ser.Add("gato", "cat");
			ser.Add("perro", "dog");
			ser.Add("elefante", "elephant");
			ser.Add("cocodrilo", "cocodrive");
			ser.Add("caballo", "horse");
			foreach (var item in ser) {
				Console.WriteLine("{0} - {1}", item.Key.ToString(), item.Value.ToString());
			}
			SaveDictionary("serial-dic.xml", ref ser);
			
			//codigo llave.
			string codigo = System.Guid.NewGuid().ToString();
			Console.WriteLine(codigo);
			
			Console.WriteLine("Pulse una tecla para terminar.");
			Console.ReadKey(true);
			
		}
		private static void SaveDictionary(string fileName, ref Dictionary<string, string> list)
        {
        	using (TextWriter w = new StreamWriter(fileName))
        	{
        		try
        		{
        			Type[] tipos = {typeof(KeyValuePair<string,string>)};//,typeof(TVal)};
        			XmlSerializer s = new XmlSerializer(typeof(Dictionary<string, string>),tipos);
        			//, new Type[] { typeof(Prueba), typeof(PointF[]), typeof(PointU[]) });
        			//desabilitar el xmlseralizerNamespaces de windows
        			XmlSerializerNamespaces names = new XmlSerializerNamespaces();
        			names.Add("goald", "Diccionario");
        			s.Serialize(w, list, names);
        		}
        		catch (Exception ex)
        		{
        			Debug.WriteLine(ex.Message);
        			MessageBox.Show(ex.ToString());
        		}
        		finally
        		{
        			//w.Close(); tampoco por el using
        		}
        	}
        }
	}
}
