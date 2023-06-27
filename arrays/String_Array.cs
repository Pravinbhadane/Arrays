using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class String_Array
    {
        static void Main(string[] args)
        {

            string[] names = new string[10] { "pravin", "gaurav", "pawan", "mayur", "kartik", "piyush", "rishabh", "pritesh", "pranav", "pankaj" };

            string[] names2 = new string[10];

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Array.Sort(names);
            Console.WriteLine("------after sort------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(names);

            Console.WriteLine("------after reverse------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Array.Copy(names, 1, names2, 0, 8);
            Console.WriteLine("--after copy------");
            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
