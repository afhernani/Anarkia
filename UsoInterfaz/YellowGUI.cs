/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 16:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsoInterfaz
{
	/// <summary>
	/// Description of YellowGUI.
	/// </summary>
	public partial class YellowGUI : Form
	{
		IInput input;
		public YellowGUI(IInput input)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			InitializeComponent();
			this.input = input;
			this.BackColor = Color.Yellow;
			this.Show();
		}
		public void GetInput()
		{
			this.Text = input.NotifyOutput();
		}
	}
}
