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

		public void move(Action action, Grid grid, Number number) {
			if (action == Action.Down)
			{ // Down
				for (int z = 0; z < 4; z++)
				{
					for (int y = grid.grid.GetLength(1) - 1; y >= 0; y--)
					{
						for (int x = grid.grid.GetLength(0) - 1; x >= 0; x--)
						{
							if (grid.grid[x, y] != "    " && x + 1 < grid.grid.GetLength(1))
							{
								if (grid.grid[x + 1, y] == "    ")
								{
									grid.grid[x + 1, y] = grid.grid[x, y];
									grid.grid[x, y] = "    ";
								}
								else if (grid.grid[x + 1, y] == grid.grid[x, y]) {
									int ad = Convert.ToInt32(grid.grid[x, y]) * 2;
									grid.grid[x + 1, y] = Convert.ToString(ad);
									grid.grid[x, y] = "    ";
									UpdateScore(ad);
								}
							}
						}
					}
				}
			}
			else if (action == Action.Up)
			{ // Up
				for (int z = 0; z < 4; z++)
				{
					for (int y = 0; y < grid.grid.GetLength(0); y++)
					{
						for (int x = 0; x < grid.grid.GetLength(1); x++)
						{
							if (grid.grid[x, y] != "    " && x - 1 >= 0)
							{
								if (grid.grid[x - 1, y] == "    ")
								{
									grid.grid[x - 1, y] = grid.grid[x, y];
									grid.grid[x, y] = "    ";
								}
								else if (grid.grid[x - 1, y] == grid.grid[x, y])
								{
									int ad = Convert.ToInt32(grid.grid[x, y]) * 2;
									grid.grid[x - 1, y] = Convert.ToString(ad);
									grid.grid[x, y] = "    ";
									UpdateScore(ad);
								}
							}
						}
					}
				}
			}
			//
			else if (action == Action.Left)
			{ // left
				for (int z = 0; z < 4; z++)
				{
					for (int y = 0; y < grid.grid.GetLength(0); y++)
					{
						for (int x = 0; x < grid.grid.GetLength(1); x++)
						{
							if (grid.grid[x, y] != "    " && y - 1 >= 0)
							{
								if (grid.grid[x, y - 1] == "    ")
								{
									grid.grid[x, y - 1] = grid.grid[x, y];
									grid.grid[x, y] = "    ";
								}
								else if (grid.grid[x, y - 1] == grid.grid[x, y])
								{
									int ad = Convert.ToInt32(grid.grid[x, y]) * 2;
									grid.grid[x, y - 1] = Convert.ToString(ad);
									grid.grid[x, y] = "    ";
									UpdateScore(ad);
								}
							}
						}
					}
				}
			}
			//
			else if (action == Action.Right)
			{ // right
				for (int z = 0; z < 4; z++)
				{
					for (int y = 0; y < grid.grid.GetLength(0); y++)
					{
						for (int x = 0; x < grid.grid.GetLength(1); x++)
						{
							if (grid.grid[x, y] != "    " && y + 1 < grid.grid.GetLength(0)) // not working
							{
								if (grid.grid[x, y + 1] == "    ")
								{
									grid.grid[x, y + 1] = grid.grid[x, y];
									grid.grid[x, y] = "    ";
								}
								else if (grid.grid[x, y + 1] == grid.grid[x, y])
								{
									int ad = Convert.ToInt32(grid.grid[x, y]) * 2;
									grid.grid[x, y + 1] = Convert.ToString(ad);
									grid.grid[x, y] = "    ";
									UpdateScore(ad);
								}
							}
						}
					}
				}
			}
			//// Quit
			else if (action == Action.Quit)
			{
				Environment.Exit(0);
			}
		}
		//

		public void UpdateScore(int ad) {
			Score.score += ad;
		}
	}
}
