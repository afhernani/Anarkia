/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 19:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of SE2ORungerKutta.
	/// Sea el sistema de dos ecuaciones diferenciales de segundo orden:
	/// d^2x/d^2t = f(x,y,vx,vy,t)  y d^2y/d^2t = g(x,y,vx,vy,t)
	/// con las condiciones iniciales
	/// x(to) = xo : (dx/dt)to = vxo  : y(to) = yo : (dy/dt)to = vyo
	/// Este sistema, se puede transformar en un sistema equivalente formado 
	/// por cuatro ecuaciones diferenciales de primer orden. Aplicando dos 
	/// veces el esquema descrito para una ecuación diferencial de segundo orden
	/// </summary>
	public abstract class SE2ORungerKutta
	{
		public void resolver(double tf, Estado e, double h)
		{
			//variables auxiliares
			double k1, k2, k3, k4;
			double l1, l2, l3, l4;
			double q1, q2, q3, q4;
			double m1, m2, m3, m4;
			//condiciones iniciales
			double x = e.x;
			double y = e.y;
			double vx = e.vx;
			double vy = e.vy;
			double t0 = e.t;

			for (double t = t0; t < tf; t += h) {
				k1 = h * vx;
				l1 = h * f(x, y, vx, vy, t);
				q1 = h * vy;
				m1 = h * g(x, y, vx, vy, t);

				k2 = h * (vx + l1 / 2);
				l2 = h * f(x + k1 / 2, y + q1 / 2, vx + l1 / 2, vy + m1 / 2, t + h / 2);
				q2 = h * (vy + m1 / 2);
				m2 = h * g(x + k1 / 2, y + q1 / 2, vx + l1 / 2, vy + m1 / 2, t + h / 2);

				k3 = h * (vx + l2 / 2);
				l3 = h * f(x + k2 / 2, y + q2 / 2, vx + l2 / 2, vy + m2 / 2, t + h / 2);
				q3 = h * (vy + m2 / 2);
				m3 = h * g(x + k2 / 2, y + q2 / 2, vx + l2 / 2, vy + m2 / 2, t + h / 2);

				k4 = h * (vx + l3);
				l4 = h * f(x + k3, y + q3, vx + l3, vy + m3, t + h);
				q4 = h * (vy + m3);
				m4 = h * g(x + k3, y + q3, vx + l3, vy + m3, t + h);
				//nuevo estado del sistema
				x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
				vx += (l1 + 2 * l2 + 2 * l3 + l4) / 6;
				y += (q1 + 2 * q2 + 2 * q3 + q4) / 6;
				vy += (m1 + 2 * m2 + 2 * m3 + m4) / 6;
			}
			//cambia el estado de la partícula
			e.x = x;
			e.y = y;
			e.vx = vx;
			e.vy = vy;
			e.t = tf;
		}
		abstract public double f(double x, double y, double vx, double vy, double t);
		abstract public double g(double x, double y, double vx, double vy, double t);
	}
}
