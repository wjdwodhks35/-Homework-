using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Chance
    {
        static float EveryCount = 0.0f;
        static float SuccessOfFishing = 0.0f;
        static float FailOfFishing = 0.0f;
        #region 성공/실패
        public void SuccessOfThing()
        {
            EveryCount++;
            SuccessOfFishing++;
            Console.Write("성공하셨습니다");
            for (int k = 0; k < 3; k++)
            {
                Console.Write(".");
                Thread.Sleep(750);
            }
        }
        public void FailOfThing()
        {
            EveryCount++;
            FailOfFishing++;
            Console.Write("실패하셨습니다");
            for (int k = 0; k < 3; k++)
            {
                Console.Write(".");
                Thread.Sleep(750);
            }
        }
        #endregion
        #region 확률
        public void Probability()
        {
            if(EveryCount == 0)
			{
                Console.WriteLine($"낚은 횟수 : {(int)SuccessOfFishing}\t\t성공 확률: 0%\t실패 확률: 0% ");
			}
            else
            {
                Console.WriteLine($"낚은 횟수 : {(int)SuccessOfFishing}\t\t성공 확률 : {(int)((SuccessOfFishing / EveryCount) * 100)}\t% 실패 확률 : {(int)(100 - ((SuccessOfFishing / EveryCount) * 100))}% ");
            } 
        }
        #endregion
    }
}
