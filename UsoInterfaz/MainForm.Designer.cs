/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/06/2017
 * Hora: 15:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace UsoInterfaz
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButtonXMLinput;
		private System.Windows.Forms.RadioButton radioButtonIniInput;
		private System.Windows.Forms.RadioButton radioButtoBinInput;
		private System.Windows.Forms.RadioButton radioButtonRedGUI;
		private System.Windows.Forms.RadioButton radioButtonBlueGUI;
		private System.Windows.Forms.RadioButton radioButtonYellowGUI;
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtoBinInput = new System.Windows.Forms.RadioButton();
			this.radioButtonIniInput = new System.Windows.Forms.RadioButton();
			this.radioButtonXMLinput = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonYellowGUI = new System.Windows.Forms.RadioButton();
			this.radioButtonRedGUI = new System.Windows.Forms.RadioButton();
			this.radioButtonBlueGUI = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(152, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Drive";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButtoBinInput);
			this.groupBox1.Controls.Add(this.radioButtonIniInput);
			this.groupBox1.Controls.Add(this.radioButtonXMLinput);
			this.groupBox1.ForeColor = System.Drawing.Color.Red;
			this.groupBox1.Location = new System.Drawing.Point(304, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 248);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pick Service Provider";
			// 
			// radioButtoBinInput
			// 
			this.radioButtoBinInput.ForeColor = System.Drawing.Color.Red;
			this.radioButtoBinInput.Location = new System.Drawing.Point(24, 188);
			this.radioButtoBinInput.Name = "radioButtoBinInput";
			this.radioButtoBinInput.Size = new System.Drawing.Size(57, 16);
			this.radioButtoBinInput.TabIndex = 2;
			this.radioButtoBinInput.Text = "Bin file";
			// 
			// radioButtonIniInput
			// 
			this.radioButtonIniInput.ForeColor = System.Drawing.Color.Red;
			this.radioButtonIniInput.Location = new System.Drawing.Point(24, 115);
			this.radioButtonIniInput.Name = "radioButtonIniInput";
			this.radioButtonIniInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radioButtonIniInput.Size = new System.Drawing.Size(61, 16);
			this.radioButtonIniInput.TabIndex = 1;
			this.radioButtonIniInput.Text = "Ini file";
			// 
			// radioButtonXMLinput
			// 
			this.radioButtonXMLinput.ForeColor = System.Drawing.Color.Red;
			this.radioButtonXMLinput.Location = new System.Drawing.Point(26, 38);
			this.radioButtonXMLinput.Name = "radioButtonXMLinput";
			this.radioButtonXMLinput.Size = new System.Drawing.Size(64, 18);
			this.radioButtonXMLinput.TabIndex = 0;
			this.radioButtonXMLinput.Text = "XML file";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.radioButtonYellowGUI);
			this.groupBox2.Controls.Add(this.radioButtonRedGUI);
			this.groupBox2.Controls.Add(this.radioButtonBlueGUI);
			this.groupBox2.ForeColor = System.Drawing.Color.Red;
			this.groupBox2.Location = new System.Drawing.Point(16, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(96, 240);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pick Client";
			// 
			// radioButtonYellowGUI
			// 
			this.radioButtonYellowGUI.ForeColor = System.Drawing.Color.Red;
			this.radioButtonYellowGUI.Location = new System.Drawing.Point(11, 187);
			this.radioButtonYellowGUI.Name = "radioButtonYellowGUI";
			this.radioButtonYellowGUI.Size = new System.Drawing.Size(80, 16);
			this.radioButtonYellowGUI.TabIndex = 4;
			this.radioButtonYellowGUI.Text = "YellowGUI";
			// 
			// radioButtonRedGUI
			// 
			this.radioButtonRedGUI.ForeColor = System.Drawing.Color.Red;
			this.radioButtonRedGUI.Location = new System.Drawing.Point(18, 114);
			this.radioButtonRedGUI.Name = "radioButtonRedGUI";
			this.radioButtonRedGUI.Size = new System.Drawing.Size(78, 19);
			this.radioButtonRedGUI.TabIndex = 3;
			this.radioButtonRedGUI.Text = "RedGUI";
			// 
			// radioButtonBlueGUI
			// 
			this.radioButtonBlueGUI.ForeColor = System.Drawing.Color.Red;
			this.radioButtonBlueGUI.Location = new System.Drawing.Point(16, 40);
			this.radioButtonBlueGUI.Name = "radioButtonBlueGUI";
			this.radioButtonBlueGUI.Size = new System.Drawing.Size(72, 16);
			this.radioButtonBlueGUI.TabIndex = 2;
			this.radioButtonBlueGUI.Text = "BlueGUI";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(442, 272);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "InterfaceDemo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
