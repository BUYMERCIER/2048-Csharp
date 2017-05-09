using System;
namespace Application
{
	public class Controller
	{
		public Controller()
		{
		}

		public enum Action {Up, Down, Left, Right, Quit};
		public Action action = Action.Down;

		public Action GetAction() {
			ConsoleKey key = Console.ReadKey().Key;
			Action act;
			switch (key) { 
				case ConsoleKey.UpArrow:
					act = Action.Up;
					break;
				case ConsoleKey.DownArrow:
					act = Action.Down;
					break;
				case ConsoleKey.LeftArrow:
					act = Action.Left;
					break;
				case ConsoleKey.RightArrow:
					act = Action.Right;
					break;
				case ConsoleKey.Escape:
					act = Action.Quit;
					break;
				default:
					act = GetAction();
					break;
			}
			return act;
		}
		//

		public void move(Action action, Grid grid) {
			
			if (action == Action.Down) { // Down
				for (int y = grid.grid.GetLength(1) - 1; y >= 0; y--)
				{
					for (int x = grid.grid.GetLength(0) - 1; x >= 0; x--)
					{
						if (grid.grid[x, y] != " " && x + 1 < grid.grid.GetLength(1))
						{
							if (grid.grid[x + 1, y] == " ")
							{
								grid.grid[x + 1, y] = grid.grid[x, y];
								grid.grid[x, y] = " ";
							}
						}
					}
				}
			}
			// else 

		}
		//
	}
}
