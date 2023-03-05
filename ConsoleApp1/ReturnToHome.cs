using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class ReturnToHome
	{
		#region 집으로 돌아오는 도중의 위험도 적기
		public void Risk()
		{
			Things things = new Things();
			Weather weather = new Weather();
			Random rand = new Random();

			if(weather.WeatherChange() == 0)
            {
				int n = rand.Next(1, 10);
				if(n==1)
                {
					Console.WriteLine("위험에 노출되어 모든 돈을 잃고 돌아갑니다.");
					things.LostMoney();
					ConsoleKeyInfo ss = Console.ReadKey(true);
				}
			}
		}
		#endregion
	}
}
