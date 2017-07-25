// PhoneBookAccess.cs
//
// Written by Liong Ng

using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
class PhoneBookAccess
{
   public PhoneBookAccess()
   {
      Stream s = null;
      try
      {
         s = File.Open("Phone.bin", FileMode.Open, FileAccess.Read);
         BinaryFormatter b = new BinaryFormatter();
         table = (Hashtable) b.Deserialize(s);
      }
      catch( FileNotFoundException )
      {
         table = new Hashtable();
      }
      finally
      {
         if ( s != null ) s.Close();
      }
   }

   public void AddEntry(BookEntry entry)
   {
      table.Add( entry.GetPerson(), entry );
   }

   public BookEntry GetEntry(Person key)
   {
      return (BookEntry) table[key];
   }

   public void DeleteEntry(Person key)
   {
      table.Remove( key );
   }

   public PhoneNumber GetNumber(Person key)
   {
      return GetEntry(key).GetNumber();
   }

   public void List()
   {
      foreach( DictionaryEntry d in table )
         Console.WriteLine( "{0}", d.Value );
   }

   public void Save()
   {
      Stream s = null;
      try
      {
         s = File.Open("Phone.bin", FileMode.Create, FileAccess.ReadWrite);
         BinaryFormatter b = new BinaryFormatter();
         b.Serialize(s, table);
      }
      finally
      {
         if ( s != null ) s.Close();
      }
   }

   private Hashtable table;
}