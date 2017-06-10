/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 11/06/2017
 * Hora: 0:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfazFrm
{
	/// <summary>
	/// Description of FAction.
	/// </summary>
	public partial class FAction : Form
	{
		public FAction()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnOkClick(object sender, EventArgs e)
		{
			//hacemos un castin y transformamos el formulario en una
			//interfaz.
			IForm forminterfas = this.Owner as IForm;
			if (forminterfas != null)
				forminterfas.ChangeTextBoxText(this.textBox1.Text+" :)");
		}
	}
}
