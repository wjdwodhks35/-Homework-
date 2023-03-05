using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weather
    {
        static string weather;
        #region 날씨 변환
        public int WeatherChange()
        {
            Random rand = new Random();
            int RandInt = rand.Next(1, 10);
            if(RandInt == 1)
            {
                weather = "나쁨";
                return 0;
            }
            else
            {
                weather = "좋음";
                return 1;
            }
        }
        #endregion
        #region 날씨 상태
        public void stateWeather()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t날씨 :");
            Console.ResetColor();
            if(weather == "좋음")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" {weather}");
                Console.ResetColor();
            }
            else if(weather == "나쁨")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($" {weather}");
                Console.ResetColor();
            }
            
            
        }
        #endregion
    }
}
