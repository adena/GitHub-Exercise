using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers_2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			int[] numbersCount = new int[1001];
			for (int i = 0; i < numbers.Count; i++)
			{
				int currentNum = numbers[i];

				numbersCount[currentNum]++;
			}
			for (int i = 0; i < numbersCount.Length; i++)
			{
				if (numbersCount[i]>0)
				{
					Console.WriteLine($"{i} -> {numbersCount[i]}");
				}
			}
		}
	}
}
