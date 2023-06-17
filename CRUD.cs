using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace NlogandCRUD
{
    internal class CRUD
    {
        public static void Data()
        {
            ArrayList values = new ArrayList();
            values.Add("Ajay");
            values.Add("Chandra"); // adding the values

            Console.WriteLine("Elements Added ");
            foreach (string name in values)
            {
                
                Console.WriteLine(name);
                Console.WriteLine();
            }

            values[1] = "Awesome";
            Console.WriteLine("Updated the values ");

            foreach (string name in values) // updating the data
            {
               
                Console.WriteLine(name);
                Console.WriteLine();
            }

            values.Remove(0);
            Console.WriteLine("Delete the values ");
            foreach (string name in values) // remove or delete the data
            {
                
                Console.WriteLine(name);
            }
        }

        public class Dictionaryoperations
        {
            public static void Data2()
            {
                Dictionary<int, string> values = new Dictionary<int, string>();

                values.Add(1, "Ajay");
                values.Add(2, "Chandra");
                Console.WriteLine("Added the elements");
                foreach(KeyValuePair<int, string> elements in values) //added the elements
                {
                    Console.WriteLine(elements);
                }

                values[2] = "Awesome";
                Console.WriteLine("Updated the elements");
                foreach (KeyValuePair<int, string> elements in values) // updated the elements
                {
                    Console.WriteLine(elements);
                }

                values.Remove(1);
                Console.WriteLine("Delete the elements");
                foreach (KeyValuePair<int, string> elements in values) // delete the data or elements
                {
                    Console.WriteLine(elements);
                }
            }
        }
    }
}
