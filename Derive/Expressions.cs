/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 10/04/2017
 * Hora: 18:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Linq;
using System.Reflection;

namespace Pokrsoft.Expressions
{
	public static class ExpressionExtensions
	{
		private static Expression Simplify(this Expression e)
		{
			if (e == null)
				throw new ExpressionExtensionsException("Simplify: Expression must be non-null");

			return e;  // TODO
		}

		private static Expression Derive(this Expression e, string paramName)
		{
			// check not null expression
			if (e == null)
				throw new ExpressionExtensionsException("Derive: Expression must be non-null");
 
			switch (e.NodeType) {
			// constant rule
				case ExpressionType.Constant:
					return Expression.Constant(0.0);
			// parameter
				case ExpressionType.Parameter:
					if (((ParameterExpression)e).Name == paramName)
						return Expression.Constant(1.0);
					else
						return Expression.Constant(0.0);
			// sign change
				case ExpressionType.Negate:
					Expression op = ((UnaryExpression)e).Operand;
					return Expression.Negate(op.Derive(paramName));
			// sum rule
				case ExpressionType.Add:
					{
						Expression dleft = ((BinaryExpression)e).Left.Derive(paramName);
						Expression dright = ((BinaryExpression)e).Right.Derive(paramName);
						return Expression.Add(dleft, dright);
					}
				case ExpressionType.Subtract:
					{
						Expression dleft = ((BinaryExpression)e).Left.Derive(paramName);
						Expression dright = ((BinaryExpression)e).Right.Derive(paramName);
						return Expression.Subtract(dleft, dright);
					}
			// product rule
				case ExpressionType.Multiply:
					{
						Expression left = ((BinaryExpression)e).Left;
						Expression right = ((BinaryExpression)e).Right;
						Expression dleft = left.Derive(paramName);
						Expression dright = right.Derive(paramName);
						return Expression.Add(
							Expression.Multiply(left, dright),
							Expression.Multiply(dleft, right));
					}
			// quotient rule
				case ExpressionType.Divide:
					{
						Expression left = ((BinaryExpression)e).Left;
						Expression right = ((BinaryExpression)e).Right;
						Expression dleft = left.Derive(paramName);
						Expression dright = right.Derive(paramName);
						return Expression.Divide(
							Expression.Subtract(
								Expression.Multiply(left, dright),
								Expression.Multiply(dleft, right)),
							Expression.Multiply(right, right));
					}
			// function call
				case ExpressionType.Call:
					Expression e1 = null;
					MethodCallExpression me = (MethodCallExpression)e;
					MethodInfo mi = me.Method;

                    // TEMPORARY
                    // method should be static and its class - Math
					if (!mi.IsStatic || mi.DeclaringType.FullName != "System.Math")
						throw new ExpressionExtensionsException("Not implemented function: " + mi.DeclaringType + "/" + mi.Name);

					ReadOnlyCollection<Expression> parms = me.Arguments;//.Parameters;
					switch (mi.Name) {
						case "Pow":
                            // power rule
							e1 = 
                                Expression.Multiply(
								parms[1],
								Expression.Call(mi, 
									new Expression[] {
										parms[0],
										Expression.Subtract(parms[1], Expression.Constant(1.0))
									}));
							break;
						default:
							throw new ExpressionExtensionsException("Not implemented function: " + mi.Name);
					}
                    // chain rule
					return Expression.Multiply(e1, parms[0].Derive(paramName)); 
			// others
				default:
					throw new ExpressionExtensionsException("Not implemented expression type: " + e.NodeType.ToString());
			}
		}
 
		public static Expression<T> Derive<T>(this Expression<T> e)
		{
			// check not null expression
			if (e == null)
				throw new ExpressionExtensionsException("Expression must be non-null");

			// check just one variable
			if (e.Parameters.Count != 1)
				throw new ExpressionExtensionsException("Incorrect number of parameters. Must be 1");

			if (e.NodeType != ExpressionType.Lambda)
				throw new ExpressionExtensionsException("Functionality not supported");
			else
                // calc derivative
                return Expression.Lambda<T>(e.Body.Derive(e.Parameters[0].Name), e.Parameters);
		}

		public static Expression<T> Derive<T>(this Expression<T> e, string paramName)
		{
			// check not null expression
			if (e == null)
				throw new ExpressionExtensionsException("Expression must be non-null");

			// check 'paramName' is a valid param of the expression
			bool ok = false;
			foreach (ParameterExpression p in e.Parameters)
				if (p.Name == paramName) {
					ok = true;
					break;
				}
			if (!ok)
				throw new ExpressionExtensionsException("Invalid parameter name");

			if (e.NodeType != ExpressionType.Lambda)
				throw new ExpressionExtensionsException("Functionality not supported");
			else
                // calc derivative
                return Expression.Lambda<T>(e.Body.Derive(e.Parameters[0].Name), e.Parameters);
		}
	}

	public class ExpressionExtensionsException: Exception
	{
		public ExpressionExtensionsException(string msg)
			: base(msg, null)
		{
		}
		public ExpressionExtensionsException(string msg, Exception innerException)
			: base(msg, innerException)
		{
		}
	}
}
