/*
 * Creado por SharpDevelop.
 * Usuario: hernani Aleman Ferraz.
 * Fecha: 16/06/2017
 * Hora: 21:42
 * Documentation extracted from the network
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionMethods;


namespace ExampExtension
{
	/// <summary>
	/// El método de extensión WordCount se incluye en el ámbito, 
	/// con la directiva using y llamándolo como se muestra 
	/// a continuación:
	/// </summary>
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			String cadena = "Esta es una prueba.Está seguro?Si";
            int cantPalabras = cadena.WordCount();
            System.Console.WriteLine("La cadena '{0}' tiene: " + 
                       "{1} palabras", cadena, cantPalabras);
            //			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
namespace ExtensionMethods
{
	/// <summary>
	/// Los métodos de extensión se definen como métodos estáticos 
	/// pero se llaman utilizando la sintaxis de los métodos de instancia.
	/// El primer parámetro especifica en qué tipo actúa el método y 
	/// va precedido del modificador this.Los métodos de extensión 
	/// sólo se incluyen en el ámbito cuando el espacio de nombres 
	/// se importa explícitamente al código fuente con una directiva 
	/// using. 
	/// En el ejemplo siguiente se muestra un método de extensión 
	/// definido para la clase System.String. Observe que se define 
	/// dentro de una clase estática no anidada y no genérica:
	/// </summary>
	public static class MyExtensions
    {
        /// <summary>
        /// Cuenta las palabras que forman una cadena
        /// </summary>
        /// <param name="str">
        ///     Especifica que el método actúa sobre la clase String.
        /// </param>
        /// <returns>
        ///      La cantidad de palabras que componen la cadena
        /// </returns>
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                  StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

}