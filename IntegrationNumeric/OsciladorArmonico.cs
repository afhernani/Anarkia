/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 18:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of OsciladorArmonico.
	/// El sistema describe un oscilador armonico y su solución para unas 
	/// condiciones iniciales fijadas es:
	/// 
	/// d^2x/dt^2 =wo·x :: x = A·sen(wot + fi)
	/// 
	/// donde w0 es la frecuencia angular, y el periodo del movimiento es P=2p/w0.
	/// La clase denominada Oscilador que describirá un oscilador armónico tendrá 
	/// como miembro dato, la frecuencia angular, y derivará de la 
	/// clase base RungeKutta, ya que el comportamiento de un oscilador 
	/// armónico viene descrito por una ecuación diferencial de segundo orden. 
	/// La clase Oscilador definirá la función f declarada abstracta 
	/// en la clase base.
	/// 
	/// </summary>
	public class OsciladorArmonico: ED2ORungeKutta
	{
		protected double w;
		public OsciladorArmonico(double w)
		{
			this.w=w;
		}
		
		#region implemented abstract members of ED2ORungeKutta
		public override double f(double x, double y, double t)
		{
			return (-w*w*x);
		}
		#endregion
	}
}
