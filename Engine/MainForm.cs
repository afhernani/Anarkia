/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 28/11/2016
 * Hora: 17:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Engine
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ManagerFile manager;
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
		
		void Button1Click(object sender, EventArgs e)
		{
			//avanza.
			textBox1.Clear();
			foreach (var element in manager.Next()) {
				textBox1.Text += element+Environment.NewLine;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			manager = new ManagerFile();
			manager.Filtro=".gif";
			manager.Star();
			foreach (var element in manager.FilesInDirectory(0)) {
				textBox1.Text += element+Environment.NewLine;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			//retrocede
			textBox1.Clear();
			foreach (var element in manager.Previus()) {
				textBox1.Text += element+Environment.NewLine;
			}
		}
	}
}
