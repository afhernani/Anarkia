/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/04/2017
 * Hora: 18:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Pokrsoft.Expressions;


namespace Derive
{
	class Program
	{
		public static void Main(string[] args)
		{
			Expression<Func<double, double>> circleAreaExpr = (radius) => Math.PI * radius * radius;
            Console.WriteLine(circleAreaExpr.Derive());

            ParameterExpression px = Expression.Parameter(typeof(double), "radius");
            ParameterExpression[] parms = { px };
            Expression<Func<double, double>> circleAreaExpr2 =
                Expression.Lambda<Func<double, double>>(
                    Expression.Multiply(Expression.Constant(Math.PI, typeof(double)),
                        Expression.Call(typeof(Math).GetMethod("Pow"),
            		                                    new Expression[] { px, Expression.Constant(2.0) })), parms);
            Console.WriteLine(circleAreaExpr2.Derive());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}