/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 19/09/2016
 * Hora: 12:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace workdelegados
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Action;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
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
			this.Action = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Action
			// 
			this.Action.Location = new System.Drawing.Point(568, 512);
			this.Action.Name = "Action";
			this.Action.Size = new System.Drawing.Size(107, 29);
			this.Action.TabIndex = 0;
			this.Action.Text = "Action";
			this.Action.UseVisualStyleBackColor = true;
			this.Action.Click += new System.EventHandler(this.ActionClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(24, 17);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(650, 489);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 553);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.Action);
			this.Name = "MainForm";
			this.Text = "workdelegados";
			this.ResumeLayout(false);

		}
	}
}
