/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 16:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Runtime.Serialization;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of BinInput.
	/// </summary>
	public class BinInput:IInput
	{
		public BinInput()
		{
		}

		#region IInput implementation

		public string NotifyOutput()
		{
			return ReadBin();
		}

		#endregion
		/// <summary>
		/// lee fichero binario.
		/// </summary>
		/// <returns></returns>
		public string ReadBin()
		{
			AStringClass SomeStringClass = null;
			string binFile = System.Windows.Forms.Application.StartupPath +
			              "\\input.bin";
			try {
				if (File.Exists(binFile)) {
					IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					Stream stream = new FileStream(binFile, FileMode.Open, FileAccess.Read, FileShare.Read);
					SomeStringClass = (AStringClass)formatter.Deserialize(stream);
					stream.Close();
				} else {
					Console.WriteLine("Missing the input.bin" +
					" from application directory.");
				}
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			return SomeStringClass.SomeString;
		}
		
		
	}
}
