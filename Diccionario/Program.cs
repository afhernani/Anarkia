/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 04/04/2017
 * Hora: 19:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using Diccionario;

namespace Diccionario
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Uso de diccionario.");
			
			var ser = new SerializableDictionary<string, string>();
			ser.Add("one", "uno");
			ser.Add("two", "dos");
			ser.Add("three", "tres");
			ser.Add("four", "cuatro");
			ser.Add("five", "cinco");
			foreach (var item in ser) {
				Console.WriteLine("{0} - {1}", item.Key.ToString(), item.Value.ToString());
			}
			//XmlWriter writer = XmlWriter.Create("datos.xml");
			//ser.WriteXml(writer);
			SaveDictionaryToDisc(ser);
			SerializableDictionary<string, string> nov= new SerializableDictionary<string, string>();
			LoadExistingFile(ref nov);	
			//XmlReader reader = XmlReader.Create("datos.xml");
			//nov.ReadXml(reader);
			Console.WriteLine("Reading date from file .... file.xml");
			foreach (var item in nov) {
				Console.WriteLine("{0} - {1}", item.Key.ToString(), item.Value.ToString());
			}
			
			Console.WriteLine("Pulse una tecla para terminar.");
			Console.ReadKey(true);
		}
		/*
		//serialize en modo binario
		private void Deserialize()
        {
            try
            {
                var f_fileStream = File.OpenRead(@"dictionarySerialized.xml");
                var f_binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                myDictionary = (Dictionary<string,>)f_binaryFormatter.Deserialize(f_fileStream);
                f_fileStream.Close();
            }
            catch (Exception ex)
            {
                ;
            }
        }
        private void Serialize()
        {
            try
            {
                var f_fileStream = new FileStream(@"dictionarySerialized.xml", FileMode.Create, FileAccess.Write);
                var f_binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                f_binaryFormatter.Serialize(f_fileStream, myDictionary);
                f_fileStream.Close();
            }
            catch (Exception ex)
            {
                ;
            }
        }
        */
		/// <summary>
		/// Loads a Serializable dictionary which holds a saved values
		/// </summary>
		private static void LoadExistingFile(ref SerializableDictionary<string, string> data)
		{
			//SerializableDictionary<string, string> data = new SerializableDictionary<string, string>();
			if (File.Exists("file.xml")) {
				XmlSerializer s = new XmlSerializer(typeof(SerializableDictionary<string, string>));
				using (StreamReader sr = new StreamReader("file.xml")) {
					data = s.Deserialize(sr) as SerializableDictionary<string, string>;
					//dete = new SerializableDictionary<string, string>(data);
				}
			}
		}
		/// <summary>
		/// Saves existing KeyValuePairs to disc
		/// </summary>
		private static void SaveDictionaryToDisc( SerializableDictionary<string, string> data  )
		{
			//SerializableDictionary<string, string> data = new SerializableDictionary<string, string>();
			XmlSerializer s = new XmlSerializer(typeof(SerializableDictionary<string, string>));
			using (StreamWriter sw = new StreamWriter("file.xml")) {
				s.Serialize(sw, data);
			}
		}
		/*
		/// <summary>
		/// Saves existing KeyValuePairs to disc
		/// </summary>
		public static void SaveDictionaryToDisc(string file, Object dic)
		{
			SerializableDictionary<TKey, TVal> data = dic;
			XmlSerializer s = new XmlSerializer(typeof(dic));
			using (StreamWriter sw = new StreamWriter(file))
				s.Serialize(sw, dic);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="file"></param>
		/// <returns></returns>
		public static Object LoadExistingFile(string file, Object dic)
		{
			//Object data = new Obj();
			if (File.Exists(file)) {
				XmlSerializer s = new XmlSerializer(typeof(dic));
				using (StreamReader sr = new StreamReader(file)) {
					Object data = s.Deserialize(sr) as dic;
				}
				return data;
			}
		}*/
	}
}