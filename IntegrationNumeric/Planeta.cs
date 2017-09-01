/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 19:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Planeta.
	/// resolución de un sistema de ecuaciones diferenciales de segundo orden 
	/// es la descripción del movimiento de los planetas, el cual tiene una solución 
	/// analítica sencilla en coordenadas polares. La trayectoria seguida por un 
	/// planeta es una cónica, una elipse en particular, en uno de cuyos focos 
	/// está el centro fijo de fuerzas, el Sol. En la figura, se muestra la fuerza 
	/// que ejerce el Sol sobre un planeta, inversamente proporcional al cuadrado 
	/// de las distancias que separan sus centros, y también se muestran sus 
	/// componentes rectangulares.
	/// 
	/// Teniendo en cuenta que la fuerza que ejerce el sol sobre un planeta viene descrita 
	/// por la ley de la Gravitación Universal.
	/// F=M·G·m/r^2
	/// donde M es la masa del Sol, m la masa del planeta y r la distancia entre el centro del 
	/// Sol y del planeta. Las componentes de la aceleración del planeta serán.
	/// ax = -Fx/m = F·cosa/m = -G·M/r^2·x
	/// ay = -Fy/m = F·sina/m = -G·M/r^2·y
	/// Uno de los problemas del tratamiento numérico con ordenador, es la de reducir el problema 
	/// a números simples e inteligibles por el usuario de un vistazo. Las masa de los planetas y 
	/// del Sol son números muy grandes: la masa de la Tierra es 5.98 1024 kg., y 1.98 1030 kg. 
	/// la del Sol. La distancia media entre la Tierra y el Sol es también muy grande 1.49 1011 m. 
	/// y la constante G es muy pequeña 6.67 10-11 en el Sistema Internacional de Unidades. 
	/// Podemos simplificar el problema numérico, refiriéndonos a un hipotético Sol cuya masa 
	/// sea tal que el producto GM=1 o bien, que se ha cambiado la escala de los tiempos de modo 
	/// que se cumpla esta condición. Teniendo en cuenta que la aceleración es la derivada segunda 
	/// de la posición, el sistema de dos ecuaciones diferenciales de segundo orden quedará
	/// 
	/// d^2x/dt^2 = -x/r^3     :  d^2y/dt^2 = -y/r^3
	/// 
	/// </summary>
	public class Planeta: SE2ORungerKutta
	{
		public Planeta()
		{
		}

		#region implemented abstract members of SE2ORungerKutta

		public override double f(double x, double y, double vx, double vy, double t)
		{
			double r=Math.Sqrt(x*x+y*y);
        	return (-x/(r*r*r));
		}

		public override double g(double x, double y, double vx, double vy, double t)
		{
			double r=Math.Sqrt(x*x+y*y);
        	return (-y/(r*r*r));
		}

		#endregion
	}
}
