/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 15/06/2017
 * Hora: 10:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace del_with_extern_method
{
	delegate void logDelegate(string arg) ;
      
      class MainClass
      {
            public static void Main(string[] args)
            {                 
                  ProgramClass programa = new ProgramClass ();
                  string valor = "";
                  do
                  {
                  Console.WriteLine("¿Que forma de log quiere?");
                  Console.WriteLine("1->Consola 2->Fichero");
                  valor = System.Console.ReadLine();
                  }
                  while (valor != "1" && valor!= "2" );                                  
                  if (valor == "1")
                  {
                        programa.SetLogMethod(
                        new logDelegate(FormasLog.ConsoleLog));
                  }
                  else if (valor =="2")
                  {
                        programa.SetLogMethod(
                        new logDelegate(FormasLog.FileLog ));
                  }
                  programa.Run ( );
            }
      }
      class ProgramClass
      {
            logDelegate logFunction;
            public void Run()
            {
                  if (logFunction == null)
                  {
                  logFunction = 
                  new logDelegate(FormasLog.ConsoleLog);
                  }
                  
                  int i = 0;
                  do
                  {
                  logFunction(
                  "Este es el log! en la iteracion " + i.ToString());
                  }
                  while (i++<100);
            }
            public void SetLogMethod(logDelegate metodo)
            {
                  logFunction = metodo;
            }
            private void Log(string texto)
            {
                  logFunction(texto);
            }                        
      }
      class FormasLog
      {
            private static StreamWriter fw;
            public static void ConsoleLog(string texto)
            {
                  System.Console.WriteLine(texto);
            }
            public static void FileLog(string texto)
            {
                  try
                  {
                        bool append = true;
                        if (fw == null)
                        {
                              append = false;
                        }
                        fw = new StreamWriter( "ficherolog.log",append);
                        fw.WriteLine(texto);
                        fw.Close();
                  }
                  catch (IOException e)
                  {                       
                        FormasLog.ConsoleLog(e.Message);
                  }
            }
      }
}