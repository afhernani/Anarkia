﻿/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 03/07/2017
 * Hora: 23:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DosLenguas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.TextBox textIng;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textEsp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnIngles;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.RadioButton rdIng;
		private System.Windows.Forms.RadioButton rdEsp;
		private System.Windows.Forms.RadioButton rdAdd;
		
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
			this.btStart = new System.Windows.Forms.Button();
			this.textIng = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textEsp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnIngles = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.rdIng = new System.Windows.Forms.RadioButton();
			this.rdEsp = new System.Windows.Forms.RadioButton();
			this.rdAdd = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btStart
			// 
			this.btStart.BackColor = System.Drawing.Color.Red;
			this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btStart.Location = new System.Drawing.Point(361, 237);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(66, 30);
			this.btStart.TabIndex = 0;
			this.btStart.Text = "Conectar";
			this.btStart.UseVisualStyleBackColor = false;
			this.btStart.Click += new System.EventHandler(this.BtStartClick);
			// 
			// textIng
			// 
			this.textIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textIng.Location = new System.Drawing.Point(12, 35);
			this.textIng.Name = "textIng";
			this.textIng.Size = new System.Drawing.Size(366, 24);
			this.textIng.TabIndex = 1;
			this.textIng.TextChanged += new System.EventHandler(this.TextIngTextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ingles";
			// 
			// textEsp
			// 
			this.textEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEsp.Location = new System.Drawing.Point(12, 85);
			this.textEsp.Name = "textEsp";
			this.textEsp.ReadOnly = true;
			this.textEsp.Size = new System.Drawing.Size(366, 24);
			this.textEsp.TabIndex = 3;
			this.textEsp.TextChanged += new System.EventHandler(this.TextEspTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Español";
			// 
			// btnIngles
			// 
			this.btnIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngles.Location = new System.Drawing.Point(384, 35);
			this.btnIngles.Name = "btnIngles";
			this.btnIngles.Size = new System.Drawing.Size(43, 24);
			this.btnIngles.TabIndex = 5;
			this.btnIngles.Text = "Add";
			this.btnIngles.UseVisualStyleBackColor = true;
			this.btnIngles.Click += new System.EventHandler(this.BtnInglesClick);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(384, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(38, 25);
			this.button1.TabIndex = 6;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox
			// 
			this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox.Location = new System.Drawing.Point(12, 118);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(343, 149);
			this.richTextBox.TabIndex = 7;
			this.richTextBox.Text = "";
			// 
			// rdIng
			// 
			this.rdIng.Checked = true;
			this.rdIng.Location = new System.Drawing.Point(382, 136);
			this.rdIng.Name = "rdIng";
			this.rdIng.Size = new System.Drawing.Size(45, 32);
			this.rdIng.TabIndex = 8;
			this.rdIng.TabStop = true;
			this.rdIng.Text = "Ing";
			this.rdIng.UseVisualStyleBackColor = true;
			this.rdIng.CheckedChanged += new System.EventHandler(this.RdIngCheckedChanged);
			// 
			// rdEsp
			// 
			this.rdEsp.Location = new System.Drawing.Point(382, 165);
			this.rdEsp.Name = "rdEsp";
			this.rdEsp.Size = new System.Drawing.Size(45, 32);
			this.rdEsp.TabIndex = 9;
			this.rdEsp.Text = "Esp";
			this.rdEsp.UseVisualStyleBackColor = true;
			this.rdEsp.CheckedChanged += new System.EventHandler(this.RdEspCheckedChanged);
			// 
			// rdAdd
			// 
			this.rdAdd.Location = new System.Drawing.Point(382, 199);
			this.rdAdd.Name = "rdAdd";
			this.rdAdd.Size = new System.Drawing.Size(45, 32);
			this.rdAdd.TabIndex = 10;
			this.rdAdd.Text = "Add";
			this.rdAdd.UseVisualStyleBackColor = true;
			this.rdAdd.CheckedChanged += new System.EventHandler(this.RdAddCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 279);
			this.Controls.Add(this.rdAdd);
			this.Controls.Add(this.rdEsp);
			this.Controls.Add(this.rdIng);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnIngles);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textEsp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textIng);
			this.Controls.Add(this.btStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "DosLenguas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
