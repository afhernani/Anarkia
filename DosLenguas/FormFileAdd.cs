using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DosLenguas
{
	/// <summary>
	/// Description of IForm.
	/// </summary>
	public partial class FormFileAdd: Form
	{
		public FormFileAdd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string filename = string.Empty;
		string name_Only;
		
		void BtnOpenFileClick(object sender, EventArgs e){
			List<string> lineas = new List<string>();
			OpenFileDialog openfile =new OpenFileDialog()
			{
				Filter = "Txt file(*.txt*)|*.txt",
				Title = @"Open file to load",
				//InitialDirectory = Environment.CurrentDirectory,
				//RestoreDirectory = true
			};
			
			if(openfile.ShowDialog()==DialogResult.OK){
				filename = openfile.FileName;
				name_Only = openfile.SafeFileName;
				if(Path.GetExtension(filename).ToUpper().Equals(".TXT"))
				{
					using(StreamReader f = new StreamReader(filename)){
						string line;
						do{
							line = f.ReadLine();
							if(line!=null){
								lineas.Add(line);
							}
						} while(line != null);
					}
					richTextBox.Clear();
					richTextBox.Lines = lineas.ToArray();
				}
			}
		}
		int lin = 0;
		void BtnNextClick(object sender, EventArgs e){
			if(richTextBox.Lines.Length>0){
				string cadena = richTextBox.Lines[lin];
				ProcesarCadena(cadena);
				
				lin++;
			}
			if(lin==richTextBox.Lines.Length){
				lin = 0;
			}
			
		}
		void ProcesarCadena(string cadena){
			
			if(!String.IsNullOrEmpty(cadena)){
				string esp, ing;
				string[] fillout = cadena.Split(':');
				if(fillout.Length==2){
					esp = fillout[1];
					ing = fillout[0];
					
					ing = ing.Trim('.');
					ing = ing.Trim(' ');
					
					esp = esp.Trim('.');
					esp = esp.Trim(' ');
					LunchWord(esp, ing);
				}else{
					MessageBox.Show("No existe paridad en " +
					                "el texto de cadena " + cadena);
				}
			}
		}
		
		void LunchWord(string esp, string ing){
			//hacemos un castin y transformamos el formulario en una
			//interfaz.
			IForm forminterfas = this.Owner as IForm;
			if (forminterfas != null)
				forminterfas.AddWordFromFile(new Word(esp, ing));
		}
	}
}