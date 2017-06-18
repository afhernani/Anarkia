/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 13/06/2017
 * Hora: 21:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using FileLib;

namespace OrderFileMovie
{
	/// <summary>
	/// Description of ManagerBlocksForm.
	/// </summary>
	public partial class ManagerBlocksForm : Form
	{
		public ManagerBlocksForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		/// <summary>
		/// Select button move.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RadioButtonMClick(object sender, EventArgs e)
		{
			if (radioButtonM.Checked) {
				//MessageBox.Show("Move");
				label1.Text = "Path to move file:";
				textBoxRename.Enabled = true;
				btnAction.Text = "Move";
				btnLookOther.Enabled = true;
			}
			
		}
		/// <summary>
		/// select button Copy
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RadioButtonCClick(object sender, EventArgs e)
		{
			if (radioButtonC.Checked) {
				//MessageBox.Show("Cancel");
				label1.Text = "Path to Copy file:";
				textBoxRename.Enabled = true;
				btnAction.Text = "Copy";
				btnLookOther.Enabled = true;
			}
		}
		/// <summary>
		/// select button Rename
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RadioButtonRClick(object sender, EventArgs e)
		{
			if (radioButtonR.Checked) {
				//MessageBox.Show("Rename");
				label1.Text = "Nuevo nombre del fichero:";
				textBoxRename.Enabled = true;
				btnAction.Text = "Rename";
				btnLookOther.Enabled = false;
			}
		}
		#region properties
		/// <summary>
		/// Route o path of the dir for copy or move.
		/// </summary>
		private string NewPath{ get; set; }
		/// <summary>
		/// Name file and extension
		/// </summary>
		public string FileName{ get; set; }
		
		/// <summary>
		/// complet name included path of the file
		/// </summary>
		public string FullName{
			get{
				return m_fullname;
			}
			set{ 
				m_fullname = value;
				textBoxRename.Text = FileName = Path.GetFileName(value);
				textBoxFile.Text = value;
			}
		}
		private string m_fullname = String.Empty;
		#endregion
		#region filebrowser
		void BtnLookOtherClick(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog() {
				
			};
			if (dialog.ShowDialog()==DialogResult.OK) {
				NewPath =textBoxRename.Text = dialog.SelectedPath;
			}
	
		}
		void BtnLookFileClick(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog(){
				
			};
			if(!String.IsNullOrEmpty(FullName)){
				openfile.InitialDirectory = Path.GetFullPath(FullName);
			}
			if (openfile.ShowDialog()==DialogResult.OK) {
				
				FullName = textBoxFile.Text = openfile.FileName;
			}
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnActionClick(object sender, EventArgs e)
		{
			if (radioButtonM.Checked){
				Console.WriteLine("Move ..");
			}
			if (radioButtonC.Checked){
				Console.WriteLine("Copy ..");
				Block block = new Block(FullName);
				if(block.Asociate){
					block.Copy(NewPath);
				}
			}
			if (radioButtonR.Checked){
				Console.WriteLine("Rename ..");
			}
			
		}
		void TextBoxRenameTextChanged(object sender, EventArgs e)
		{
			NewPath = textBoxRename.Text;
		}
		#endregion
		
	}
}
