using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class CharacterCounter
    {

        public static void Run()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Dictionary<char, int> characterCounter = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                    continue;

                if(characterCounter.ContainsKey(input[i]))
                    characterCounter[input[i]]++;
                else
                    characterCounter[input[i]] = 1;
            }

            Console.WriteLine("Character counter:");

            foreach(var keyValuePair in characterCounter)
            {
                Console.WriteLine($"'{keyValuePair.Key}' : {keyValuePair.Value}");

            }
        }
    }
}
