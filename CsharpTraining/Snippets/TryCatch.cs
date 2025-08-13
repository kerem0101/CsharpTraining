using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class TryCatch
    {
        public static void Run()
        {
            int[] array = {1,2,3};

            try
            {
                Console.Write("Choose the array index: ");
                int index = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"array[index]: {array[index]}");
            }
            catch (Exception message) 
            {
                Console.WriteLine($"{message}");
            }
        }
    }
}
