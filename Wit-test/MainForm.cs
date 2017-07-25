/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 24/07/2017
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Wit.Core;

namespace Wit_test
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
		void BtnActionClick(object sender, EventArgs e)
		{
			double res = PolishExpression.Evaluate(textBox.Text, new double[]{1, 2});
			lbres.Text = res.ToString();
		}
	}
}
