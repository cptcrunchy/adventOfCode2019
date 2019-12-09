using System.Linq;
using System.Text;
using System.IO;

namespace Advent.Days.Utils
{
	public static class Utilities
	{
		public static string DataDirectory { get; set; } = @".\Data\";

		public static int[] Parse(string input, char delimiter) => input.Split(delimiter).Select(n => int.Parse(n)).ToArray();

		public static string GetPuzzle(string puzzleName) => File.ReadAllText(DataDirectory + $"{puzzleName}.txt", Encoding.UTF8);
	}
}
