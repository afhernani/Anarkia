/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 03/07/2017
 * Hora: 23:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace DosLenguas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MongoClient mc;
		static MongoServer mongo;
		MongoDatabase db;
		const string basedatos = "dic";
		MongoCollection colectionBocablos;
		bool engToEsp = true;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtStartClick(object sender, EventArgs e)
		{
			if (btStart.Text.Equals("Disc")) {
				mc = null;
				mongo = null;
				db = null;
				btStart.BackColor = Color.Red;
				//btStart.Enabled = true;
				btStart.Text = "Conect";
			} else {	
				mc = new MongoClient("mongodb://localhost");
				mongo = mc.GetServer();
				db = mongo.GetDatabase(basedatos);
				colectionBocablos = db.GetCollection("bocablos");
				btStart.BackColor = Color.Green;
				//btStart.Enabled = true;
				btStart.Text = "Disc";
			}
		}
		
		void TextEspTextChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textEsp.Text);
			//if (textEsp.Text.Equals(""))
			//	textIng.Text = "";
			if (colectionBocablos == null)
				return;
			richTextBox.Clear();
			if (rdAdd.Checked)
				return;
			if (!String.IsNullOrEmpty(textEsp.Text)) {
				colectionBocablos = db.GetCollection("bocablos");
				var Palabras = colectionBocablos.AsQueryable<Word>();
				var res = from c in Palabras
				          where c.Esp.ToUpper()== textEsp.Text.ToUpper() //|| c.Esp.ToLower().StartsWith(textEsp.Text.ToLower())
				          select c;
				//pasamos los resultados a la lista
				
				foreach (Word element in res) {
					Debug.WriteLine(element.ToJson());
					richTextBox.Text += element.ToJson();
				}
				if(engToEsp==false){
					textIng.Text = "";
					if(res.Count()>=1){
						
						textIng.Text = res.First().Ing;
					}
				}
			}
		}
		void TextIngTextChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textIng.Text);
			//if (textIng.Text.Equals(""))
			//	textEsp.Text = "";
			if (colectionBocablos == null)
				return;
			richTextBox.Clear();
			if (rdAdd.Checked)
				return;
			if (!String.IsNullOrEmpty(textIng.Text)) {
				colectionBocablos = db.GetCollection("bocablos");
				var Palabras = colectionBocablos.AsQueryable<Word>();
				var res = from c in Palabras
					where c.Ing.ToUpper()==textIng.Text.ToUpper()
				           select c;
				//pasamos los resultados a la lista
				
				foreach (Word element in res) {
					Debug.WriteLine(element.ToJson());
					richTextBox.Text += element.ToJson();
				}
				if(engToEsp){
					textEsp.Text = "";
				if(res.Count()>=1){
						
						textEsp.Text = res.First().Esp;
					}
				}
				
			}
		}
		void BtnInglesClick(object sender, EventArgs e)
		{
			if (db == null)
				return; //no esta inicializada la db mongo.
			colectionBocablos = db.GetCollection("bocablos");
			if (!String.IsNullOrEmpty(textIng.Text) && !String.IsNullOrEmpty(textEsp.Text)) 
			{
				Word wd = new Word(textEsp.Text, textIng.Text);
				colectionBocablos.Insert(wd);
			}
		}
		void RdIngCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = true;
			textEsp.ReadOnly = true;
			textIng.ReadOnly = false;
			btnIngles.Enabled = false;
		}
		void RdEspCheckedChanged(object sender, EventArgs e)
		{
			engToEsp = false;
			textIng.ReadOnly = true;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = false;
		}
		void RdAddCheckedChanged(object sender, EventArgs e)
		{
			textIng.ReadOnly = false;
			textEsp.ReadOnly = false;
			btnIngles.Enabled = true;
		}
		
	}
}
