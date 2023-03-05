using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
	class Game
	{
		Random rand = new Random();
		Chance chance = new Chance();
		Timer timer = new Timer();
		Things things = new Things();
        #region 낚시터1
        public void Game1()
		{
			int AppearChance = 0;
			bool isGameKeepPlay = true;
			while (isGameKeepPlay)
			{
				Console.Clear();
				chance.Probability();
				for (int i = 0; i < 3; i++)
				{
					Console.Write(".");
					Thread.Sleep(500);
					if(things.IdentifyedFishingtool() == 0)	AppearChance = rand.Next(1, 50);
					else if(things.IdentifyedFishingtool() == 1)	AppearChance = rand.Next(1, 40);
					if (AppearChance == 1)
					{
						Console.WriteLine("!!!");
						timer.LimitTimer();
						isGameKeepPlay = false;
						break;
					}
				}
			}
		}
        #endregion
        #region 낚시터2
        public void Game2()
		{
			int AppearChance =0;
			timer.LimitCounterinPlace();
			while (true)
			{
				Console.Clear();
				chance.Probability();
				for (int i = 0; i < 3; i++)
				{
					Console.Write(".");
					Thread.Sleep(500);
					if (things.IdentifyedFishingtool() == 0) AppearChance = rand.Next(1, 25);
					else if (things.IdentifyedFishingtool() == 1) AppearChance = rand.Next(1, 15);
					if (AppearChance == 1)
					{
						Console.WriteLine("!!!");
						Thread.Sleep(500);
						timer.LimitTimer();
					}
				}
			}
		}
        #endregion
    }
}
