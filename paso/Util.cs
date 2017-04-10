/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 18/09/2016
 * Hora: 7:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace paso
{
	/// <summary>
	/// Description of Util.
	/// </summary>
	public class Util
	{
		public Util()
		{
		}
		delegate IEnumerable getChilds<T>(T Element);
		IEnumerable<T> FindRecursive<T>(T parent, getChilds<T> Elements, Predicate<T> criteria)
		{	
			foreach (T element in Elements.Invoke(parent) )
			{
				if(criteria.Invoke(element))
			         	   yield return element;
				foreach (T element2 in FindRecursive<T>(element,Elements,criteria))
				{
					yield return element2;
				}
			}			
		}
		readonly Predicate<Control> LookForPanel = (Control c) => c is Panel;
		readonly Predicate<Control> LookForPictureBox = (Control c) => c is PictureBox;
		
		readonly getChilds<Control> getChildControls = (Control c)=> c.Controls;
		
		public void SearchPanelinForm(System.Windows.Forms.Form control)
		{
			foreach (var element in FindRecursive<Control>(control, getChildControls,LookForPanel))
			{
				Debug.WriteLine(element.Name);
			}
		}
		public void SearchPictureBoxinForm(System.Windows.Forms.Form control)
		{
			foreach (var element in FindRecursive<Control>(control, getChildControls,LookForPictureBox))
			{
				Debug.WriteLine(element.Name);
			}
		}
		
		
		public IEnumerable<T> FindRecursive<T>(T parent, Func<T,IEnumerable> Elements, Predicate<T> criteria)
		{	
			foreach (T element in Elements.Invoke(parent) )
			{
				if(criteria.Invoke(element))
			         	   yield return element;
				foreach (T element2 in FindRecursive<T>(element,Elements,criteria))
				{
					yield return element2;
				}
			}			
		}
		
	}
}
