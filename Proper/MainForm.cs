/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/04/2017
 * Hora: 15:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Proper
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
		//aqui introducimos algun codigo.
		// <summary>
        /// creamos propiedades de valores almacenados en las etiquetas.
        /// </summary>
        private void createProperties()
        {
            string namefile = Path.Combine(Environment.CurrentDirectory, "dat.pro");
            //si no existe el fichero la clase lo crea.
            Utility.Properties.Properties propy = new Utility.Properties.Properties(namefile);
			//string paso = txtUrl.Text.Replace("\n", "|");
            propy.set("homepage",txtUrl.Text);
			propy.set("texto", txtBoxResult.Text.Replace(newling, "|"));
            propy.set("fileTemporal",namefile);
            propy.Save();
        }
		string newling = Environment.NewLine;
        // <summary>
        /// load datos from file properties.
        /// </summary>
        private void leefileProperties()
        {
            string namefile = Path.Combine(Environment.CurrentDirectory, "dat.pro");
            if (!File.Exists(namefile)) return;
            Utility.Properties.Properties propy = new Utility.Properties.Properties(namefile);
            txtBoxResult.Text = propy.get("texto").Replace("|",newling) + newling;
			txtUrl.Text = propy.get("homepage");
            this.Text += "fichero temporal: "+propy.get("fileTemporal") + newling;            
            Debug.WriteLine("load datos from propeties file....");
        }
        /// <summary>
        /// Action boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void btnAction_Click(object sender, EventArgs e)
		{
			createProperties();
		}
		void Button1Click(object sender, EventArgs e)
		{
			txtBoxResult.Text = "";
			txtUrl.Text = "";
		}
		void BtnLeeClick(object sender, EventArgs e)
		{
			leefileProperties();
		} 
	}
}
