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
	}
}
