/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 20/09/2016
 * Hora: 21:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace flowPanel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnpulsa;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnVisible;
		private System.Windows.Forms.Label label1;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpulsa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(575, 548);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowLayoutPanel1Scroll);
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel1ControlAdded);
            // 
            // btnpulsa
            // 
            this.btnpulsa.Location = new System.Drawing.Point(495, 614);
            this.btnpulsa.Name = "btnpulsa";
            this.btnpulsa.Size = new System.Drawing.Size(92, 33);
            this.btnpulsa.TabIndex = 1;
            this.btnpulsa.Text = "Pulsame";
            this.btnpulsa.UseVisualStyleBackColor = true;
            this.btnpulsa.Click += new System.EventHandler(this.BtnpulsaClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 614);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add controls";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(209, 614);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(92, 33);
            this.btnVisible.TabIndex = 3;
            this.btnVisible.Text = "Visible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.BtnVisibleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnpulsa);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flowPanel";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);

		}
	}
}
