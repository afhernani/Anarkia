/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 14:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Trapecio.
	/// defina una función miembro denominada integral que calcula la 
	/// integral definida de cualquier función f(x) por el procedimiento 
	/// de los trapecios. A dicha función le pasaremos los valores 
	/// de los extremos del intervalo, y el número de divisiones del mismo
	/// </summary>
	public abstract class Trapecio
	{
		/// <summary>
		/// la fórmula, la función calcula el valor medio de la función 
		/// en los extremos del intervalo, y lo guarda en la variable 
		/// local suma. Posteriormente, suma los n-1 valores de la 
		/// función en los puntos de abscisas x1 a xn-1. 
		/// Por último, multiplica el resultado por h
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public double integral(double a, double b, int n)
		{
			double h = (b - a) / n;
			double suma = (f(a) + f(b)) / 2;
			for (int i = 1; i < n; i++) {
				suma += f(a + i * h);
			}
			return suma * h;
		}
		/// <summary>
		/// funcion que devuelve los valores.
		/// debe ser implemantada por la subclase.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		abstract public double f(double x);
	}
}
