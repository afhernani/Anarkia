/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 11/06/2017
 * Hora: 0:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace InterfazFrm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button btnOtroForm;
		
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.btnOtroForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(12, 12);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(434, 26);
			this.textBox.TabIndex = 0;
			// 
			// btnOtroForm
			// 
			this.btnOtroForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOtroForm.Location = new System.Drawing.Point(12, 54);
			this.btnOtroForm.Name = "btnOtroForm";
			this.btnOtroForm.Size = new System.Drawing.Size(91, 33);
			this.btnOtroForm.TabIndex = 1;
			this.btnOtroForm.Text = "Form-Action";
			this.btnOtroForm.UseVisualStyleBackColor = true;
			this.btnOtroForm.Click += new System.EventHandler(this.BtnOtroFormClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 99);
			this.Controls.Add(this.btnOtroForm);
			this.Controls.Add(this.textBox);
			this.Name = "MainForm";
			this.Text = "InterfazFrm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
