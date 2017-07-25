// PhoneBookApp.cs
//
// Written by Liong Ng

using System;

namespace PhoneBook
{
	class PhoneBookApp
	{
		static void Main(string[] args)
		{
         PhoneBookAccess phoneBookAccess = new PhoneBookAccess();
         for(;;)
         {     
            //--- Display menu ---
            Console.WriteLine( "" );
            Console.WriteLine( "Enter 1 to enter a new phone book entry" );
            Console.WriteLine( "Enter 2 to view the number for a name" );
            Console.WriteLine( "Enter 3 to list all the entries" );
            Console.WriteLine( "Enter 4 to delete an entry" );
            Console.WriteLine( "Enter 5 to quit." );

            //--- Get input ---
            byte byInput;
            try
            {
               byInput = Convert.ToByte( Console.ReadLine() );
            }
            catch
            {
               Console.WriteLine( "Invalid selection, try again." );
               continue;
            }

            switch( byInput )
            {
               case 1:  // New entry
                  Person person = Person.ReadPerson();
                  PhoneNumber number = PhoneNumber.ReadNumber();
                  
                  BookEntry bookEntry = new BookEntry( person, number );
                  phoneBookAccess.AddEntry( bookEntry );
                  break;
               case 2:  // View entry
                  Person someone = Person.ReadPerson();
                  BookEntry entry = phoneBookAccess.GetEntry( someone );
                  if( entry == null )
                     Console.WriteLine( someone + " was not found. ");
                  else           
                     Console.WriteLine( "The number for "+ someone +
                                        " is " + phoneBookAccess.GetEntry(someone).GetNumber());
                  break;
               case 3:  // list entries
                  phoneBookAccess.List();
                  break;
               case 4:  // Delete entry
                  person = Person.ReadPerson();
                  phoneBookAccess.DeleteEntry( person );
                  break;
               case 5:  // quit
                  phoneBookAccess.Save();
                  Console.WriteLine("Ending program.");
                  return;
               default:
                  Console.WriteLine( "Invalid selection, try again." );
                  break;
            }
         }                  	
		}
	}
}
