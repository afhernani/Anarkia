/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 30/09/2017
 * Hora: 20:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace playsound
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
		void MainFormClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Audio Files (.wav)|*.wav|Audio Files (.mp3)|*.mp3";


			if (dialog.ShowDialog() == DialogResult.OK) {
				string path = dialog.FileName;
				playProcess(path);
			}
		}
		private void playSound(string path)
		{
			System.Media.SoundPlayer player = 
				new System.Media.SoundPlayer();
			player.SoundLocation = path;
			player.Load();
			player.Play();
		}
		private void playMedia(string path)
		{
			
			
		}
		private void playProcess(string path)
		{
			Process.Start(path);
		}
	}
}
