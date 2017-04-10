/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 06/04/2017
 * Hora: 10:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ffutility
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
		void BtnRunClick(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxfile.Text))
				return;
			Converter conv = new Converter();
			videofile = conv.GetVideoInfo(textBoxfile.Text);
			StringBuilder build = new StringBuilder();
			build.AppendLine(videofile.Duration.ToString());
			build.AppendLine(videofile.DurationMs.ToString());
			build.AppendLine(videofile.Path);
			build.AppendLine(videofile.Height.ToString());
			textBoxdatos.Text = build.ToString();
			outputpack = conv.StrackImages(videofile,(int)numericValor.Value);
			LoadImageToPicture(0);
			textBoxdatos.Text += newline + outputpack.ListImage.Count.ToString() + newline;
			btnConvert.Enabled = true;
			btnmakeGif.Enabled = true;
		}
		VideoFile videofile;
		OutputPackage outputpack;
		int Index { get; set; }
		private void LoadImageToPicture(int index){
			if (outputpack.ListImage.Count == 0)
				return;
			pictureBox.Image = outputpack.ListImage[index];
		}
		void PictureBoxClick(object sender, EventArgs e)
		{
			if (outputpack == null)
				return;
			Index++;
			if(Index < outputpack.ListImage.Count){
			}else{
				Index = 0;
			}
			LoadImageToPicture(Index);
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Index = 0;
			btnConvert.Enabled = false;
			btnmakeGif.Enabled = false;
		}
		void BtnConvertClick(object sender, EventArgs e)
		{
			Converter conv = new Converter();
			OutputPackage package = conv.ConvertToFLV(videofile);
			outputpack.VideoStream = package.VideoStream;
			string filename = Path.Combine(Environment.CurrentDirectory, 
			                               string.Format("{0}.flv", System.Guid.NewGuid().ToString()));
			Converter.SaveMemoryStreamToFile(outputpack.VideoStream, filename);
			Debug.WriteLine("Name-File:=> "+ filename);
			textBoxdatos.Text += newline + "Convert file: => " + filename + Environment.NewLine;
			btnConvert.Enabled = false;
		}
		string newline = Environment.NewLine;
		void BtnmakeGifClick(object sender, EventArgs e)
		{
			// Todo: aqui
			//
			Converter conv = new Converter(); //instancia converter.-inicializa.
			conv.FrameRate = 2;
			OutputPackage package = conv.MakeGif(videofile, (int)numericValor.Value);
			outputpack.ListImage.Add((Image)package.PreviewImage.Clone());
			pictureBox.Image = (Image)package.PreviewImage.Clone();
			textBoxdatos.Text += newline + "Make-gif from file: => " + Path.GetFileName(videofile.Path) + Environment.NewLine;
			//
			btnmakeGif.Enabled = false;
		}
	}
}
