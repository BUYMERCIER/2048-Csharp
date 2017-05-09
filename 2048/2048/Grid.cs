using System;
namespace Application
{
	public class Grid
	{

		public string[,] grid = new string[4,4];
		public Number number = new Number();
		public int win = 0; // win = 0 not dead and npt winning win = -1 DEAD win = 1 WON

		public void printGrid() {

			int width = this.grid.GetLength(0);
			int length = this.grid.GetLength(1);
			Console.Clear();

			for (int x = 0; x < width; x++) {
				Console.Write("-----------------\n|");

				for (int y = 0; y < length; y++) {
					Console.Write(" ");
					number.GetColor(this.grid[x, y]);
					Console.Write(" |");
				}
				Console.WriteLine();
			}
			Console.WriteLine("-----------------");
		}
		//

		public Grid()
		{
			int width = this.grid.GetLength(0);
			int length = this.grid.GetLength(1);

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < length; y++)
				{
					this.grid[x, y] = " ";
				}
			}
		}
		//

		public void checkGrid() 
		{
			win = -1;

			for (int x = 0; x < this.grid.GetLength(0); x++)
			{
				for (int y = 0; y < this.grid.GetLength(1); y++)
				{
					if (this.grid[x, y] == "2048")
					{
						win = 1;
						return;
					}
					else if (this.grid[x, y] == " ") {
						win = 0;
						return;
					}
				}
			}
		}
		//
	}
}

/* 

  ____   ___  _  _    ___  
 |___ \ / _ \| || |  ( _ ) 
   __) | | | | || |_ / _ \ 
  / __/| |_| |__   _| (_) |
 |_____|\___/   |_|  \___/ 
                           

*/