/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 21/09/2016
 * Hora: 11:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;

namespace PropertyChangedExample
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Class1
	{
		public Class1()
		{
		}
	}
	
	// This is a simple customer class that 
    // implements the IPropertyChange interface.
    public class DemoCustomer : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private Guid idValue = Guid.NewGuid();
        private string customerNameValue = String.Empty;
        private string phoneNumberValue = String.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // The constructor is private to enforce the factory pattern.
        private DemoCustomer()
        {
            customerNameValue = "Customer";
            phoneNumberValue = "(312)555-0100";
        }

        // This is the public factory method.
        public static DemoCustomer CreateNewCustomer()
        {
            return new DemoCustomer();
        }

        // This property represents an ID, suitable
        // for use as a primary key in a database.
        public Guid ID
        {
            get
            {
                return this.idValue;
            }
        }

        public string CustomerName
        {
            get
            {
                return this.customerNameValue;
            }

            set
            {
                if (value != this.customerNameValue)
                {
                    this.customerNameValue = value;
                    NotifyPropertyChanged("CustomerName");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberValue;
            }

            set
            {
                if (value != this.phoneNumberValue)
                {
                    this.phoneNumberValue = value;
                    NotifyPropertyChanged("PhoneNumber");
                }
            }
        } 
	}
	
}




    