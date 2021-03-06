﻿/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 16/05/2017
 * Hora: 11:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text;
using FileLib;

namespace OrderFileMovie
{
	[Serializable]
	/// <summary>
	/// Description of Block.
	/// </summary>
	public class Block
	{
		/// <summary>
		/// Nombre completo con path del fichero de video.
		/// </summary>
		public string NameVideo{ get; set; }
		/// <summary>
		/// Nombre completo con path del fichero thumbails
		/// </summary>
		public string NameThumb{ get; set; }
		/// <summary>
		/// Imagen de referencia
		/// </summary>
		public Image Imagen{ get; set; }
		/// <summary>
		/// Buffer para guardar fichero .gif
		/// </summary>
		public byte[] Buffer{ get; set; }
		/// <summary>
		/// Codificación de identificacion unica.
		/// </summary>
		public string Id{ get; set ; }
		/// <summary>
		/// comprobación de que existe el fichero de video en disco
		/// </summary>
		public bool ExistVideo{ get; set; }
		/// <summary>
		/// comprobación de que existe el fichero de thumbails en disco
		/// </summary>
		public bool ExistThumb{ get; set; }
		/// <summary>
		/// Estan asociados los ficheros? true si es verdad.
		/// </summary>
		public bool Asociate{ get; set; }
		/// <summary>
		/// constructor Unico por defecto.
		/// </summary>
		/// <param name="nameVideo">nombre completo del fichero con path</param>
		public Block(string nameVideo)
		{
			Id = System.Guid.NewGuid().ToString();
			NameVideo = nameVideo;
			string path = Path.GetDirectoryName(NameVideo);
			string name = Path.GetFileName(NameVideo);
			NameThumb = path + @"\Thumbails\"+ name+"_Thumbs_0000.gif";
			ExistThumb=ExistVideo=Asociate=false;
			Inicializa();
		}
		/// <summary>
		/// Constructor vacio for serialization.
		/// </summary>
		public Block()
		{
			;
		}
		/// <summary>
		/// Inicializa los parametros de comprobación de existencia
		/// de los ficheros video e thumb.
		/// </summary>
		private void Inicializa()
		{
			//TODO: comprobar si existen los ficheros e atribuir a
			if(File.Exists(NameVideo)) ExistVideo=true;
			if(File.Exists(NameThumb)) ExistThumb=true;
			// las variables bool Existvideo e ExistThumb.
			if (ExistVideo && ExistThumb)
				Asociate = true;
		}
		/// <summary>
		/// mover los ficheros a la dirección indicada.
		/// </summary>
		/// <param name="ToPath"></param>
		public void Move(string ToPath)
		{
			//TODO: mueve los ficheros a la dirección indicada.
			if(Asociate)
			{
				//destino ficheros
				string toFileVideo = Path.Combine(ToPath, Path.GetFileName(NameVideo));
				string toFileThumb = Path.Combine(ToPath+@"\Thumbails", Path.GetFileName(NameThumb));
				//mover cada uno.
				FileLibrary.MoveFile(NameVideo, toFileVideo, true);
				FileLibrary.MoveFile(NameThumb, toFileThumb, true);
				//debemos actualizar los valores
				NameVideo = toFileVideo;
				NameThumb = toFileThumb;
				Inicializa();
			}
		}
		/// <summary>
		/// copiar los ficheros del block en la dirección indicada
		/// </summary>
		/// <param name="ToPath"></param>
		public void Copy(String ToPath)
		{
		    //TODO: copiar ficheros a la dirección indicada.
		    if(this.Asociate)
		    {
		    	//destino ficheros
				string toFileVideo = Path.Combine(ToPath, Path.GetFileName(NameVideo));
				string toFileThumb = Path.Combine(ToPath+@"\Thumbails", Path.GetFileName(NameThumb));
				//copiar cada uno
				FileLibrary.CopyFile(NameVideo, toFileVideo, true);
				FileLibrary.CopyFile(NameThumb, toFileThumb, true);
				//no hace nada mas.
		    }
		}
		/// <summary>
		/// solo el nombre del fichero excluir path y extención.
		/// </summary>
		/// <param name="NewFileName"></param>
		public void Rename(String NewFileName)
		{
			if(Asociate)
		    {
				//destino ficheros
				FileLibrary.RenameFile(NameVideo, NewFileName);
				FileLibrary.RenameFile(NameThumb, NewFileName + "_Thumbs_0000.gif");
				//no hace nada mas.
				NameVideo = Path.Combine(Path.GetDirectoryName(NameVideo),NewFileName);
				NameThumb = Path.Combine(Path.GetDirectoryName(NameThumb),NewFileName + "_Thumbs_0000.gif");
				Inicializa();
		    }
			//TODO: renombrar los ficheros
		}
		public void Dell()
		{
			//TODO: borrar los ficheros.
			//TODO: borrar todos los datos del block
			//queda vacio, sin nada. listo tambien para ser eliminado.
			//como??
		}	
	}
	
	[Serializable]
	/// <summary>
	/// Master Block
	/// </summary>
	public class MasterBlock
	{
		List<Block> ListBlock;
		public MasterBlock()
		{
			ListBlock = new List<Block>();
		}
		public void Add(Block blo)
		{
			ListBlock.Add(blo);
		}
		public Block this[int index]
		{
			get
			{
				return ListBlock[index];
			}
			set{
				ListBlock[index] = value;
			}
		}
		/// <summary>
		/// Serialize xml
		/// </summary>
		/// <param name="file">Name file with path</param>
		public void Serialize(string file)
		{
			string cadenaXml = UtilSerializationXml.Serialize(ListBlock, false);
			//string path = Environment.CurrentDirectory;
			//file = Path.Combine(path, "listBlock.txt");
			File.WriteAllText(file, cadenaXml);
		}
		public void Deserialize( string file)
		{
			ListBlock = UtilSerializationXml.getObjectOfXml<List<Block>>(file, new Type[]
			                                                     { typeof(Block) });
		}
		/// <summary>
		/// serializacion utilizando json
		/// </summary>
		/// <param name="file"></param>
		public void SerializeJson(string file)
		{
			string cadjson = UtilSerializationXml.SerializeJson(ListBlock);
			File.WriteAllText(file, cadjson);
		}
		
		public void DeserializeJson(string file)
		{
			ListBlock = UtilSerializationXml.getObjectOffJson<List<Block>>(file);
		}
		
		public override string ToString()
		{
			StringBuilder cad = new StringBuilder();
			if (ListBlock == null)
				return string.Empty;
			foreach (var element in ListBlock) {
				cad.Append(element.NameVideo + ", ");
				cad.Append(element.NameThumb + ", ");
				cad.Append(element.Id + ", ");
				cad.Append(element.Asociate + "\n");
			}
			return cad.ToString();
		}
	}
}
