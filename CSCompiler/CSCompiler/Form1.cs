/*
 * CSCompiler - sample shows usage of Microsoft Code Provider interfaces
 * version 1.0
 * 
 * Copyright - Konrad Rotuski 4.03.2002
 * If you have any questions feel free to e-mail me
 * at krotuski@mion.elka.pw.edu.pl
 * or look at NAnt project at sourceforge.
 */


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Diagnostics;

namespace CSCompiler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox appName;
		private System.Windows.Forms.TextBox mainClass;
		private System.Windows.Forms.CheckBox includeDebug;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.appName = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mainClass = new System.Windows.Forms.TextBox();
			this.includeDebug = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "&Exit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(632, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Compile and Execute";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(512, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Main Class Name";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3});
			this.menuItem2.Text = "&Help";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "&About";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// appName
			// 
			this.appName.Location = new System.Drawing.Point(632, 16);
			this.appName.Name = "appName";
			this.appName.Size = new System.Drawing.Size(152, 20);
			this.appName.TabIndex = 2;
			this.appName.Text = "Application.exe";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(512, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "OutputFileName";
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.AcceptsTab = true;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.HideSelection = false;
			this.textBox1.Location = new System.Drawing.Point(8, 8);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(496, 208);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "using System;\r\n\r\nnamespace Helloworld\t{ \r\n\tpublic class HelloWorld\t{\r\n\t\tpublic st" +
				"atic void Main(String[] args)  {\r\n\t\t\tSystem.Console.WriteLine(\"Hello World\");\r\n\t" +
				"\t\tSystem.Console.In.Read();\r\n\t\t}\r\n\t}\r\n}";
			this.textBox1.WordWrap = false;
			// 
			// mainClass
			// 
			this.mainClass.Location = new System.Drawing.Point(632, 48);
			this.mainClass.Name = "mainClass";
			this.mainClass.Size = new System.Drawing.Size(152, 20);
			this.mainClass.TabIndex = 3;
			this.mainClass.Text = "Helloworld.HelloWorld";
			// 
			// includeDebug
			// 
			this.includeDebug.Location = new System.Drawing.Point(512, 88);
			this.includeDebug.Name = "includeDebug";
			this.includeDebug.Size = new System.Drawing.Size(160, 24);
			this.includeDebug.TabIndex = 7;
			this.includeDebug.Text = "Include Debug Info";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(816, 233);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.includeDebug,
																		  this.label2,
																		  this.label1,
																		  this.mainClass,
																		  this.appName,
																		  this.button1,
																		  this.textBox1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Dispose();
			Application.Exit();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show(this, "CSharp sample compiler :)", "CodeProject Rulez");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			CSharpCodeProvider codeProvider = new CSharpCodeProvider();

			// For Visual Basic Compiler try this :
			//Microsoft.VisualBasic.VBCodeProvider

			ICodeCompiler compiler = codeProvider.CreateCompiler();
			CompilerParameters parameters = new CompilerParameters();

			parameters.GenerateExecutable = true;
			if (appName.Text == "")	
			{
				System.Windows.Forms.MessageBox.Show(this, "Application name cannot be empty");
				return ;
			}

			parameters.OutputAssembly = appName.Text.ToString();

			if (mainClass.Text.ToString() == "")
			{
				System.Windows.Forms.MessageBox.Show(this, "Main Class Name cannot be empty");
				return ;
			}

			parameters.MainClass = mainClass.Text.ToString();

			parameters.IncludeDebugInformation = includeDebug.Checked;

			// Add available assemblies - this should be enough for the simplest
			// applications.
			foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies()) 
			{
				parameters.ReferencedAssemblies.Add(asm.Location);
			}

			String code = textBox1.Text.ToString();
			//System.Windows.Forms.MessageBox.Show(this, code);

			CompilerResults results = compiler.CompileAssemblyFromSource(parameters, code);
			
			if (results.Errors.Count > 0) 
			{
				string errors = "Compilation failed:\n";
				foreach (CompilerError err in results.Errors) 
				{
					errors += err.ToString() + "\n";
				}
				System.Windows.Forms.MessageBox.Show(this, errors, "There were compilation errors");
			}
			else	
			{
				#region Executing generated executable
				// try to execute application

				try 
				{
					if (!System.IO.File.Exists(appName.Text.ToString())) 
					{
						MessageBox.Show(String.Format("Can't find {0}", appName), "Can't execute.", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					ProcessStartInfo pInfo = new ProcessStartInfo(appName.Text.ToString());
					Process.Start(pInfo);
				} 
				catch (Exception ex) 
				{
					MessageBox.Show(String.Format("Error while executing {0}", appName) + ex.ToString(),
							"Can't execute.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				#endregion
				
			}
			
		}
	}
}
