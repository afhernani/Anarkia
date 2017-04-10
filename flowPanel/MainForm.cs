/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 20/09/2016
 * Hora: 21:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace flowPanel
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
		void MainFormLoad(object sender, EventArgs e)
		{
			Debug.WriteLine("Inicializado el formulario.");
			scroll();
		}
		void AddControl(){
			for (int i = 0; i < 30; i++) {
				Button btn = new Button(){
					Width=120,
					Height=80,
					BackColor =Color.Bisque
				};
				flowLayoutPanel1.Controls.Add(btn);
			}
			Debug.WriteLine("controles cargados en flowlayoutpanel");
			scroll();
			label1.Text=flowLayoutPanel1.Controls.Count.ToString();
		}
		int n=0;
		void FlowLayoutPanel1ControlAdded(object sender, ControlEventArgs e)
		{
			//if(sender==null) sender=new object[]{"sin informacion"};
			Debug.WriteLine("Se ha añadido un control al {0}", n++);//, typeof());
			
		}
		private void scroll(){
			int valor = flowLayoutPanel1.VerticalScroll.Value;
			Debug.WriteLine("Valor verticalScroll = {0}", valor);
			Debug.WriteLine("LargeChange ={0}",
			                flowLayoutPanel1.VerticalScroll.LargeChange);
			Debug.WriteLine("Maximum = {0}",flowLayoutPanel1.VerticalScroll.Maximum);
			Debug.WriteLine("Minimum = {0}",flowLayoutPanel1.VerticalScroll.Minimum);
		}
		void BtnpulsaClick(object sender, EventArgs e)
		{
			Debug.WriteLine("----------pulsa-------------");
			scroll();
		}
		void BtnAddClick(object sender, EventArgs e)
		{
			Debug.WriteLine("----------add-------------");
			AddControl();
		}
		void BtnVisibleClick(object sender, EventArgs e)
		{
			Debug.WriteLine("---------visible-------------");
			flowLayoutPanel1.AutoScroll=!flowLayoutPanel1.AutoScroll;
			//flowLayoutPanel1.VerticalScroll.Enabled=!(flowLayoutPanel1.VerticalScroll.Enabled);
			//flowLayoutPanel1.VerticalScroll.Visible= !(flowLayoutPanel1.VerticalScroll.Visible);
		}
		void FlowLayoutPanel1Scroll(object sender, ScrollEventArgs e)
		{
			Debug.WriteLine("evnt Scroll de la barra");
			if(sender == null) return;
			FlowLayoutPanel sen = (FlowLayoutPanel)sender;
			Debug.WriteLine("{0}",sen.Name);
			if(sender is ScrollBar){
				//ScrollBar bar = (ScrollBar) sender;
				Debug.WriteLine("is a scrollbar");
			}
			if(sender is FlowLayoutPanel){
				Debug.WriteLine("is a FlowLayoutPanel");
			}
			Debug.WriteLine("Observando scrollEventArgs");
			Debug.WriteLine("{0}", e.NewValue); //valor de cambio de la barra.
			Debug.WriteLine("{0}", e.Type);
			scroll();
		}
	}
}
