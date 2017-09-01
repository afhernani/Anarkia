/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 18:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Estado.
	/// </summary>
	public class Estado
	{
		public double t;
		public double x;
		public double y;
		public double vx;
		public double vy;
		public Estado(double t, double x, double y)
		{
			this.t = t;
			this.x = x;
			this.y = y;
			this.vx = 0;
			this.vy = 0;
		}
		public Estado(double t, double x, double y, double vx, double vy)
		{
			this.t = t;
			this.x = x;
			this.y = y;
			this.vx = vx;
			this.vy = vy;
		}
	}
}
