/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 17:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of RungeKutta.
	/// Ecuaciones diferenciales de primer orden.
	/// Sea una ecuación diferencial de primer orden, con la condición inicial:
	/// x(to) = xo
	/// 
	/// </summary>
	public abstract class RungeKutta
	{
		public double resolver(double tf, double t0, double x, double h)
		{
			double k1, k2, k3, k4;
			for (double t = t0; t < tf; t += h) {
				k1 = h * f(x, t);
				k2 = h * f(x + k1 / 2, t + h / 2);
				k3 = h * f(x + k2 / 2, t + h / 2);
				k4 = h * f(x + k3, t + h);
				x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
			}
			return x;
		}
		abstract public double f(double x, double t);
	}
}
