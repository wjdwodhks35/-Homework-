using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Scene
    {
        private static int theDay = 0;
        #region 메인 화면
        public void MainScene()
        {
            while (true)
            {
                Console.Clear();
                Say("1", "시작");
                Say("2", "설명");
                Say("3", "종료");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("[메뉴를 입력하세요] : ");
                Console.ResetColor();
                string str = Console.ReadLine();
                if (str == "1")
                {
                    PlaySelectScene();
                }
                else if (str == "2")
                {
                    GameRule();
                }
                else if (str == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("잘못된 번호를 입력하셨습니다.");
                    Thread.Sleep(1500);
                    continue;
                }
            }
        }
        #endregion
        #region 플레이 선택 화면
        public void PlaySelectScene()
        {
            ChangeDay changeDay = new ChangeDay();
            Things things = new Things();
            Weather weather = new Weather();
            theDay++;
            weather.WeatherChange();
            while (true)
            {
                Console.Clear();
                Console.Write($"{ theDay} 일\t");
                things.Money();
                weather.stateWeather();
                Console.WriteLine();
                Say("1", "연습 낚시터	                        입장료 : 무료");
                Say("2", "일반 낚시터(100초 동안 있을수 있음)	입장료 : 5000 원");
                Say("3", "상점");
                Say("4", "목표치 확인");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("[선택] : ");
                Console.ResetColor();
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            SceneN1();
                            break;
                        }
                    case "2":
                        {
                            things.Admission(5000);
                            break;
                        }
                    case "3":
                        {
                            BuyStore();
                            continue;
                        }
                    case "4":
                        {
                            things.IdentifyedMoney();
                            continue;
                        }
                }
                SellStore();
                break;
            }
        }
        #endregion
        #region 낚시터 1
        public void SceneN1()
        {
            Game game = new Game();
            Things things = new Things();
            Fatigability fatigability = new Fatigability();
            Timer timer = new Timer();


            while (true)
            {
                string str = Behavior();
                if (str == "1")
                {
                    if (fatigability.NotFishing() == 1)
                    {
                        game.Game1();
                    }
                }
                else if (str == "2")
                {
                    things.Bag();
                    Console.WriteLine("								ESC:나가기");
                    ConsoleKeyInfo tt = Console.ReadKey(true);
                    switch (tt.Key)
                    {
                        case ConsoleKey.Escape:
                            {
                                break;
                            }
                        default:
                            {
                                continue;
                            }
                    }
                }         //가방보기
                else if (str == "3")
                {
                    things.takeMedicine();
                    continue;
                }
                else if (str == "4") return;            //돌아가기
            }
        }
        #endregion
        #region 낚시터 2
        public void SceneN2()
        {
            Game game = new Game();
            Things things = new Things();
            Fatigability fatigability = new Fatigability();


            while (true)
            {
                Console.WriteLine();
                string str = Behavior();
                if (str == "1")
                {
                    if (fatigability.NotFishing() == 1)
                    {
                        game.Game2();
                    }
                }
                else if (str == "2")
                {
                    things.Bag();
                    Console.WriteLine("								ESC:나가기");
                    ConsoleKeyInfo tt = Console.ReadKey(true);
                    switch (tt.Key)
                    {
                        case ConsoleKey.Escape:
                            {
                                break;
                            }
                        default:
                            {
                                continue;
                            }
                    }
                }         //가방보기
                else if (str == "3")
                {
                    things.takeMedicine();
                    continue;
                }
                else if (str == "4")  return;            //돌아가기
                return;
            }
        }
        #endregion
        #region 하루의 시작할 때 상점
        public void BuyStore()
        {
            Tool tool = new Tool();
            Console.Clear();
            tool.goToolShop();
        }
        #endregion
        #region 하루의 끝 상점
        public void SellStore()
        {
            Things store = new Things();
            ChangeDay changeDay = new ChangeDay();
            while (true)
            {
                Console.Clear();
                Say("1", "모두 판매");
                Say("2", "따로 판매");
                Say("3", "다음날로 넘어가기");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("할 일 : ");
                Console.ResetColor();
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            store.EverySell();
                            break;
                        }
                    case "2":
                        {
                            store.SeparatelySell();
                            break;
                        }
                    case "3":
                        {
                            changeDay.NextDay();
                            break;
                        }
                }
            }
        }
        #endregion
        #region 화면 번호
        public void Say(string prefix, string message)
        {

            Console.Write($"[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{prefix}");
            Console.ResetColor();
            Console.Write($"]");
            Console.WriteLine($" {message}");
        }
        #endregion
        #region 할 행동
        public string Behavior()
        {
            Chance chance = new Chance();
            Fatigability myFatigability = new Fatigability();
            Timer timer = new Timer();
            Console.Clear();
            chance.Probability();
            Console.WriteLine();
            myFatigability.StatusFatugability();
            Console.WriteLine();
            Say("1", "낚시 하기");
            Say("2", "가방 보기");
            Say("3", "약 사용하기");
            Say("4", "돌아가기");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[할 일] : ");
            Console.ResetColor();
            string str = Console.ReadLine();
            return str;
        }
        #endregion
        #region 게임 룰
        private void GameRule()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
               게임 룰 : 게임 방식은 낚시를 해서 돈을 벌면 되는 아주 간단한 게임입니다.
                  그리고 낚시터와 낚시대에 따라 물고기가 낚이는 확률이 달라집니다.
                날씨에 따라 위험도가 달라지며, 위험에 노출된다면 돈을 모두 잃습니다.
             무언가를 낚으면 3초안에 스페이스 바를 눌러 낚아야하며 3초가 지나면 실패하며,
                        쓰레기들중에서 아무 가끔씩 비싼 쓰레기가 뜹니다.
                           최종목표는 돈을 10만원까지 버는 것입니다.");
            Console.ResetColor();
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        #endregion
    }
    
}
