/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 18:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of DobleDesintegracion.
	/// 
	/// </summary>
	public class DobleDesintegracion: SERungeKutta
	{
		public DobleDesintegracion()
		{
		}

		#region implemented abstract members of SERungeKutta

		public override double f(double x, double y, double t)
		{
			return (-0.1*x);
		}

		public override double g(double x, double y, double t)
		{
			return (0.1*x-0.2*y);
		}

		#endregion
	}
}
