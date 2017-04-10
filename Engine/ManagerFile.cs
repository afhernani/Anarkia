/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 28/11/2016
 * Hora: 21:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Engine
{
	/// <summary>
	/// Description of ManagerFile.
	/// </summary>
	public class ManagerFile
	{
		private List<OpenDatos> _directorios;// = new List<OpenDatos>();
		
		public ManagerFile()
		{
			Root = string.Empty;
			OpenDatos open = new OpenDatos();
			open.OpenDir();
			Root = open.PathCurrent;
			Directorios = new List<OpenDatos>();
			Filtro =string.Empty;
			Index=0;
		}
		
		public ManagerFile(string root)
		{
			if(Directory.Exists(root)) Root = root;
			Directorios = new List<OpenDatos>();
			Filtro =string.Empty;
			Index=0;
		}
		
		// disable once ConvertToAutoProperty
		public List<OpenDatos> Directorios{
			get{return _directorios;}
			set{_directorios=value;}
		}
		
		public string Root{get;set;}
		public string Filtro{get;set;}
		private int Index;
		public string[] Next()
		{
			if (Directorios != null && Directorios.Count != 0) {
				if (Index < Directorios.Count - 1) {
					Index++;
					return FilesInDirectory(Index);
				} else {
					Index = 0;
					return FilesInDirectory(Index);
				}
			}
			return null;
		}
		
		public string[] Previus()
		{
			if (Directorios != null && Directorios.Count != 0) {
				if (Index >= 1) {
					Index--;
					return FilesInDirectory(Index);
				} else {
					Index =Directorios.Count - 1;
					return FilesInDirectory(Index);
				}
			}
			return null;
		}
		
		public string[] FilesInDirectory(int index)
		{
			return Directorios[index].Files;
		}
		
		public void Star()
        {
            Debug.WriteLine("into a Searching directory: {"+Root+"}.");
            if (String.IsNullOrEmpty(Root)||String.IsNullOrEmpty(Filtro)) return;
            try
            {
                foreach (string d in Directory.GetDirectories(Root))
                {
                	OpenDatos datos = new OpenDatos(d, Filtro);
                	datos.CompletedFiles += AddOpenDatosToListDatos;
                	Directorios.Add(datos);
                }
            }
            catch (System.Exception excpt)
            {
                Debug.WriteLine(excpt.Message);
            }
        }
		//para que sea multitarea hay que añadir a la respuesta
		//del evento con invocasion completedfiles.-conforme a
		//invocación.
		void AddOpenDatosToListDatos(object sender, string[] files)
		{
			Debug.WriteLine(((OpenDatos)sender).PathCurrent);
		}
	}
}
