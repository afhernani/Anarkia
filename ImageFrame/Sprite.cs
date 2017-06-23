/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 16:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageFrame
{
	/// <summary>
	/// Description of Sprite.
	/// </summary>
	public partial class Sprite : Form
	{
		public Sprite()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string filename = string.Empty;
		string name_Only;
		
		void SpritePane1Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog() {
				Filter = "Gif file(*.gif*)|*.gif",
				Title = @"Open gif to load",
				InitialDirectory = Environment.CurrentDirectory,
				RestoreDirectory = true
			};
			
			if (openfile.ShowDialog() == DialogResult.OK) {
				filename = openfile.FileName;
				name_Only = openfile.SafeFileName;
				if (Path.GetExtension(filename).ToUpper().Equals(".GIF")) {
					//imagegif = new ImageGif(filename);
					spritePane1.SetImageGif = new ImageGif(filename);
					//label.Text = imagegif.Count.ToString();
					spritePane1.SizeMode = PictureBoxSizeMode.Zoom;
				}
			}
		}
	}
}
