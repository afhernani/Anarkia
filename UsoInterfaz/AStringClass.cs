/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 16:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Runtime.Serialization;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of AStringClass.
	/// We need this class to cast the serialized objects from the stream, 
	/// when we read the input.bin file. Is also used to 
	/// create the binary file. 
	/// The create of the binary file is not used in this sample instead the 
	/// input.bin file is coming with the source code.
	/// </summary>
	[Serializable]
	public class AStringClass
	{
		public string SomeString;
		public AStringClass()
		{
			this.SomeString = "Text from a bin file";
			string binFile = System.Windows.Forms.Application.StartupPath +
			                 "\\input.bin";
			SaveToBinaryFile(binFile);
		}
		public void SaveToBinaryFile(string binFile)
		{
			try {
				IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				Stream stream = new FileStream(binFile, FileMode.OpenOrCreate,
					            FileAccess.Write, FileShare.None);
				formatter.Serialize(stream, this);
				stream.Close();
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}
