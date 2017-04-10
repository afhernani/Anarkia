using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WesleyNS.General.Utils;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Diccionario
{
    [Serializable]
    public class MyClass
    {
        public MyClass()
        {
        }

        public MyClass(string strVal, int intVal)
        {
            InternalValue = strVal;
            InternalInt = intVal;
        }

        public string InternalValue = "";
        public int InternalInt = 0;
    }

    [TestFixture]
    public class DictionarySerialization
    {
        private SerializableDictionary<string, MyClass> dict = null;

        [SetUp()]
        public void SetUp()
        {
            dict = new SerializableDictionary<string, MyClass>();
            dict.Add("First", new MyClass("FirstVal", 11));
            dict.Add("Second", new MyClass("SecondVal", 12));
        }

        [TearDown()]
        public void TearDown()
        {
            dict = null;
        }

        [Test()]
        public void Serialize()
        {
            XmlSerializer s = new XmlSerializer(typeof(SerializableDictionary<string, MyClass>));
            string path = Environment.CurrentDirectory + @"\SerializableDictionary.xml";
            using (StreamWriter sw = new StreamWriter(path)) {
                s.Serialize(sw, dict);
            }
        }

        [Test()]
        public void SerializeDeserializeEmpty()
        {
            SerializableDictionary<string, MyClass> emptyDict = new SerializableDictionary<string,MyClass>();

            XmlSerializer s = new XmlSerializer(typeof(SerializableDictionary<string, MyClass>));
            string path = Environment.CurrentDirectory + @"\SerializableEmptyDictionary.xml";
            
            using (StreamWriter sw = new StreamWriter(path)) {
                s.Serialize(sw, emptyDict);
            }

            SerializableDictionary<string, MyClass> newEmptyDict = null;
            using (StreamReader sr = new StreamReader(path)) {
                newEmptyDict = s.Deserialize(sr) as SerializableDictionary<string, MyClass>;
            }

            Assert.IsNotNull(newEmptyDict, "Failed Desrializing");
            Assert.AreEqual(emptyDict.Count, newEmptyDict.Count);
        }

        [Test()]
        public void SerializeDesrialize()
        {
            XmlSerializer s = new XmlSerializer(typeof(SerializableDictionary<string, MyClass>));
            string path = Environment.CurrentDirectory + @"\SerializableDictionary.xml";
            using (StreamWriter sw = new StreamWriter(path)){
                s.Serialize(sw, dict);
            }

            SerializableDictionary<string, MyClass> newDict = null;
            using (StreamReader sr = new StreamReader(path)){
                newDict = s.Deserialize(sr) as SerializableDictionary<string, MyClass>;
            }

            Assert.IsNotNull(newDict, "Failed Desrializing");
            Assert.AreEqual(dict.Count, newDict.Count);
        }
    }
}
