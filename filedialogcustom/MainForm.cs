/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 09/09/2017
 * Hora: 16:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace filedialogcustom
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
			openFileDialog1 = new OpenFileDialog();
			InitializeDialogAndButton();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private OpenFileDialog openFileDialog1;
		private Button button1;

		private void InitializeDialogAndButton()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button1.Location = new System.Drawing.Point(53, 37);
			this.button1.AutoSize = true;
			this.button1.Text = "Show dialog with custom places.";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.Controls.Add(this.button1);
		}

		private void button1_Click(object sender, EventArgs e)
		{

			// Add Windows custom place using file path.
			openFileDialog1.CustomPlaces.Add(@"C:\Users\hernani\Storage\Videos");

			openFileDialog1.ShowDialog();
		}
	}
}
