/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 17:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of TazaDesintegracionRadioactiva.
	/// Consideremos la ecuación diferencial que describe la 
	/// desintegración de una sustancia radioactiva en otra estable.
	/// dx/dt = -a·x : x = x·e^(-at)
	/// Donde a es la constante de desintegración radioactiva. 
	/// A la izquierda tenemos la ecuación diferencial y a la drecha 
	/// su solución analítica.
	/// </summary>
	public class TazaDesintegracionRadioactiva: RungeKutta
	{
		public TazaDesintegracionRadioactiva()
		{
		}

		#region implemented abstract members of RungeKutta

		public override double f(double x, double t)
		{
			return (-0.1*x);
		}

		#endregion
	}
}
