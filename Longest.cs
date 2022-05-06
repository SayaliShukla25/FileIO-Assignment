using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ArrayProgram
{
    class Longest
    {
        static void Main(string[] args)
        {
            string line = "India is my country.";
            string[] words = line.Split(" " );
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

        }
    }
}
