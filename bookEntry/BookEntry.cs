// BookEntry.cs
//
// Written by Liong Ng

using System;
using System.Runtime.Serialization;

[Serializable]
class BookEntry
{
   public BookEntry( Person person, PhoneNumber number )
   {
      this.person = person;
      this.number = number;
   }

   public Person GetPerson()
   {
      return person;
   }

   public PhoneNumber GetNumber()
   {
      return number; 
   }

   public override string ToString()
   {
      return person.ToString() + "\t" + number.ToString();
   }

   private Person person;
   private PhoneNumber number;
}