// PhoneNumber.cs
//
// Written by Liong Ng

using System;
using System.Runtime.Serialization;

[Serializable]
class PhoneNumber
{
   public PhoneNumber( string areaCode, string number )
   {
      this.areaCode = areaCode;
      this.number = number;
   }

   public string AreaCode
   {
      get 
      {
         return areaCode; 
      }
      set 
      {
         areaCode = value; 
      }
   }

   public string Number
   {
      get 
      {
         return number; 
      }
      set 
      {
         number = value; 
      }
   }

   public override string ToString()
   {
      return areaCode + " " + number;
   }

   // Read a person from the keyboard
   public static PhoneNumber ReadNumber()
   {
      Console.Write( "Enter area code: " );
      string readAreaCode = Console.ReadLine();
      Console.Write( "Enter number: " );
      string readNumber = Console.ReadLine();

      return new PhoneNumber( readAreaCode, readNumber );
   }

   string areaCode;
   string number;
}