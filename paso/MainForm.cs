/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 17/09/2016
 * Hora: 17:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace paso
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnActionClick(object sender, EventArgs e)
		{
			Util util = new Util();
			util.SearchPanelinForm(this);
			Debug.WriteLine("---------------");
			util.SearchPictureBoxinForm(this);
			Debug.WriteLine("----- func generica -----");
			foreach (var element in util.FindRecursive<Control>(this,Elementos,lookforPictureBox)) {
				Debug.WriteLine(element.Name);
			}
			
		}
		
		private bool lookforPictureBox(Control c){return c is PictureBox;}
		private Control.ControlCollection Elementos(Control c){return c.Controls;}
	}
}
