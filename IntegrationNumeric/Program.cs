/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 14:16
 * 
 * 
 */
using System;

namespace IntegrationNumeric
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			try {
				//por el metodo del trapecio.
				double resultado = new fcos().integral(0.0, Math.PI / 2, 10);
				Console.WriteLine("integral metodo trapecio: {0} ", resultado);
				double result = new sfcos().integral(0.0, Math.PI / 2, 10);
				Console.WriteLine("integral metodo simpson: {0}", result);
				//utilizando las funcioens de fourier
				int eleccion = 1;
				Console.WriteLine("Seleccione un tipo de funcion de fourier " +
				"\n 1 - pulso, 2. - doble pulsacion " +
				"\n 3 - Diente 4. - Diente de sierra ");
				eleccion = Convert.ToInt32(Console.ReadLine());
				Fourier fo = null;
				switch (eleccion) {
					case 1:
						fo = pulso();
						break;
					case 2:
						fo = pulsoDoble();
						break;
					case 3:
						fo = Diente();
						break;
					case 4:
						fo = DienteSierra();
						break;
					default:
						break;
				}
				if (fo != null)
					fo.mostrarCoeficientes();
				
				//utilizando la taza de desintegración radiactiva.
				Console.WriteLine("Taza de desintegracion Radio-activa ");
				TazaDesintegracion();
				Console.WriteLine("Calculo doble taza de desintegracion Radio-activa ");
				dobledesintegracion();
				Oscilacion();
				Planeta();
				RandomObjectDemo.main();
				Azar.main();
				Difusion.Example();
				
			} catch {
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static Fourier pulso()
		{
			double anchura = 2.0;
			double periodo = 4.0;
			double traslacion = 0.0;
			double[] tiempo = new double [4];
			tiempo[0] = -periodo / 2;
			tiempo[1] = -anchura / 2 + traslacion;
			tiempo[2] = anchura / 2 + traslacion;
			tiempo[3] = periodo / 2;
			return new PulsoRegular(tiempo, 4);
		}
		static Fourier pulsoDoble()
		{
			double anchura = 2.0;
			double periodo = 4.0;
			double profundidad = 1.0;
			double[] tiempo = new double [5];
			tiempo[0] = -periodo / 2;
			tiempo[1] = -anchura / 2;
			tiempo[2] = 0.0;
			tiempo[3] = anchura / 2;
			tiempo[4] = periodo / 2;
			return new PulsoDobleEscalon(tiempo, 5, profundidad);
		}
		
		static Fourier Diente()
		{
			double periodo = 4.0;
			double[] tiempo = new double [3];
			tiempo[0] = -periodo / 2;
			tiempo[1] = 0.0;
			tiempo[2] = periodo / 2;
			return new PulsoDiente(tiempo, 3);
		}
		static Fourier DienteSierra()
		{
			double periodo = 4.0;
			double[] tiempo = new double [3];
			tiempo[0] = -periodo / 2;
			tiempo[1] = 0.0;
			tiempo[2] = periodo / 2;
			return new PulsoDienteSierra(tiempo, 3);
		}
		static void TazaDesintegracion()
		{
			double h = 0.5;       //paso
			double x0 = 5000;     //número inicial   en el instante t=0
			double t = 20.0;      //resolver la e. d. hasta este instante
			//valor aproximado
			double x = new TazaDesintegracionRadioactiva().resolver(t, 0, x0, h);
			Console.WriteLine("valor aprox. de x {0}", (int)x);
			// valor exacto
			x = (int)(x0 * Math.Exp(-0.1 * t));
			Console.WriteLine("valor exacto de x {0}", (int)x);
		}
		static void dobledesintegracion()
		{
			double h = 0.5;       //paso
			//Situación inicial
			double x0 = 5000;
			Estado es = new Estado(0, x0, 0);
			double t = 20.0;  //resolver la e. d. hasta este instante

			new DobleDesintegracion().resolver(t, es, h);
			Console.WriteLine("valor aprox. de x " + (int)es.x);
			Console.WriteLine("valor aprox. de y " + (int)es.y);
			// valor exacto
			double x = (int)(x0 * Math.Exp(-0.1 * t));
			double y = (int)(0.1 * x0 * (Math.Exp(-0.1 * t) - Math.Exp(-0.2 * t)) / 0.1);
			Console.WriteLine("valor exacto de x " + (int)x);
			Console.WriteLine("valor exacto de y " + (int)y);
		}
		static void Oscilacion()
		{
			Console.WriteLine("Movimiento Oscilatorio pendulo. ");
			double h = 0.01;       //paso
			//Situación inicial
			double x0 = 1.5;      //posición inicial
			double v0 = 10.0;      //velocidad inicial
			Estado es = new Estado(0.0, x0, v0);
			double t = 2.0;      //resolver la e. d. hasta este instante
	
			double w = 2.0;   //frecuencia propia oscilaciones libres
			double g = 0.5;   //cte de amortiguamiento
			//oscilaciones libres
			Console.WriteLine("Oscilaciones libres");
			OsciladorArmonico os = new OsciladorArmonico(w);
			os.resolver(t, es, h);
			Console.WriteLine("posición aprox. " + es.x);
			Console.WriteLine("velocidad aprox. " + es.y);
			// valor exacto
			double fi = Math.Atan(w * x0 / v0);
			double A = x0 / Math.Sin(fi);
			double x = A * Math.Sin(w * t + fi);
			double v = A * w * Math.Cos(w * t + fi);
			Console.WriteLine("posición exacta " + x);
			Console.WriteLine("velocidad exacta " + v);
			//oscilaciones amortiguadas
			Console.WriteLine("Oscilaciones amortiguadas");
			es = new Estado(0.0, x0, v0);
			new OsciladorAmortiguado(g, w).resolver(t, es, h);
			Console.WriteLine("posición aprox. " + es.x);
			Console.WriteLine("velocidad aprox. " + es.y);
			// valor exacto
			double w1 = Math.Sqrt(w * w - g * g);
			fi = Math.Atan(w1 * x0 / (v0 + g * x0));
			A = x0 / Math.Sin(fi);
			x = A * Math.Exp(-g * t) * Math.Sin(w1 * t + fi);
			Console.WriteLine("posición exacta " + x);
			v = A * Math.Exp(-g * t) * (-g * Math.Sin(w1 * t + fi) + w1 * Math.Cos(w1 * t + fi));
			Console.WriteLine("velocidad exacta " + v);
		}
		static void Planeta()
		{
			Console.WriteLine("posicion de un planeta ");
			/*
			 * Los pasos para usar la clase Planeta son los siguientes
					Establecer la magnitud del paso h
					Introducir el estado inicial de la partícula (su posición y su velocidad inicial)
					Establecer el tiempo final t, en el que deseamos calcular el nuevo estado del planeta.
					Crear un objeto de la clase Planeta y llamar a la función miembro resolver.
					Mostrar la posición y velocidad final del planeta.
			 */
			double h = 0.1;       //paso
			//Situación inicial
			double x0 = 1.0;      //amplitud
			double vy0 = 1.2;      //amplitud
			Estado es = new Estado(0, x0, 0.0, 0.0, vy0);
			double t = 10.0;      //resolver la e. d. hasta este instante

			new Planeta().resolver(t, es, h);
			Console.WriteLine("posición aprox. x " + es.x);
			Console.WriteLine("posición aprox. y " + es.y);
			Console.WriteLine("velocidad aprox. vx " + es.vx);
			Console.WriteLine("velocidad aprox. vy " + es.vy);
		}
		
	}
}