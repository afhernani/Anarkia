/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 05/11/2016
 * Hora: 17:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Engine
{
	/// <summary>
	/// Todas las acciones necesarias para obtener los
	/// datos a procesar por la aplicasion.
	/// </summary>
	public class OpenDatos
	{
		
		//constructor privato
		public OpenDatos()
		{
			PathCurrent = string.Empty;
			Files = null;
		}
		public OpenDatos(string currentdir){
			if(Directory.Exists(currentdir)) PathCurrent=currentdir;
			Files = null;
			//ThreadOpenDir();
		}
		//lanza una subtarea.
		public OpenDatos(string currentdir, string filtro){
			if(Directory.Exists(currentdir)) PathCurrent=currentdir;
			Files = null;
			Filtro = filtro;
			ThreadOpenDir();
		}
		/// <summary>
		/// Directorio de inicializacion, string pathroot
		/// </summary>
		string _pathactual;
		/// <summary>
		/// //Directorio actual - current directorio.
		/// </summary>
		public string PathCurrent {
			get{ return _pathactual; }
			set{ _pathactual = value; }
		}
		/// <summary>
		/// lista de ficheros incluidos en el PathCurrent
		/// </summary>
		public string[] Files{ get; set; }
		
		Task t;
		/// <summary>
		/// delegado FilesHandler,
		/// event CompletedFiles.
		/// </summary>
		public void ThreadOpenDir()
		{
			try
			{
				//si no existe directorio inicializado, lo establecemos.
				if(String.IsNullOrEmpty(PathCurrent)) OpenDir();
				//si sigue siendo nulo, off lo mejor es salir.
				if(String.IsNullOrEmpty(PathCurrent)) return; 
				OpenDirThread();
				//t = Task.Factory.StartNew(()=>OpenDirThread());
			}
			catch (Exception ex) 
			{
				Debug.WriteLine("ThreadOpenDir -> : "+ex.Message);
			}
		}
		
		public delegate void FilesHandler(object sender, string[] files);
		public event FilesHandler CompletedFiles;
		
		private void OpenDirThread()
		{
			Files = getFiles(PathCurrent);
			OnCompletedFiles(Files);
		}
		private void OnCompletedFiles(string[] files){
			if(CompletedFiles!=null) 
				CompletedFiles(this, files);
		}
		public void OpenDir()
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			DialogResult result = folder.ShowDialog();
			if (result == DialogResult.OK)
			{
				PathCurrent =folder.SelectedPath;	
			}
		}
		public string[] getFiles(string folder)
		{
			PathCurrent = folder;
			string[] files = Directory.GetFiles(folder, "*.*").Where(x => IsExt(Path.GetExtension(x).ToLower())).ToArray();
			//.Where(file => file.ToLower().EndsWith("aspx") || file.ToLower().EndsWith("ascx")).ToArray();
			/* o tambien ...
 			* var filteredFiles = Directory
    			.EnumerateFiles(path) //<--- .NET 4.5
    			.Where(file => file.ToLower().EndsWith("aspx") || file.ToLower().EndsWith("ascx"))
    			.ToList(); 
    		 */
			return files;
		}
		/// <summary>
		/// comprueba que sea una extension pasada por el filtro
		/// </summary>
		/// <param name="ext"></param>
		/// <returns></returns>
		private bool IsExt(string ext)
		{
			// Create an array of filter string
			string[] MultipleFilters = Filtro.Split('|');
			// for each filter find mathing file names
			foreach (string FileFilter in MultipleFilters) {
				// add found file names to array list
				if(FileFilter.Equals(ext)) return true;
			}
			return false;
		}
		
//		private bool IsExtUtil(string ext)
//		{
//			if ((ext == ".flv") || (ext == ".mp4") || (ext == ".avi") || (ext == ".mpeg") || (ext == ".mpg") || (ext == ".wmv") || (ext == ".mov") || (ext == ".ts")) {
//				return true;
//			} else
//				return false;
//		}
		
		public string[] getFiles(string Folder, string Filter)
		{
			return getFiles(Folder, Filter, SearchOption.TopDirectoryOnly);
		}
		
		/// <summary>
		/// Returns file names from given folder that comply to given filters
		/// </summary>
		/// <param name="SourceFolder">Folder with files to retrieve</param>
		/// <param name="Filter">Multiple file filters separated by | character</param>
		/// <param name="searchOption">File.IO.SearchOption, 
		/// could be AllDirectories or TopDirectoryOnly</param>
		/// <returns>Array of FileInfo objects that presents collection of file names that 
		/// meet given filter</returns>
		public string[] getFiles(string Folder, string Filter, 
			System.IO.SearchOption searchOption)
		{
			// ArrayList will hold all file names
			ArrayList alFiles = new ArrayList();
			// Create an array of filter string
			string[] MultipleFilters = Filter.Split('|');
			// for each filter find mathing file names
			foreach (string FileFilter in MultipleFilters) {
				// add found file names to array list
				alFiles.AddRange(Directory.GetFiles(Folder, FileFilter, searchOption));
			}
			// returns string array of relevant file names
			return (string[])alFiles.ToArray(typeof(string));
		}
		
		public string Filtro{get;set;}
		
	}
}
