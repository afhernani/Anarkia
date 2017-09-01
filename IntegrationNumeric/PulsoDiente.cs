/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 16:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of PulsoDienteSierra.
	/// 
	/// \    /   (-P/2, 0 ) f(t): -x
	///  \  /    ( 0 , P/2) f(t):  x
	///   \/
	/// ______ P
	/// </summary>
	public class PulsoDiente:Fourier
	{
		public PulsoDiente(double[] discont, int nDiscont)
			: base(discont, nDiscont)
		{
		}

		#region implemented abstract members of Fourier

		public override double funcion(double t)
		{
			if (iDiscont == 0)
				return -t;
			return t;
		}

		#endregion
	}
}
