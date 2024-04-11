using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            char[] array = new char[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            int замены = 0;

            Console.WriteLine("----");

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == ':')
                {
                    array[i] = ';';
                    замены++;
                }
                Console.WriteLine(array[i]);

            }
            Console.WriteLine("Замены: " + замены);
            Console.ReadKey();
        }
        
    }
}
