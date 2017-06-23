/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 14:20
 * 
 * 
 */
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ImageFrame
{
	/// <summary>
	/// Description of SpritePane.
	/// </summary>
	[Serializable, XmlRoot("SpritePane", Namespace = "", IsNullable = false)]
	public partial class SpritePane : UserControl
	{
		public SpritePane()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			_index = 0;
			Time = 800;
			Accion = false;
		}
		public SpritePane(string path)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			_imagegif = new ImageGif(path);
			_index = 0;
			Time = 800;
			Accion = false;
			InitialImage(0);
		}
		
		private Thread t;
		private ImageGif _imagegif = null;
		private int _index = 0;
		public Image GetImage 
		{
			get{ return (Image)_imagegif.GetFrame(_index).Clone(); }
		}
		
		public ImageGif SetImageGif
		{ 
			set { 
				_imagegif = value;
				InitialImage(0);
			}
		}
		
		private void ActionImagen()
		{
			do {
				
				Image newImage = new Bitmap(this.Width, this.Height, PixelFormat.Format64bppPArgb);
                
				using (Graphics g = this.CreateGraphics()) {
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.InterpolationMode = InterpolationMode.HighQualityBicubic;
					g.PixelOffsetMode = PixelOffsetMode.HighQuality;
					g.DrawImage(_imagegif.GetNextFrame(), 0, 0,
						new RectangleF(0, 0,
							this.Width, this.Height), GraphicsUnit.Pixel);
				}
				Debug.WriteLine("dibujando image ...{" + _imagegif.CurrentFrame + "}");
				Thread.Sleep(Time);
				
                
			} while (Accion);
		}
		//[XmlSerializable]
		private bool Accion{ get; set; }
		
		public void InitialImage(int index)
		{
			Image newImage = new Bitmap(this.Width, this.Height, PixelFormat.Format64bppPArgb);
                
			using (Graphics g = this.CreateGraphics()) {
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.InterpolationMode = InterpolationMode.HighQualityBicubic;
				g.PixelOffsetMode = PixelOffsetMode.HighQuality;
				g.DrawImage(_imagegif.GetFrame(index), 0, 0,
					new RectangleF(0, 0,
						this.Width, this.Height), GraphicsUnit.Pixel);
			}
			Debug.WriteLine("dibujando imagen de inicio ...{" + _imagegif.CurrentFrame + "}");
		}
		//[XmlSerializable]
		public int Time { get; set; }
		
		void SpritePaneMouseHover(object sender, EventArgs e)
		{
			if (t != null)
			if (t.IsAlive)
				return;
			if (_imagegif == null)
				return;
			System.Action action = ActionImagen;
			t = new Thread(ActionImagen);
			t.Start();
		}
		void SpritePaneMouseEnter(object sender, EventArgs e)
		{
			Debug.WriteLine("MouseEnter ...");
			Accion = true;
		}
		void SpritePaneMouseLeave(object sender, EventArgs e)
		{
			Debug.WriteLine("Mouseleave ...");
			Accion = false;
			if (t != null)
				t.Abort();
		}
	}
}
