/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 27/08/2017
 * Hora: 15:38
 * 
 */
using System;

namespace IntegrationNumeric
{
	/// <summary>
	/// Description of Fourier.
	/// </summary>
	public abstract class Fourier
	{
		//coeficientes de Fourier
		public static  int MAX_ARMONICOS = 11;
		public double[] a = new double[MAX_ARMONICOS];
		public double[] b = new double[MAX_ARMONICOS];
		//discontinuidades
		protected int nDiscont;
		protected int iDiscont;
		//discontinuidad actual
		protected double P;
		//periodo
		//variables de control
		private int iArmonico = 0;
		//armónico
		private int q = 1;
		//seno o coseno
		//número de divisones en cada intervalo
		private int[] nDivisiones;
		private double[] x;
 
		public Fourier(double[] tiempo, int nDiscont)
		{
			this.nDiscont = nDiscont;
			//periodo
			P = tiempo[nDiscont - 1] - tiempo[0];
			//transformación de variable, de perido P a perido 2PI
			x = new double[nDiscont];
			x[0] = -Math.PI;
			x[nDiscont - 1] = Math.PI;
			for (int i = 1; i < nDiscont - 1; i++) {
				x[i] = (tiempo[i] - tiempo[0]) * 2 * Math.PI / (tiempo[nDiscont - 1] - tiempo[0]) - Math.PI;
			}

			for (int i = 0; i < MAX_ARMONICOS; i++) {
				a[i] = b[i] = 0.0;
			}
			nDivisiones = new int[nDiscont - 1];
		}
		//método de Simpson
		protected double integral(double a, double b, int n)
		{
			double h;
			double s;
			//el número de divisiones debe ser par
			if (n % 2 == 1)
				n++;
			h = (b - a) / n;
			s = f(a) - f(b);
			for (int i = 1; i < n; i += 2) {
				s += 4 * f(a + i * h) + 2 * f(a + (i + 1) * h);
			}
			return (s * h / 3);
		}
		
		abstract public double funcion(double t);

		private double f(double x)
		{
			double y = funcion((x * P) / (2 * Math.PI)) * Math.Sin(iArmonico * x + q * Math.PI / 2);
			return y;
		}
		private void calcular()
		{
			//se asignana 100 divisiones para el intervalo 0 - 2PI
			for (int i = 0; i < nDiscont - 1; i++) {
				nDivisiones[i] = (int)((x[i + 1] - x[i]) * 50 / Math.PI);
			}
			//calcula los coeficientes a
			q = 1;      //coseno
			for (iArmonico = 0; iArmonico < MAX_ARMONICOS; iArmonico++) {
				for (iDiscont = 0; iDiscont < nDiscont - 1; iDiscont++) {
					a[iArmonico] += integral(x[iDiscont], x[iDiscont + 1], nDivisiones[iDiscont]) / Math.PI;
				}
			}
			//calcula los coeficientes b
			q = 0;	//seno
			for (iArmonico = 0; iArmonico < MAX_ARMONICOS; iArmonico++) {
				for (iDiscont = 0; iDiscont < nDiscont - 1; iDiscont++) {
					b[iArmonico] += integral(x[iDiscont], x[iDiscont + 1], nDivisiones[iDiscont]) / Math.PI;
				}
			}
		}

		public void mostrarCoeficientes()
		{
			calcular();
			Console.WriteLine("a[0] " + a[0]);
			for (int i = 1; i < MAX_ARMONICOS; i++) {
				Console.WriteLine("a[" + i + "]=" + Math.Floor(a[i] * 1000) / 1000 + "\t" + "b[" + i + "]=" + Math.Floor(b[i] * 1000) / 1000);
			}
		}
	}
}
