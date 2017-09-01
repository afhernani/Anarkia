/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 16:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of PulsoDienteSierra.
	/// 
	///  /|      (-P/2, 0 )  f(t): x + P/2
	///_/ |  _   ( 0 , P/2)  f(t): x - P/2
	///   | /
	///   |/
	///_______ P
	/// </summary>
	public class PulsoDienteSierra:Fourier
	{
		public PulsoDienteSierra(double[] discont, int nDiscont)
			: base(discont, nDiscont)
		{
		}

		#region implemented abstract members of Fourier

		public override double funcion(double t)
		{
			if (iDiscont == 0)
				return t + P / 2;   
			return t - P / 2;
		}

		#endregion
	}
}
