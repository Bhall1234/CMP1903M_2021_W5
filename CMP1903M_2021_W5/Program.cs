using System;
using System.Collections.Generic;

namespace CMP1903M_2021_W5
{
    class Program
    {
        static void Main(string[] args)
        {
            //List called 'names' to hold a list of names
            List<string> names = new List<string>();
            names.Add("Olivia");
            names.Add("Oliver");
            names.Add("Amelia");
            names.Add("George");
            names.Add("Isla");
            names.Add("Harry");
            names.Add("Ava");
            names.Add("Noah");
            names.Add("Emily");
            names.Add("Jack");

            /*
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            if(names.Contains("Noah") && !names.Contains("David"))
            {
                Console.WriteLine("The list contains the name Noah but not David");
            }
            else if(!names.Contains("Noah") && names.Contains("David"))
            {
                Console.WriteLine("The list contains the name David but not Noah");
            }
            else
            {
                Console.WriteLine("Neither Noah or David are in the list!");
            }

            //Add the names in the workshop task sheet to the list
            //Use 'Add()' or a list initialiser (List<string> names = new List<string>(){"Olivia", "Oliver", "etc"};)

            //Check to see if some names are in the list...?

            
            //Create a simple search method to check if a name is in the list - don't use LINQ!
        }
    }
}
