/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 15:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of redGUI.
	/// </summary>
	public partial class RedGUI : Form
	{
		IInput input;
		public RedGUI(IInput input)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.input = input;
			this.BackColor = Color.Red;
			this.Show();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void GetInput(){
			this.Text = input.NotifyOutput();
		}
	}
}
