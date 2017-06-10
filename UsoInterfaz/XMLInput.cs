/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 16:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Xml;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of XMLInput.
	/// </summary>
	public class XMLInput: IInput
	{
		public XMLInput()
		{
		}

		#region IInput implementation

		public string NotifyOutput()
		{
			return ReadXML();
		}

		#endregion
		
		public string ReadXML()
		{
			string str = "";
			try {
				XmlDocument doc = new XmlDocument();
				string xmlFile = System.Windows.Forms.Application.StartupPath +
				             "\\input.xml";
				if (System.IO.File.Exists(xmlFile)) {
					doc.Load(@xmlFile);
					XmlNodeList node1 = doc.GetElementsByTagName("node2");
					foreach (XmlNode node2 in node1) {
						str += node2.ChildNodes[0].FirstChild.Value;
					}
				} else {
					Console.WriteLine("Missing the input.xml from" +
					" application directory.");
				}
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			return str;
		}
		
	}
}
