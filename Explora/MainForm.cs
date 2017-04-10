/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 31/03/2017
 * Hora: 15:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace Explora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		UserControlLibrary lib;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lib = new UserControlLibrary();
			lib.FileFounderEvent += fileFound;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Task tarea;
		void BtnActionClick(object sender, EventArgs e)
		{
			btnAction.Enabled = false;
			cs = new CancellationTokenSource();
			richTextBox.AppendText("Buscando: => *"+ txtWhat.Text +"* /(amplia).\n");
			//lib.SearchFileinDirectory(new DirectoryInfo(txtWhere.Text),"*"+txtWhat.Text+"*");
			tarea = new Task(()=>lib.SearchFileinDirectory(new DirectoryInfo(txtWhere.Text),"*"+txtWhat.Text+"*", cs));
			tarea.Start();
		}

		void fileFound(FileInfo file)
		{
			if (this.InvokeRequired) this.Invoke(new Action(() =>
    		{
				//richTextBox.Clear();
	        	if(file !=null){
					richTextBox.AppendText(file.FullName + "\n");
				}else{
					richTextBox.AppendText("End\n");
					btnAction.Enabled = true;
					btnBusca.Enabled = true;
				}
			}));	
		}
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox.Clear();
		}
		void BtnBuscaClick(object sender, EventArgs e)
		{
			btnBusca.Enabled = false;
			cs = new CancellationTokenSource();
			richTextBox.AppendText("Buscando: => "+ txtWhat.Text +"\n");
			tarea = new Task(()=>lib.SearchFileinDirectory(new DirectoryInfo(txtWhere.Text),txtWhat.Text,cs));
			tarea.Start();
		}
		CancellationTokenSource cs = new CancellationTokenSource();
		void BtnCancelClick(object sender, EventArgs e)
		{
			cs.Cancel();
			btnAction.Enabled = true;
			btnBusca.Enabled = true;
		}
	}
}
