/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 16:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of PulsoDobleEscalon.
	///    _ 1.
	///  _| |  _ t    (-P/2-A/2)  f(t): 0
	///    h|_|       (-A/2, 0)   f(t): 1
	///   ____ A      (0, A/2)    f(t):-h
	///  _______ P    (A/2, P/2)  f(t): 0
	/// </summary>
	public class PulsoDobleEscalon:Fourier
	{
		private double h;
		public PulsoDobleEscalon(double[] discont, int nDiscont, double h)
			: base(discont, nDiscont)
		{
			if (h > 0) {
				this.h = h;
			} else {
				this.h = -h;
			}
		}

		#region implemented abstract members of Fourier

		public override double funcion(double t)
		{
			if (iDiscont == 0)
				return 0.0;
			if (iDiscont == 1)
				return 1.0;
			if (iDiscont == 2)
				return -h;
			return 0.0;
		}

		#endregion
	}
}
