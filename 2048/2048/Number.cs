using System;
namespace Application
{
	public class Number
	{
		public Number()
		{
		}
		public void Generate2(Grid grid) {
			Random rand = new Random();
			int first = rand.Next(4);
			int second = rand.Next(4);
			int number = rand.Next(10);
			// 10 percent of chance of being a 4. as in the real game :)

			if (number == 0)
			{
				number = 4;
			}
			else { 
				number = 2;
			}

			string num = Convert.ToString(number);

			if (grid.grid[first, second] == "    ")
			{
				grid.grid[first, second] = num;
			}
			else {
				Generate2(grid);
			}
		}
		//

		public void GetColor(string number) { // Working
			ConsoleColor color;
			switch (number) { 
				case "2":
					color = ConsoleColor.Yellow;
					break;
				case "4":
					color = ConsoleColor.Gray;
					break;
				case "8":
					color = ConsoleColor.DarkGray;
					break;
				case "16":
					color = ConsoleColor.DarkBlue;
					break;
				case "32":
					color = ConsoleColor.Blue;
					break;
				case "64":
					color = ConsoleColor.Cyan;
					break;
				case "128":
					color = ConsoleColor.DarkCyan;
					break;
				case "256":
					color = ConsoleColor.DarkGreen;
					break;
				case "512":
					color = ConsoleColor.Green;
					break;
				case "1024":
					color = ConsoleColor.DarkRed;
					break;
				case "2048":
					color = ConsoleColor.Red;
					break;
				default:
					color = ConsoleColor.Red;
					break;
			}
			// the color remains red whenever the number is greater or equal to 2048
			Console.ForegroundColor = color;
			if (number.Length == 1)
			{
				Console.Write("   ");
			}
			else if (number.Length == 2) { 
				Console.Write("  ");
			}
			else if (number.Length == 3)
			{
				Console.Write(" ");
			}
			Console.Write(number);
			Console.ForegroundColor = ConsoleColor.White;
		}
		//
	}
}