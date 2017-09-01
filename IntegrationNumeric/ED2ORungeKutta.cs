/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 18:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of ED2ORungeKutta.
	/// Se aplica el procedimiento de Runge-Kutta 
	/// a una ecuación diferencial de segundo orden.
	/// d^2x/d^2t = f(x,v,t)
	/// en su estado inicial
	/// x(to) = xo : (dx/dt)to = vo
	/// Una ecuación diferencial de segundo orden es equivalente a 
	/// un sistema de dos ecuaciones diferenciales de primer orden, 
	/// (SERungeKutta)por lo que aplicaremos el mismo esquema.
	/// En el estado y == v
	/// </summary>
	public abstract class ED2ORungeKutta
	{
		/// <summary>
		/// v==y
		/// </summary>
		/// <param name="tf"></param>
		/// <param name="e"></param>
		/// <param name="h"></param>
		public void resolver(double tf, Estado e, double h)
		{
			//variables auxiliares
			double k1, k2, k3, k4;
			double l1, l2, l3, l4;
			//estado inicial
			double x = e.x;
			double v = e.y; //para igualar le clase Estado general.
			double t0 = e.t;

			for (double t = t0; t < tf; t += h) {
				k1 = h * v;
				l1 = h * f(x, v, t);
				k2 = h * (v + l1 / 2);
				l2 = h * f(x + k1 / 2, v + l1 / 2, t + h / 2);
				k3 = h * (v + l2 / 2);
				l3 = h * f(x + k2 / 2, v + l2 / 2, t + h / 2);
				k4 = h * (v + l3);
				l4 = h * f(x + k3, v + l3, t + h);
				x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
				v += (l1 + 2 * l2 + 2 * l3 + l4) / 6;
			}
			e.t = tf;
			e.x = x;
			e.y = v;
		}
		
		abstract public double f(double x, double y, double t);
		
	}
}
