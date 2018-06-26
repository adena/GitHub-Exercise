using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			bool isEmpty = true;
			List<int> result = new List<int>();
			
			for (int i = numbers.Count-1; i >=0; i--)
			{
				if (numbers[i] >= 0)
				{
					result.Add(numbers[i]);
					isEmpty = false;
				}
			}
			if (isEmpty)
			{
				Console.WriteLine("empty");
			}
			else
			{
				Console.WriteLine(string.Join(" ", result));
			}
		}
	}
}
