/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 15/05/2017
 * Hora: 21:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace OrderFileMovie
{
	class Program
	{
		static MasterBlock master;
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			SeryMasterBlock();
			// TODO: Implement Functionality Here
			Console.WriteLine("descerializamos");
			DeseMasterBlock();
			Console.WriteLine("Serializado en js a fichero ...");
			SeryMasterBlockJson();
			Console.WriteLine("Deserializa utilizando Json de: ");
			DeserializaJson();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new ManagerBlocksForm());
			}
		}
		public static void SeryMasterBlock()
		{
			master = new MasterBlock();
			master.Add(new Block("Antonio"));
			master.Add(new Block("candela"));
			master.Add(new Block("pepe"));
			master.Add(new Block("dolido"));
			master.Add(new Block("joder"));
			string file = Path.Combine(Environment.CurrentDirectory, "MasterBlock.txt");
			master.Serialize(file);
			Console.WriteLine( master.ToString());
		}
		public static void DeseMasterBlock()
		{
			string file = Path.Combine(Environment.CurrentDirectory, "MasterBlock.txt");
			master = new MasterBlock();
			master.Deserialize(file);
			Console.WriteLine(master.ToString());
		}
		public static void SeryMasterBlockJson()
		{
			string file = Path.Combine(Environment.CurrentDirectory, "MasterBlockJson.txt");
			master.SerializeJson(file);
			Console.WriteLine( master.ToString());
		}
		public static void DeserializaJson()
		{
			string file = Path.Combine(Environment.CurrentDirectory, "MasterBlockJson.txt");
			Console.WriteLine(file);
			master = new MasterBlock();
			master.DeserializeJson(file);
			Console.WriteLine("Resultado obtenidos listados: ");
			Console.WriteLine(master.ToString());
		}
	}
}