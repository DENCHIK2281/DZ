using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main (string [] abobka) 
		{
			Random rnd = new Random();
			int[,] a = new int[7, 7];
			int d = 0;
			for (int i = 0; i < 7; i++) 
			{
				for (int j = 0; j < 7; j++) 
				{
					a[i, j] = rnd.Next(-5, 5);
					if (a[i, j] < 0 && Math.Abs(a[i, j]) % 2 == 1)
						d += Math.Abs(a[i, j]);
					Console.WriteLine( a [i, j]);
				}
				Console.WriteLine();
				
			}
			
			Console.ReadKey(); 








		}
	}
}
