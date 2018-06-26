using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			numbers.Sort();
			numbers.Reverse();

			List<int> result = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				double square = Math.Sqrt(numbers[i]);
				if (square == (int) square)
				{
					result.Add(numbers[i]);
				}
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
