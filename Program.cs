using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int index = 0; index < word.Length; index++)
            {
                Console.WriteLine(word[index]);
            }
        }
    }
}
