/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 04/04/2017
 * Hora: 19:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace Diccionario
{
	/// <summary>
	/// datos item.
	/// </summary>
	public class DataItem
	{
		public string Key;
 
		public string Value;
 
		public DataItem(string key, string value)
		{
			Key = key;
			Value = value;
		}
	}
	/*
	[XmlRoot("Dictionary")]
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
	{
		#region IXmlSerializable Members
		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}
		public void ReadXml(System.Xml.XmlReader reader)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));
			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();
			if (wasEmpty)
				return;
			while (reader.NodeType != System.Xml.XmlNodeType.EndElement) {
				reader.ReadStartElement("item");
				reader.ReadStartElement("key");
				TKey key = (TKey)keySerializer.Deserialize(reader);
				reader.ReadEndElement();
				reader.ReadStartElement("value");
				TValue value = (TValue)valueSerializer.Deserialize(reader);
				reader.ReadEndElement();
				this.Add(key, value);
				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}
		public void WriteXml(System.Xml.XmlWriter writer)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));
			foreach (TKey key in this.Keys) {
				writer.WriteStartElement("item");
				writer.WriteStartElement("key");
				keySerializer.Serialize(writer, key);
				writer.WriteEndElement();
				writer.WriteStartElement("value");
				TValue value = this[key];
				valueSerializer.Serialize(writer, value);
				writer.WriteEndElement();
				writer.WriteEndElement();
			}
		}
		#endregion
	}*/
	/// <summary>
	/// Description of Dicv.
	/// </summary>
	public class Dicv
	{
		public Dicv()
		{
		}
		/*
		 * serializamos el diccionario con la propiedad.
		[XmlIgnore]
		public Dictionary<string, string> Parameters { get; set; }

		[XmlArray("Parameters")]
		[XmlArrayItem("Pair")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)] // not necessary
		public KeyValuePairSerializable<string, string>[] ParametersXml
		{
			get { 
				return Parameters?.Select(p => new KeyValuePairSerializable<string, string>(p)).ToArray(); 
			}
			set {
				Parameters = value?.ToDictionary(i => i.Key, i => i.Value);
			}
		}*/
	}
	/*
	/// <summary>
	/// extructura generica.
	/// </summary>
	[Serializable]
	public struct KeyValuePairSerializable<K, V>
	{	
		public static KeyValuePairSerializable<K,V> Empty;
		static KeyValuePairSerializable(){
			Empty = new KeyValuePairSerializable<K,V>();
			Empty.Key = (K)new object();
			Empty.Value = (V)new object();			
		}
		public KeyValuePairSerializable(KeyValuePair<K, V> pair)
		{
			Key = pair.Key;
			Value = pair.Value;
		}

		[XmlAttribute]
		public K Key { get; set;}

		[XmlText]
		public V Value { get; set; }

		public override string ToString()
		{
			return "[" + StringHelper.ToString(Key, "") + ", " + StringHelper.ToString(Value, "") + "]";
		}
		
	}*/

}
