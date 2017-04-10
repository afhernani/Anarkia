/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 21/09/2016
 * Hora: 10:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace PropertyChangedExample
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person:INotifyPropertyChanged
	{
		private string _name = string.Empty;
		private string _lastName = string.Empty;
		private string _address = string.Empty;
		public Person(){
			PropertyChanged += new PropertyChangedEventHandler(Rastreo_PropertyChanged);
		}
		public string Name {
			get { return this._name; }
			set {
				this._name = value;
				NotifyPropertyChanged("Name");
			}
		}
		public string LastName {
			get { return this._lastName; }
			set {
				this._lastName = value;
				NotifyPropertyChanged("LastName");
			}
		}
		public string Address {
			get { return this._address; }
			set {
				this._address = value;
				NotifyPropertyChanged("Address");
			}
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged(string info)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
		
		
		void Rastreo_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			switch (e.PropertyName) {
				case "Name":
					Debug.WriteLine("case Name");
					break;
				case "LastName":
					Debug.WriteLine("case LastName");
					break;
				case "Address":
					Debug.WriteLine("case Address");
					break;
			}
		}
	}
	
	
	class Program2
	{
	    static void Main(string[] args)
	    {
	        Person sergio = new Person();
	        sergio.PropertyChanged += new PropertyChangedEventHandler(sergio_PropertyChanged);
	        sergio.Name = "Sergio";
	        Console.ReadLine();
	        sergio.Name = "Serg";
	        Console.ReadLine();
	    }
	    static void sergio_PropertyChanged(object sender, PropertyChangedEventArgs e)
	    {
	        Console.WriteLine("Something changed!");
	        Console.WriteLine(e.PropertyName);
	    }
	}
	
}
