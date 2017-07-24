/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/07/2017
 * Hora: 23:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Tasker
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
			//CheckForIllegalCrossThreadCalls = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		Task t;
		
		void BtnActionClick(object sender, EventArgs e)
		{
			
			t = Task.Factory.StartNew(TareasPropuestas);
			//t.Start();
		}
		private void TareasPropuestas()
		{		
			for (int i = 0; i < 10; i++) {
				if(InvokeRequired)
					Invoke(new Action(()=>textBox.Text = i.ToString()));
			}
			for (int i = 0; i < 19; i++) {
				
				if(InvokeRequired)
					Invoke(new Action(()=>listBox.Items.Add(i)));
			}
		}
		
			
	}
}
