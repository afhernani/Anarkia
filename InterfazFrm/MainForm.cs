/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 11/06/2017
 * Hora: 0:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InterfazFrm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form, IForm
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

		#region IForm implementation

		public void ChangeTextBoxText(string text)
		{
			textBox.Text = text;
		}
		
		#endregion
		
		void BtnOtroFormClick(object sender, EventArgs e)
		{
			FAction f = new FAction();
			//esto es una de las claves.
			//lanzarlo con el this como base.
			//puede ser modal o unico con la misma condicion
			//planteada aqui abajo.
			f.Show(this); 
		}
	}
}
