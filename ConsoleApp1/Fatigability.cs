using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fatigability
    {
        private static int nowFatigability = 0;
        private static int maxFatigability = 100;
        #region 피로도 소모/피로도 회복/피로도 초기화
        public void ConsumFatigability(int n)
		{
            nowFatigability += n;
        }
        public void HealingFatigability(int n)
		{
            nowFatigability -= n;
        }
        public void ResetFatigability(int n)
        {
            nowFatigability = n*10;
        }
        #endregion
        #region 피로도 상태
        public void StatusFatugability()
		{
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"현재 피로도 : {nowFatigability}");
            Console.WriteLine($"\t\t최대 피로도 : {maxFatigability}");
            Console.ResetColor();
		}
        #endregion
        #region 피로도 100이상일때 
        public int NotFishing()
        {
            ChangeDay changeDay = new ChangeDay();
            if (nowFatigability == 100)
            {
                return 0;
            }
            else if(nowFatigability > 100)
            {
                changeDay.NextDay();
                return 2;
            }
            else return 1;
        }
        #endregion
    }
}
