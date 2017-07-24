/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/07/2017
 * Hora: 23:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Tasker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button btnAction;
		
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
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnAction = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(9, 13);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(314, 22);
			this.textBox.TabIndex = 0;
			// 
			// listBox
			// 
			this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(9, 52);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(314, 180);
			this.listBox.TabIndex = 1;
			// 
			// btnAction
			// 
			this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction.Location = new System.Drawing.Point(343, 259);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(72, 26);
			this.btnAction.TabIndex = 2;
			this.btnAction.Text = "Run";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnActionClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 297);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.textBox);
			this.Name = "MainForm";
			this.Text = "Tasker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
