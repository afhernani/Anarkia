/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 16:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of INIInput.
	/// </summary>
	public class INIInput:IInput
	{
		public INIInput()
		{
		}

		#region IInput implementation

		string IInput.NotifyOutput()
		{
			return ReadIni();
		}

		#endregion
		
		private string ReadIni()
		{
			string str = "";
			string iniFile = System.Windows.Forms.Application.StartupPath +
			              "\\input.ini";
			try {
				if (System.IO.File.Exists(iniFile)) {
					using (StreamReader sr = new StreamReader(iniFile)) {
						String line;
						while ((line = sr.ReadLine()) != null) {
							str += line;
						}
					}
				} else {
					Console.WriteLine("Missing the input.ini " +
					"from application directory.");
				}
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			return str;
		}
		
	}
}
