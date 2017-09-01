/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 20:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Difusion.
	/// Mecanismo de la difusión:
	/// Habremos observado que al dejar caer una gota de tinta en un recipiente de agua, 
	/// la tinta se va difundiendo en el agua hasta que esta adquiere un color aproximadamente 
	/// uniforme. Sin embargo, el proceso inverso no es observable. Cuando es filmado y 
	/// mostrado marcha atrás choca con el sentido común.
	/// 
	/// Simplifiquemos el fenómeno descrito y supongamos un recipiente cerrado dividido 
	/// en dos partes iguales. Inicialmente, situamos un conjunto de N moléculas de un 
	/// gas en el recipiente A de la izquierda, tal como se ve en la figura. Al abrir la 
	/// compuerta que comunica ambas mitades, observaremos que las moléculas van 
	/// pasando desde la izquierda hacia la derecha hasta que se establece el 
	/// equilibrio, en el que habrá aproximadamente N/2 moléculas en cada mitad. 
	/// Este equilibrio es dinámico, ya que continúan pasando moléculas desde el 
	/// primer al segundo recipiente y viceversa, pero en promedio el flujo neto 
	/// es cero. A estas oscilaciones en el número de moléculas en torno al equilibrio 
	/// les denominamos fluctuaciones. Podremos comprobar que el proceso inverso, en 
	/// el que partiendo con la mitad de las moléculas en cada parte, es muy difícil, 
	/// aunque no imposible, que todas las moléculas se agrupen en una de las dos 
	/// mitades, sobre todo si el número total de moléculas en muy grande.
	/// 
	/// Supongamos que la probabilidad de que una molécula pase de la mitad A a la 
	/// mitad B es proporcional al número N1 de moléculas en A, y por la misma razón, 
	/// la probabilidad de que una molécula pase de la mitad B a la mitad A sea proporcional 
	/// al número N2 moléculas en B, tal como se resume en la tabla.
	/// Suceso	                 Probabilidad	P. acumulada
	/// B incrementa 1 molécula	 N1/(N1+N2)      N1/(N1+N2)
	/// A incrementa 1 molécula	  N2/(N1+N2)	     1
	/// Apliquemos el procedimiento explicado  en el apartado variable aleatoria discreta. 
	/// Sea g es un número aleatorio uniformemente distribuido en el intervalo [0, 1), si se 
	/// cumple las condiciones de la primera columna de la tabla que viene a continuación, 
	/// se obtiene el correspondiente resultado de la segunda columna de dicha tabla.
	/// 
	///     Condición	            Resultado
	/// 0<= g < N1/(N1+N2)	   B aumenta en 1, A disminuye en 1
	/// N1/(N1+N2) <= g < 1	   B disminuye en 1, A aumenta en 1
	/// 
	/// Definiremos una clase que denominaremos Difusion, con dos miembros dato, el número N1 de 
	/// moléculas en el recipiente A, y el número N2 de moléculas en el recipiente B, y el tiempo t. 
	/// Una función miembro denominada evolucion calcula el número de partículas en cada recipiente 
	/// en función del tiempo, de acuerdo con el resultado del sorteo de una variable aleatoria g 
	/// uniformemente distribuida en el intervalo [0, 1).
	/// 
	/// En el constructor se establece el estado inicial del sistema: N1 de moléculas en el 
	/// recipiente A, y N2 de moléculas en el recipiente B. Se pone el contador de tiempo t a cero.
	/// </summary>
	public class Difusion
	{
		private int N1;
		private int N2;
		private int t;
		//números aleatorios
		private Random rnd = new Random();
		
		public Difusion()
		{
			
		}

		public Difusion(int N1, int N2)
		{
			this.N1 = N1;
			this.N2 = N2;
			t = 0;
		}
		public int getParticulasIzq()
		{
			return N1;
		}
		public int getParticulasDcha()
		{
			return N2;
		}

		/// <summary>
		/// La función miembro evolucion calcula el estado del sistema cada 
		/// cierto intervalo de tiempo dt, considerando una unidad de tiempo 
		/// la realización de un sorteo. Una vez que se realizan los dt sorteos 
		/// la función devuelve el número de partículas del recipiente A. 
		/// Calculamos la probabilidad p de que una partícula pase del 
		/// recipiente A al B, esta probabilidad es proporcional al número N1 
		/// de partículas del recipiente A.
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public int evolucion(int dt)
		{
			double p;
			for (int i = 0; i < dt; i++) {
				p = (double)N1 / (N1 + N2);
				if (rnd.NextDouble() < p) {
					N1--;
					N2++;
				} else {
					N1++;
					N2--;
				}
			}
			t += dt;
			return N1;
		}
		/// <summary>
		/// Para usar la clase Difusion se crea un objeto dif, pasándole el número inicial 
		/// de partículas en cada recipiente. Se fija el intervalo de tiempo dt, y se 
		/// muestra el estado del sistema en el instante i*dt, es decir, el número de 
		/// partículas del recipiente A, y el número N-N1 de partículas en el recipiente B.
		/// </summary>
		public static void Example()
		{
			Console.WriteLine("Example -- sistema difusion ---");
			int dt = 10;       //observar cada 10 unidades de tiempo
			int N = 500;
			Difusion dif = new Difusion(N, 0);
			Console.WriteLine("tiempo \t izquierda \t derecha");
			int n1 = N;
			int i = 0;
			Console.WriteLine(" " + i * dt + " \t " + n1 + " \t \t" + (N - n1));
			for (i = 1; i < 20; i++) {
				n1 = dif.evolucion(dt);
				Console.WriteLine(" " + i * dt + " \t " + n1 + " \t \t" + (N - n1));
			}
		}
	}
}
