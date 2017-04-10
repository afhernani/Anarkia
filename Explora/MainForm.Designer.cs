/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 31/03/2017
 * Hora: 15:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Explora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtWhat;
		private System.Windows.Forms.TextBox txtWhere;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnBusca;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtWhat = new System.Windows.Forms.TextBox();
			this.txtWhere = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.btnAction = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnBusca = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtWhat
			// 
			this.txtWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWhat.Location = new System.Drawing.Point(71, 11);
			this.txtWhat.Name = "txtWhat";
			this.txtWhat.Size = new System.Drawing.Size(487, 22);
			this.txtWhat.TabIndex = 0;
			// 
			// txtWhere
			// 
			this.txtWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWhere.Location = new System.Drawing.Point(71, 39);
			this.txtWhere.Name = "txtWhere";
			this.txtWhere.Size = new System.Drawing.Size(487, 22);
			this.txtWhere.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "What:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Where:";
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox.Location = new System.Drawing.Point(7, 67);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(460, 172);
			this.richTextBox.TabIndex = 4;
			this.richTextBox.Text = "";
			// 
			// btnAction
			// 
			this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAction.Location = new System.Drawing.Point(473, 111);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(85, 28);
			this.btnAction.TabIndex = 5;
			this.btnAction.Text = "Buscar (a)";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnActionClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(473, 211);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "Limpia";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnBusca
			// 
			this.btnBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBusca.Location = new System.Drawing.Point(473, 145);
			this.btnBusca.Name = "btnBusca";
			this.btnBusca.Size = new System.Drawing.Size(85, 28);
			this.btnBusca.TabIndex = 7;
			this.btnBusca.Text = "Buscar (r)";
			this.btnBusca.UseVisualStyleBackColor = true;
			this.btnBusca.Click += new System.EventHandler(this.BtnBuscaClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(473, 177);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(85, 28);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "C&ancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 244);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBusca);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtWhere);
			this.Controls.Add(this.txtWhat);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Explora";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
