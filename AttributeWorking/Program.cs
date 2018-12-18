using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AttributeWorking
{
    class TestAttribute : System.Attribute { }

    [TestAttribute]
    class MyTestSuite { }
    [TestAttribute]
    class YourSuite { }
    [TestAttribute]
    class TheirSuite { }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Attribute());
        }
    }
}
