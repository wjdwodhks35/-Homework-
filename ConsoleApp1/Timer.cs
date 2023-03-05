using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Timer
    {
        //타이머 쓰기 위한 변수들
        //==============================
        static IntPtr ConsoleWindowHnd = GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("User32.Dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        const int VK_RETURN = 0x0D;
        const int WM_KEYDOWN = 0x100;
        //==============================

        CancellationTokenSource cancelToken;

        public void LimitTimer()
        {
            Chance chance = new Chance();
            Things things = new Things();
            Fatigability fatigability = new Fatigability();
            cancelToken = new CancellationTokenSource();

            if (fatigability.NotFishing() == 0)
            {
                Console.WriteLine("더이상 낚시할 수 없습니다.");
                ConsoleKeyInfo ss = Console.ReadKey(true);
                switch (ss.Key)
                {
                    case ConsoleKey.Spacebar:
                        {
                            break;
                        }
                }
            }

            //타이머 시작
            theThreadTimer(cancelToken);

            // (진행 하게 될 게임 내용)
            //==============================
            ConsoleKeyInfo tt = Console.ReadKey(true);
            switch (tt.Key)
            {
                case ConsoleKey.Spacebar:
                    {
                        cancelToken.Cancel();
                        chance.SuccessOfThing();
                        things.Fish();
                        Thread.Sleep(750);
                        break;//낚았을때 나올말
                    }

                //==============================
                default:
                    {
                        cancelToken.Cancel();
                        chance.FailOfThing();
                        Thread.Sleep(750); //낚지 못했을때 나올 말
                        break;
                    }
            }
        }

        async Task theThreadTimer(CancellationTokenSource cancelToken)
        {
            int timeLimit = 3;          // 타이머 종료 시간(해당 시간이 되면 꺼짐. 3 -> 3초)
            while (0 < timeLimit)
            {

                if (cancelToken.IsCancellationRequested == true)
                {
                    break;
                }

                await Task.Delay(1000); //1초의 딜레이 (1초가 지났다는 뜻)

                if (cancelToken.IsCancellationRequested == true)
                {
                    break;
                }
                timeLimit--;
            }

            //해당 메세지를 보내면 ReadLine 강제 종료
            //===================================================


            PostMessage(ConsoleWindowHnd, WM_KEYDOWN, VK_RETURN, 0);


            //===================================================
        }
        #region 타이머
        public async Task LimitCounterinPlace()
        {
            int timeLimit = 100;         //타이머 시간
            while (0 < timeLimit)
            {
                await Task.Delay(1000); //1초의 딜레이 (1초가 지났다는 뜻)
                timeLimit--;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("<이용 시간이 끝났습니다.>");
            Console.ResetColor();
            //해당 메세지를 보내면 ReadLine 강제 종료
            //===================================================
            PostMessage(ConsoleWindowHnd, WM_KEYDOWN, VK_RETURN, 0);
            //===================================================
        }
        #endregion
    }
}