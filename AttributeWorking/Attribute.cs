using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttributeWorking
{
    public partial class Attribute : Form
    {
        public Attribute()
        {
            InitializeComponent();
        }

        private void Attribute_Load(object sender, EventArgs e)
        {
            //foreach (Type t in Assembly.GetEntryAssembly().GetTypes())
            //{
            //    richTextBox1.Text += $"{t.Name}\n";
            //    foreach (System.Attribute a in t.GetCustomAttributes(false))
            //    {
            //        if (a is TestAttribute)
            //        {
            //            richTextBox1.AppendText(t.Name + "is a test suite!\n");
            //        }
            //    }
            //}

            //usando linq.
            var testSuites = from t in Assembly.GetEntryAssembly().GetTypes()
                             where t.GetCustomAttributes(false).Any(a => a is
                             TestAttribute)
                             select t;
            foreach (Type t in testSuites)
            {
                richTextBox1.AppendText("running test in suite "+t.Name + "\n");
                var testMethods =
                    from m in t.GetMethods()
                    where m.GetCustomAttributes(false).Any(a => a is TestMethodAttribute)
                    select m;
                //instanciamos un objeto de esta clase
                object testSuiteInstance = Activator.CreateInstance(t);
                foreach (MethodInfo mInfo in testMethods)
                {
                    mInfo.Invoke(testSuiteInstance, new object[] { richTextBox1 });
                }
            }
        }
    }
}
