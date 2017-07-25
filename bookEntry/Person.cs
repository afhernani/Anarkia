// Person.cs
//
// Written by Liong Ng

using System;
using System.Runtime.Serialization;

[Serializable]
class Person
{
   public Person( string firstName, string lastName )
   {
      this.firstName = firstName;
      this.lastName = lastName;
   }

   public string FirstName
   {
      get 
      {
         return firstName; 
      }
   }

   public string LastName
   {
      get 
      {
         return lastName; 
      }
   }

   public override string ToString()
   {
      return firstName + " " + lastName;
   }

   public override Boolean Equals( Object obj )
   {
      if ( obj == null ) return false;

      if ( this.GetType() != obj.GetType() ) return false;

      Person person = (Person) obj;

      if ( !Object.Equals( firstName, person.FirstName ) ) return false;
      if ( !Object.Equals( lastName, person.LastName ) ) return false;

      return true;
   }

   public override int GetHashCode()
   {
      return firstName.GetHashCode() ^ lastName.GetHashCode();
   }

   //--- Read a person from the keyboard ---
   public static Person ReadPerson()
   {
      Console.Write( "Enter last name: " );
      string readLastName = Console.ReadLine();
      Console.Write( "Enter first name: " );
      string readFirstName = Console.ReadLine();

      return new Person( readLastName, readFirstName );
   }

   private string firstName;
   private string lastName;

}