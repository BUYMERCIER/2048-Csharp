using System;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Grid grid = new Grid();
			Controller controller = new Controller();
			Number number = new Number();
			// Initialising the grid
			number.Generate2(grid);
			number.Generate2(grid);

			while (grid.win == 0) { 
				grid.printGrid();
				controller.GetAction();
				number.Generate2(grid);
				grid.checkGrid();
			}
			grid.printGrid();
			winlose(grid.win);
		}
		//

		private static void winlose(int win) {
			if (win < 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("YOU LOSE");
			}
			else { 
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("YOU WIN");
			}
		}
	}
}
