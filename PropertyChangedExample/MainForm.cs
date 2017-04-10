/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 21/09/2016
 * Hora: 10:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace PropertyChangedExample
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Person persona = new Person();
		// This button causes the value of a list element to be changed.
        

        // This DataGridView control displays the contents of the list.
        
        // This BindingSource binds the list to the DataGridView control.
        private BindingSource customersBindingSource = new BindingSource();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			// Set up the "Change Item" button.       
		}
		
		private void MainForm_Load(object sender, EventArgs e)
        {
            // Create and populate the list of DemoCustomer objects
            // which will supply data to the DataGridView.
            BindingList<DemoCustomer> customerList = new BindingList<DemoCustomer>();
            customerList.Add(DemoCustomer.CreateNewCustomer());
            customerList.Add(DemoCustomer.CreateNewCustomer());
            customerList.Add(DemoCustomer.CreateNewCustomer());

            // Bind the list to the BindingSource.
            this.customersBindingSource.DataSource = customerList;

            // Attach the BindingSource to the DataGridView.
            this.customersDataGridView.DataSource =
                this.customersBindingSource;
            //person configuration
            persona.PropertyChanged += new PropertyChangedEventHandler(persona_PropertyChanged);
            

        }
		// Change the value of the CompanyName property for the first 
        // item in the list when the "Change Item" button is clicked.
        void changeItemBtn_Click(object sender, EventArgs e)
        {
            // Get a reference to the list from the BindingSource.
            BindingList<DemoCustomer> customerList =
                this.customersBindingSource.DataSource as BindingList<DemoCustomer>;

            // Change the value of the CompanyName property for the 
            // first item in the list.
            customerList[0].CustomerName = "Tailspin Toys";
            customerList[0].PhoneNumber = "(708)555-0150";
        }
		void BtnChangeClick(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(txtName.Text)) return;
			persona.Name="Hernani";
			persona.LastName="Ferraz";
			persona.Address = "Obispo encina 13";
			Debug.WriteLine("fin cambio de propiety");
		}

		
		void persona_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Debug.WriteLine("Something changed!");
	        Debug.WriteLine(e.PropertyName);
		}
	}
}
