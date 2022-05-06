using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ArrayProgram
{
	class MinElem
	{
		static void Main(string[] args)
		{

			int min = 0;
			int[] arr = new int[5];

			Console.WriteLine("Enter array elements : ");
			for (int i = 0; i < arr.Length; i++)
			{
			
				arr[i] = int.Parse(Console.ReadLine());
			}

            min = arr[0];

			for (int i = 1; i < arr.Length; i++)
			{

				if (min > arr[i])
					min = arr[i];
			}

			Console.WriteLine("Smallest element in array is : " + min);
		}
	}
}
    

