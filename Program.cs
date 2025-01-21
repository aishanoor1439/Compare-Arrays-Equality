using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Arrays_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first array:");
            string[] array1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter the second array:");
            string[] array2 = Console.ReadLine().Split(' ');

            if (array1.Length != array2.Length)
            {
                Console.WriteLine("The arrays are not equal.");
                return;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("The arrays are not equal.");
                    return;
                }
            }

            Console.WriteLine("The arrays are equal.");
        }
    }
}
