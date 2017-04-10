/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 08/04/2017
 * Hora: 16:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace CustomFormat
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
		public void ConfigureServices(IServiceCollection services)
		{
			// Add framework services.
			services.AddMvc(options => {
				options.InputFormatters.Add(new YamlInputFormatter(new DeserializerBuilder().WithNamingConvention(namingConvention: new CamelCaseNamingConvention()).Build()));
				options.OutputFormatters.Add(new YamlOutputFormatter(new SerializerBuilder().WithNamingConvention(namingConvention: new CamelCaseNamingConvention()).Build()));
				options.FormatterMappings.SetMediaTypeMappingForFormat("yaml", MediaTypeHeaderValues.ApplicationYaml);
			});
		}
	
		[FormatFilter]
		[HttpGet]
		[HttpGet("/api/[controller].{format}")]
		public IEnumerable<Geek> Get()
		{
			return new List<Geek>() 
			{
				new Geek() {
					Id = 1,
					Name = "Fiyaz",
					Expertise = "Javascript",
					Rating = 3.0M
				},
				new Geek() { Id = 2, Name = "Rick", Expertise = ".Net", Rating = 5.0M }
			};
		}
	}
}