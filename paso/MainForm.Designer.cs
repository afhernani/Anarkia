/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 17/09/2016
 * Hora: 17:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace paso
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.tabControl1);
			this.panel5.Controls.Add(this.panel1);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Location = new System.Drawing.Point(23, 22);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(554, 330);
			this.panel5.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(21, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(55, 65);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(28, 367);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 20);
			this.textBox1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(68, 402);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(463, 502);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(114, 23);
			this.btnAction.TabIndex = 8;
			this.btnAction.Text = "button2";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnActionClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(38, 191);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(95, 110);
			this.panel1.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(162, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(361, 273);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(353, 247);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(353, 247);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.webBrowser1);
			this.tabPage3.Controls.Add(this.listBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(353, 247);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.pictureBox3);
			this.tabPage4.Controls.Add(this.progressBar1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(353, 247);
			this.tabPage4.TabIndex = 4;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.panel4);
			this.tabPage5.Controls.Add(this.propertyGrid1);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(353, 247);
			this.tabPage5.TabIndex = 5;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(23, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(123, 86);
			this.panel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(23, 142);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 81);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(41, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(199, 91);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(25, 132);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(62, 100);
			this.panel3.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(130, 131);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(197, 88);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(22, 22);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(117, 17);
			this.listBox1.TabIndex = 0;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(31, 65);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(241, 132);
			this.webBrowser1.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(26, 56);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(214, 14);
			this.progressBar1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(28, 82);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(211, 104);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Location = new System.Drawing.Point(21, 30);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(109, 191);
			this.propertyGrid1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(162, 35);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(137, 107);
			this.panel4.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 537);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel5);
			this.Name = "MainForm";
			this.Text = "paso";
			this.panel5.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
