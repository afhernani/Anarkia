/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 15:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UsoInterfaz
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
		private void button1_Click(object sender, System.EventArgs e)
		{
			// Input XML file to Blue GUI
			if ((radioButtonBlueGUI.Checked) && (radioButtonXMLinput.Checked))
			{
				IInput input = new XMLInput();
				BlueGUI blueGUI = new BlueGUI(input);
				blueGUI.GetInput();
			}

			// Input XML file to Red GUI
			if ((radioButtonRedGUI.Checked) && (radioButtonXMLinput.Checked))
			{
				IInput input = new XMLInput();
				RedGUI redGUI = new RedGUI(input);
				redGUI.GetInput();
			}
			
			// Input XML file to Yellow GUI
			if ((radioButtonYellowGUI.Checked) && (radioButtonXMLinput.Checked))
			{
				IInput input = new XMLInput();
				YellowGUI yellowGUI = new YellowGUI(input);
				yellowGUI.GetInput();
			}
			
			// Input INI file to Blue GUI
			if ((radioButtonIniInput.Checked) && (radioButtonBlueGUI.Checked))
			{
				IInput input = new INIInput();
				BlueGUI blueGUI = new BlueGUI(input);
				blueGUI.GetInput();
			}

			// Input INI file to Red GUI
			if ((radioButtonIniInput.Checked) && (radioButtonRedGUI.Checked))
			{
				IInput input = new INIInput();
				RedGUI redGUI = new RedGUI(input);
				redGUI.GetInput();
			}

			// Input INI file to Yellow GUI
			if ((radioButtonIniInput.Checked) && (radioButtonYellowGUI.Checked))
			{
				IInput input = new INIInput();
				YellowGUI yellowGUI = new YellowGUI(input);
				yellowGUI.GetInput();			
			}

			// Input Bin file to Blue GUI
			if ((radioButtoBinInput.Checked) && (radioButtonBlueGUI.Checked))
			{
				IInput input = new BinInput();
				BlueGUI blueGUI = new BlueGUI(input);
				blueGUI.GetInput();			
			}
			
			// Input Bin file to Red GUI
			if ((radioButtoBinInput.Checked) && (radioButtonRedGUI.Checked))
			{
				IInput input = new BinInput();
				RedGUI redGUI = new RedGUI(input);
				redGUI.GetInput();			
			}

			// Input Bin file to Yellow GUI
			if ((radioButtoBinInput.Checked) && (radioButtonYellowGUI.Checked))
			{
				IInput input = new BinInput();
				YellowGUI yellowGUI = new YellowGUI(input);
				yellowGUI.GetInput();			
			}			
		}
	}
}
