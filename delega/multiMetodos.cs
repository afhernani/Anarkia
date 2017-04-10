using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace delega
{
    class MultiMetodos
    {
        delegate T midelegado<T>();
        static void Main()
        {
            midelegado<int> a = Returnfive;
            a += ReturnTen;
            Debug.WriteLine(a());
            Console.WriteLine(a());
            foreach (int i in GetAllValues(a))
            {
                Console.WriteLine(i);
                Debug.WriteLine(i);
            }
            midelegado<string> b = Returncinco;
            b += ReturnDiez;
            foreach (string i in GetAllValues(b))
            {
                Console.WriteLine(i);
                Debug.WriteLine(i);
            }
            Console.Read();

        }

        //static List<int> GetAllValues(midelegado d)
        //{
        //    List<int> result = new List<int>();
        //    foreach (var @delegate in d.GetInvocationList())
        //    {
        //        var del = (midelegado) @delegate;
        //        result.Add(del());
        //    }
        //    return  result;
        //}

        //static IEnumerable<int> GetAllValues(midelegado d)
        //{
        //    List<int> result = new List<int>();
        //    foreach (var @delegate in d.GetInvocationList())
        //    {
        //        var del = (midelegado)@delegate;
        //        yield return del();
        //    }
        //}

        static IEnumerable<T> GetAllValues<T>(midelegado<T> d)
        {
            List<int> result = new List<int>();
            foreach (var @delegate in d.GetInvocationList())
            {
                var del = (midelegado<T>)@delegate;
                yield return del();
            }
        }

        static int Returnfive()
        {
            return 5;
        }
        static string Returncinco()
        {
            return "cinco";
        }
        static int ReturnTen()
        {
            return 10;
        }
        static string ReturnDiez()
        {
            return "Diez";
        }
    }


    class MultiMetodosWithFun
    {
        //modificamos para el caso de Func.
        //delegate T midelegado<T>();
        static void Main()
        {
            Func<int> a = Returnfive;
            a += ReturnTen;
            Debug.WriteLine(a());
            Console.WriteLine(a());
            foreach (int i in GetAllValues(a))
            {
                Console.WriteLine(i);
                Debug.WriteLine(i);
            }
            Func<string> b = Returncinco;
            b += ReturnDiez;
            foreach (string i in GetAllValues(b))
            {
                Console.WriteLine(i);
                Debug.WriteLine(i);
            }
            Func<int, string, bool> f = TakeAnIntAndStringAndReutrnBool;
            Action<string> ac = TakeAStringAndReturnVoid;
            Console.Read();

        }

        private static void TakeAStringAndReturnVoid(string s)
        {
            Console.WriteLine("actin ac");
        }

        private static bool TakeAnIntAndStringAndReutrnBool(int arg, string s)
        {
            return false;
        }

        static IEnumerable<T> GetAllValues<T>(Func<T> d)
        {
            List<int> result = new List<int>();
            foreach (var @delegate in d.GetInvocationList())
            {
                var del = (Func<T>)@delegate;
                yield return del();
            }
        }

        static int Returnfive()
        {
            return 5;
        }
        static string Returncinco()
        {
            return "cinco";
        }
        static int ReturnTen()
        {
            return 10;
        }
        static string ReturnDiez()
        {
            return "Diez";
        }
    }
}
