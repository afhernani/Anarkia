using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AttributeWorking
{
    class TestAttribute : System.Attribute { }
    class TestMethodAttribute : System.Attribute { }

    [TestAttribute]
    class MyTestSuite
    {
        public void HelperMethod(RichTextBox rbox)
        {
            rbox.AppendText("some Helper Method ...\n");
        }
        [TestMethodAttribute]
        public void Mytest1(RichTextBox rbox)
        {
            rbox.AppendText("Doing some testing ...\n");
            HelperMethod(rbox);
        }
        [TestMethod]
        public void Mytest2(RichTextBox rbox)
        {
            rbox.AppendText("Doing some testing two ...\n");
            HelperMethod(rbox);
        }
    }
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
