/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 21/09/2016
 * Hora: 10:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PropertyChangedExample
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button changeItemBtn;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DataGrid customersDataGridView;
		private System.Windows.Forms.Button btnChange;
		
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
			this.changeItemBtn = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.customersDataGridView = new System.Windows.Forms.DataGrid();
			this.btnChange = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// changeItemBtn
			// 
			this.changeItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changeItemBtn.Location = new System.Drawing.Point(469, 353);
			this.changeItemBtn.Name = "changeItemBtn";
			this.changeItemBtn.Size = new System.Drawing.Size(183, 40);
			this.changeItemBtn.TabIndex = 0;
			this.changeItemBtn.Text = "Change Item";
			this.changeItemBtn.UseVisualStyleBackColor = true;
			this.changeItemBtn.Click += new System.EventHandler(this.changeItemBtn_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(12, 298);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(399, 26);
			this.txtName.TabIndex = 1;
			// 
			// customersDataGridView
			// 
			this.customersDataGridView.DataMember = "";
			this.customersDataGridView.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.customersDataGridView.Location = new System.Drawing.Point(12, 12);
			this.customersDataGridView.Name = "customersDataGridView";
			this.customersDataGridView.Size = new System.Drawing.Size(640, 280);
			this.customersDataGridView.TabIndex = 2;
			// 
			// btnChange
			// 
			this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChange.Location = new System.Drawing.Point(12, 363);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(183, 40);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "Change Value";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.BtnChangeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 415);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.customersDataGridView);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.changeItemBtn);
			this.Name = "MainForm";
			this.Text = "PropertyChangedExample";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
