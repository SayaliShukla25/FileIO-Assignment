using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ArrayProgram
{
    class Oddelem
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 5, 6, 4, 3, 5, 6, 8 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("sum of odd elments:"+sum);

        }
    }
}

