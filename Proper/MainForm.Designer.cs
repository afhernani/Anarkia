/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/04/2017
 * Hora: 15:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtBoxResult;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLee;
		
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
			this.txtBoxResult = new System.Windows.Forms.TextBox();
			this.btnAction = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnLee = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBoxResult
			// 
			this.txtBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxResult.ForeColor = System.Drawing.Color.SaddleBrown;
			this.txtBoxResult.Location = new System.Drawing.Point(1, 43);
			this.txtBoxResult.Multiline = true;
			this.txtBoxResult.Name = "txtBoxResult";
			this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBoxResult.Size = new System.Drawing.Size(472, 169);
			this.txtBoxResult.TabIndex = 0;
			// 
			// btnAction
			// 
			this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAction.BackColor = System.Drawing.Color.OrangeRed;
			this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAction.Location = new System.Drawing.Point(384, 231);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(89, 32);
			this.btnAction.TabIndex = 1;
			this.btnAction.Text = "&Save";
			this.btnAction.UseVisualStyleBackColor = false;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUrl.ForeColor = System.Drawing.Color.DarkRed;
			this.txtUrl.Location = new System.Drawing.Point(1, 12);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(472, 22);
			this.txtUrl.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.OrangeRed;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button1.Location = new System.Drawing.Point(130, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Limpia";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnLee
			// 
			this.btnLee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLee.BackColor = System.Drawing.Color.OrangeRed;
			this.btnLee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLee.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnLee.Location = new System.Drawing.Point(258, 231);
			this.btnLee.Name = "btnLee";
			this.btnLee.Size = new System.Drawing.Size(89, 32);
			this.btnLee.TabIndex = 4;
			this.btnLee.Text = "&Lee";
			this.btnLee.UseVisualStyleBackColor = false;
			this.btnLee.Click += new System.EventHandler(this.BtnLeeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 275);
			this.Controls.Add(this.btnLee);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.txtBoxResult);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Proper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
