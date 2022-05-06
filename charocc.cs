using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ArrayProgram
{
    class charocc
    {
        static void Main(string[] args)
        {
            string str = "sayali";
            char ch = 'a';

            int freq = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    freq++;
                }
            }

            Console.WriteLine(freq);
        }
    }

}
    

