/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 19:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of OsciladorAmortiguado.
	/// Si además consideramos que existe un rozamiento que se describe en 
	/// términos de una fuerza proporcional a la velocidad, la ecuación diferencial 
	/// del oscilador amortiguado se escribe.
	/// 
	/// d^2x/dt^2 = -2·g·v-w0^2·x  :: v==y
	/// 
	/// En vez de crear una nueva clase Amortiguado que sustituya a la clase 
	/// Oscilador, podemos pensar que un oscilador amortiguado, es una clase 
	/// especial de oscilador, y por tanto la clase que lo describe, 
	/// derivará de Oscilador, le añadirá el miembro dato g (por g), 
	/// que da cuenta de la intensidad de las fuerzas de rozamiento, 
	/// y además, redefine la función f.
	/// 
	/// </summary>
	public class OsciladorAmortiguado: OsciladorArmonico
	{
		protected double g;
		public OsciladorAmortiguado(double g, double w0)
			: base(w0)
		{
			this.g = g;
		}
		public override double f(double x, double v, double t)
		{
			return (-2 * g * v - w * w * x);
		}
	}
}
