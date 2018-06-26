using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> numbers = Console.ReadLine()
				.Split(' ')
				.Select(double.Parse)
				.ToList();
			
			while (true)
			{
				bool noEqualCells = true;
				for (int i = 1; i < numbers.Count; i++)
				{
					if (numbers[i - 1] == numbers[i])
					{
						numbers[i] += numbers[i - 1];
						numbers.RemoveAt(i - 1);
						noEqualCells = false;
						break;
					}
				}
				if (noEqualCells)
				{
					Console.WriteLine(string.Join(" ", numbers));
					return;
				}
				
			}
			

		}
	}
}
