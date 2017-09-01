/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 15:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of sfcos.
	/// </summary>
	public class sfcos: Simpson
	{
		public sfcos()
		{
		}
		
		#region implemented abstract members of Simpson
		public override double f(double x)
		{
			return Math.Cos(x);
		}
		#endregion
	}
}
