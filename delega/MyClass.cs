using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace delega
{
    class MyClass
    {
        static void Main()
        {
            Action del = (Action) Moo + BeNaghty + Goo;
            foreach (Delegate @delegate in del.GetInvocationList())
            {
                try
                {
                    var i = (Action) @delegate;
                    i();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            //del();
            //landa expresines
            Func<int, bool> func = i => i > 5;
            Console.WriteLine(func(5));
            Console.WriteLine(func(10));
            Console.Read();
        }
        static void Moo() { Console.WriteLine("Moo()");}
        static void BeNaghty()
        {
            var exception = new Exception("mi exception");
        }

        static void Goo() { Console.WriteLine("Goo()");}
    }

    class MyClass2
    {
        static void Main()
        {
            //int i = 0;
            //Action a = () => i++;
            //for (int j = 0; j < 10; j++)
            //{
            //    a();
            //    Console.WriteLine(i);
            //}
            //
            Action b = GivemeAction;
            for (int j = 0; j < 10; j++)
            {
                b();
                Console.WriteLine("-");
            }
            //si está en la ruta
            bool ruta = File.Exists("ffmpge.exe");
            Console.WriteLine(ruta);
            IDictionary variablesEntorno = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in variablesEntorno)
            {
                Console.WriteLine(de.Key + ": " + de.Value);
            }
            //una en concreto.
            Console.WriteLine(
            Environment.GetEnvironmentVariable("Path"));
            Console.WriteLine(" ---ZZZZZZZZZZZ----");
            string[] path = Environment.GetEnvironmentVariable("Path").Split(Convert.ToChar(";"));
            foreach (string str in path)
            {
                if (File.Exists(Path.Combine(str, "ffmpeg.exe")))
                {
                    Console.WriteLine("El fichero existe en {0}", str);
                };
            }
            //pausa.
            Console.Read();
        }

        //static int i = 0;
        static void GivemeAction()
        {
            int i = 0;
            //i++;
            Action a =() => i++;
            Console.WriteLine(i);
        }
    }
}
