using System;
using System.Linq;
using Advent.Days.Utils;

namespace Advent.Days
{
	public static class DayOne
	{
		
		public static void Part_One(string Puzzle)
		{
			int[] Data = Utilities.Parse(Puzzle, '\n');
			int fuelSum = Data.Select(fuel => CalcFuel(fuel)).Sum();

			Console.WriteLine("Part 1:");
			Console.WriteLine("".PadRight(fuelSum.ToString().Length, '-'));
			Console.WriteLine(fuelSum);
			Console.WriteLine();
		}

		public static void Part_Two(string Puzzle)
		{
			int[] Data = Utilities.Parse(Puzzle, '\n');
			int fuelSum = Data.Aggregate( 0, (total, fuel) => total + RecursCalcFuel(fuel));

			Console.WriteLine("Part 2:");
			Console.WriteLine("".PadRight(fuelSum.ToString().Length, '-'));
			Console.WriteLine(fuelSum);
			Console.WriteLine();
		}

		public static int CalcFuel(int fuel) => (fuel / 3) - 2;

		public static int RecursCalcFuel(int fuel)
		{
			int f = Math.Max((fuel / 3) - 2, 0);
			return f + (f > 0 ? RecursCalcFuel(f) : 0);
		}
	}
}
