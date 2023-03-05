using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class ChangeDay
    {
        #region 다음날로 넘어감
        public void NextDay()
        {
            Scene scene = new Scene();
            ReturnToHome returnToHome = new ReturnToHome();
            Things things = new Things();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("다음날로 넘어갑니다");
            for (int n = 0; n < 3; n++) 
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.ResetColor();
            returnToHome.Risk();
            count(things.ptcountMedicine);
            scene.PlaySelectScene();
        }
        #endregion
        #region 약 사용횟수에 따른 부작용 중간 과정
        public void count(int n)
        {
            Fatigability fatigability = new Fatigability();
            fatigability.ResetFatigability(n);
        }
        #endregion
    }
}
