/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 18:12
 * 
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of SERungeKutta.
	/// Sistema de ecuaciones diferenciales de primer orden.
	/// dx/dt = f(x,y,t)  y  dy/dt=g(x,y,t)
	/// El procedimiento de aplicación del método de Runge-Kutta 
	/// a cada una de las ecuaciones diferenciales, con las condiciones iniciales
	/// x(to)=xo  : y(to)=yo
	/// A partir del valor de x en el instante t, se determina el valor de x 
	/// en el instante t+h, y a partir del valor de y en el instante t se 
	/// determina el valor de y en el instante t+h mediante las fórmulas 
	/// de la última fila de la tabla.
	/// </summary>
	public abstract class SERungeKutta
	{
		public void resolver(double tf, Estado e, double h)
		{
			//variables auxiliares
			double k1, k2, k3, k4;
			double l1, l2, l3, l4;
			//estado inicial
			double x = e.x;
			double y = e.y;
			double t0 = e.t;

			for (double t = t0; t < tf; t += h) {
				k1 = h * f(x, y, t);
				l1 = h * g(x, y, t);
				k2 = h * f(x + k1 / 2, y + l1 / 2, t + h / 2);
				l2 = h * g(x + k1 / 2, y + l1 / 2, t + h / 2);
				k3 = h * f(x + k2 / 2, y + l2 / 2, t + h / 2);
				l3 = h * g(x + k2 / 2, y + l2 / 2, t + h / 2);
				k4 = h * f(x + k3, y + l3, t + h);
				l4 = h * g(x + k3, y + l3, t + h);
				x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
				y += (l1 + 2 * l2 + 2 * l3 + l4) / 6;
			}
			e.t = tf;
			e.x = x;
			e.y = y;
			//no funciona la siguiente sentencia
			//ya que es otro objeto no el que se pasa en el argumento
			//e=new Estado(tf, x, y);
		}
		abstract public double f(double x, double y, double t);
		abstract public double g(double x, double y, double t);
	}
}
