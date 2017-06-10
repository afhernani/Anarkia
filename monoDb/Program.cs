/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/05/2017
 * Hora: 20:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace monoDb
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello MongoDB!");
			MongoClient mc = new MongoClient("mongodb://localhost");
			MongoServer mongo = mc.GetServer();
			var bbdds = mongo.GetDatabaseNames();
			Console.WriteLine("bases de datos existentes.");
			foreach (var ddbb in bbdds) {
				Console.WriteLine(ddbb);
			}
			Console.WriteLine("*Tabla*");
			MongoDatabase db = mongo.GetDatabase("test");
			//vamos añadir clientes a esta table.
			//creamos el objeto a añadir. - nombres -
			//Cliente cliente = new Cliente("Ana", "Sosa Aleman");
			
			MongoCollection colectionCliente = db.GetCollection("Clientes");
			//insertamos el cliente en la colección -tabla-
			//colectionCliente.Insert(cliente);
			
			//consulta a la base de datos con metodo query ****
			IMongoQuery filtro = Query<Cliente>.EQ(clt => clt.nombre, "Hernani");
			MongoCursor clientes = colectionCliente.FindAs<Cliente>(filtro);
			
			foreach (Cliente col in clientes) {
				Console.WriteLine(col.ToJson());
			}
			
			//otra consulta usando linq de csharp ****
			
			var clients = colectionCliente.AsQueryable<Cliente>();
			var res = from c in clients
				where c.nombre.ToLower() == "hernani" || c.apellidos.StartsWith("Ale")
			          select c;
			//de esta forma obtenemos todos los registros de la lista.
			foreach (Cliente element in clients) 
			{
				Console.WriteLine(element.ToJson());
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}