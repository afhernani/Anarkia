/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 24/07/2017
 * Hora: 23:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Wit_test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Label lbres;
		private System.Windows.Forms.TextBox textBox;
		private Wit.Controls.Chart chart1;
		
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
			this.btnAction = new System.Windows.Forms.Button();
			this.lbres = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.chart1 = new Wit.Controls.Chart();
			this.SuspendLayout();
			// 
			// btnAction
			// 
			this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction.Location = new System.Drawing.Point(336, 14);
			this.btnAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(60, 32);
			this.btnAction.TabIndex = 0;
			this.btnAction.Text = "O.K";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnActionClick);
			// 
			// lbres
			// 
			this.lbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbres.Location = new System.Drawing.Point(14, 59);
			this.lbres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbres.Name = "lbres";
			this.lbres.Size = new System.Drawing.Size(382, 54);
			this.lbres.TabIndex = 1;
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(14, 17);
			this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(316, 22);
			this.textBox.TabIndex = 2;
			// 
			// chart1
			// 
			this.chart1.Location = new System.Drawing.Point(14, 118);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(382, 245);
			this.chart1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(410, 377);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.lbres);
			this.Controls.Add(this.btnAction);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wit-test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
