/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 28/05/2017
 * Hora: 12:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MongoDB.Bson;

namespace monoDb
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		public string nombre{ get; set; }
		public string apellidos{ get; set; }
		public ObjectId _id{ get; set; }
		public Cliente(string nome, string apeli){
			this.nombre = nome;
			this.apellidos = apeli;
		}
		public Cliente(){
			
		}
		public override string ToString()
		{
			return string.Format("[Cliente Nombre={0}, Apellidos={1}, Id={2}]", nombre, apellidos, _id);
		}

	}
}
