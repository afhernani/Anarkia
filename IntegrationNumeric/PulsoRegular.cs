/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 15:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of PulsoRegular.
	///     ___ 1.
	///    |   |       (-P/2, -A/2)  f(t): 0
	/// ___|   |___ t  (-A/2,  A/2)  f(t): 1
	///     ___ A      ( A/2,  P/2)  f(t): 0
	/// ___________ P
	/// </summary>
	public class PulsoRegular:Fourier
	{
		public PulsoRegular(double[] discont, int nDiscont)
			: base(discont, nDiscont)
		{
     
		}
		#region implemented abstract members of Fourier

		public override double funcion(double t)
		{
			if (iDiscont == 0)
				return 0.0;
			if (iDiscont == 1)
				return 1.0;
			return 0.0;
		}

		#endregion
	}
}
