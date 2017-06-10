/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 15:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of BlueGUI.
	/// </summary>
	public partial class BlueGUI : Form
	{
		IInput input;
		public BlueGUI(IInput input)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.input = input;
			this.BackColor = Color.Blue;
			this.Show();
		}
		public void GetInput()
		{
			this.Text = input.NotifyOutput();
		}
	}
}
