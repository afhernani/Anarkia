/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 15:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of fcos.
	/// </summary>
	public class fcos:Trapecio
	{
		public fcos()
		{
		}
		
		#region implemented abstract members of Trapecio
		public override double f(double x)
		{
			return Math.Cos(x);
		}
		#endregion
	}
}
