/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 15:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// clase base abstracta denominada Simpson, 
	/// que define la función miembro integral que 
	/// calcula la integral definida de cualquier 
	/// función f(x) por el procedimiento de Simpson.
	/// </summary>
	public abstract class Simpson
	{
		/// <summary>
		/// El área aproximada en el intervalo [a, b]
		/// En el método de Simpson, el número de divisiones n 
		/// debe de ser par. En el caso de que el usuario 
		/// introduzca un número impar el programa lo convierte 
		/// en el número par siguiente.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public double integral(double a, double b, int n)
		{
			if (n % 2 == 1)
				n++;     
			double h = (b - a) / n;
			double suma = f(a) + f(b);
			for (int i = 1; i < n; i += 2) {
				suma += 4 * f(a + i * h);
			}
			for (int i = 2; i < n; i += 2) {
				suma += 2 * f(a + i * h);
			}
			return (suma * h / 3);
		}
		abstract public double f(double x);
	}
}
