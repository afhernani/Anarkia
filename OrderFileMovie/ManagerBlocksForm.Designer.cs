/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 13/06/2017
 * Hora: 21:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace OrderFileMovie
{
	partial class ManagerBlocksForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBoxSelect;
		private System.Windows.Forms.RadioButton radioButtonR;
		private System.Windows.Forms.RadioButton radioButtonC;
		private System.Windows.Forms.RadioButton radioButtonM;
		private System.Windows.Forms.GroupBox groupBoxFiles;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRename;
		private System.Windows.Forms.TextBox textBoxFile;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Button btnCancel;
		
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
			this.groupBoxSelect = new System.Windows.Forms.GroupBox();
			this.radioButtonR = new System.Windows.Forms.RadioButton();
			this.radioButtonC = new System.Windows.Forms.RadioButton();
			this.radioButtonM = new System.Windows.Forms.RadioButton();
			this.groupBoxFiles = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRename = new System.Windows.Forms.TextBox();
			this.textBoxFile = new System.Windows.Forms.TextBox();
			this.btnAction = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBoxSelect.SuspendLayout();
			this.groupBoxFiles.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxSelect
			// 
			this.groupBoxSelect.Controls.Add(this.radioButtonR);
			this.groupBoxSelect.Controls.Add(this.radioButtonC);
			this.groupBoxSelect.Controls.Add(this.radioButtonM);
			this.groupBoxSelect.Location = new System.Drawing.Point(12, 12);
			this.groupBoxSelect.Name = "groupBoxSelect";
			this.groupBoxSelect.Size = new System.Drawing.Size(213, 62);
			this.groupBoxSelect.TabIndex = 0;
			this.groupBoxSelect.TabStop = false;
			this.groupBoxSelect.Text = "Select Operation";
			// 
			// radioButtonR
			// 
			this.radioButtonR.Location = new System.Drawing.Point(130, 19);
			this.radioButtonR.Name = "radioButtonR";
			this.radioButtonR.Size = new System.Drawing.Size(104, 24);
			this.radioButtonR.TabIndex = 2;
			this.radioButtonR.TabStop = true;
			this.radioButtonR.Text = "Rename";
			this.radioButtonR.UseVisualStyleBackColor = true;
			// 
			// radioButtonC
			// 
			this.radioButtonC.Location = new System.Drawing.Point(68, 19);
			this.radioButtonC.Name = "radioButtonC";
			this.radioButtonC.Size = new System.Drawing.Size(104, 24);
			this.radioButtonC.TabIndex = 1;
			this.radioButtonC.TabStop = true;
			this.radioButtonC.Text = "Copy";
			this.radioButtonC.UseVisualStyleBackColor = true;
			// 
			// radioButtonM
			// 
			this.radioButtonM.Location = new System.Drawing.Point(6, 19);
			this.radioButtonM.Name = "radioButtonM";
			this.radioButtonM.Size = new System.Drawing.Size(104, 24);
			this.radioButtonM.TabIndex = 0;
			this.radioButtonM.TabStop = true;
			this.radioButtonM.Text = "Move";
			this.radioButtonM.UseVisualStyleBackColor = true;
			this.radioButtonM.Click += new System.EventHandler(this.RadioButtonMClick);
			// 
			// groupBoxFiles
			// 
			this.groupBoxFiles.Controls.Add(this.label1);
			this.groupBoxFiles.Controls.Add(this.textBoxRename);
			this.groupBoxFiles.Controls.Add(this.textBoxFile);
			this.groupBoxFiles.Location = new System.Drawing.Point(12, 92);
			this.groupBoxFiles.Name = "groupBoxFiles";
			this.groupBoxFiles.Size = new System.Drawing.Size(250, 120);
			this.groupBoxFiles.TabIndex = 1;
			this.groupBoxFiles.TabStop = false;
			this.groupBoxFiles.Text = "select file";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rename file:";
			// 
			// textBoxRename
			// 
			this.textBoxRename.Location = new System.Drawing.Point(13, 81);
			this.textBoxRename.Name = "textBoxRename";
			this.textBoxRename.Size = new System.Drawing.Size(214, 20);
			this.textBoxRename.TabIndex = 1;
			// 
			// textBoxFile
			// 
			this.textBoxFile.Location = new System.Drawing.Point(13, 26);
			this.textBoxFile.Name = "textBoxFile";
			this.textBoxFile.Size = new System.Drawing.Size(214, 20);
			this.textBoxFile.TabIndex = 0;
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(174, 218);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(88, 27);
			this.btnAction.TabIndex = 2;
			this.btnAction.Text = "O.K.";
			this.btnAction.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(80, 218);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 27);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// ManagerBlocksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 257);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.groupBoxFiles);
			this.Controls.Add(this.groupBoxSelect);
			this.Name = "ManagerBlocksForm";
			this.Text = "Manager-View";
			this.groupBoxSelect.ResumeLayout(false);
			this.groupBoxFiles.ResumeLayout(false);
			this.groupBoxFiles.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
