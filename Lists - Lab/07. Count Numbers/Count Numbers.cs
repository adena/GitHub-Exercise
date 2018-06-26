using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
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
			numbers.Add(int.MaxValue);
			int currentNum = numbers[0];
			int currentCount = 1;
			

			for (int i = 1; i < numbers.Count; i++)
			{
				
				if (currentNum==numbers[i])
				{
					currentCount++;
				}
				else
				{
					Console.WriteLine($"{currentNum} -> {currentCount}");
					currentNum = numbers[i];
					currentCount = 1;
				}
			}
		}
	}
}
