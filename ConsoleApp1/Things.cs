using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Things
    {
        static int myMoney = 0;
        static int[] fish = new int[5] { 0, 0, 0, 0, 0 };
        static int[] trash = new int[2] { 0, 0 };
        static int medicine = 0;
        static string tool = "기본";
        static int countMedicine = 0;
        public int ptcountMedicine = countMedicine;
        #region 물고기 낚았을때 나올 메시지
        public void Fish()
        {
            Console.WriteLine();
            Console.Write("낚은 것 : ");
            InfoOfCatchedfish();
        }
        #endregion
        #region 메시지의 내용
        private void InfoOfCatchedfish()
        {
            Fatigability fatigability = new Fatigability();
            Random rand = new Random();
            Scene scene = new Scene();
            int i = rand.Next(1, 6);
            switch (i)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("물고기1");
                        Console.ResetColor();
                        InfoOfFish(1);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("피로도 5 소모");
                        Console.ResetColor();
                        fish[0]++;
                        fatigability.ConsumFatigability(5);
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("물고기2");
                        Console.ResetColor();
                        InfoOfFish(2);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("피로도 10 소모");
                        Console.ResetColor();
                        fish[1]++;
                        fatigability.ConsumFatigability(10);
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("물고기3");
                        Console.ResetColor();
                        InfoOfFish(3);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("피로도 15 소모");
                        Console.ResetColor();
                        fish[2]++;
                        fatigability.ConsumFatigability(15);
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("물고기4");
                        Console.ResetColor();
                        InfoOfFish(4);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("피로도 20 소모");
                        Console.ResetColor();
                        fish[3]++;
                        fatigability.ConsumFatigability(20);
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("물고기5");
                        InfoOfFish(5);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("피로도 25 소모");
                        Console.ResetColor();
                        fish[4]++;
                        fatigability.ConsumFatigability(25);
                       
                        break;
                        
                    }
                case 6:
                    {
                        int t = rand.Next(1, 100);
                        if (t == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("쓰레기");
                            Console.ResetColor();
                            InfoOfFish(6);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("피로도 5 소모");
                            Console.ResetColor();
                            trash[0]++;
                            fatigability.ConsumFatigability(5);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("비싼 쓰레기");
                            Console.ResetColor();
                            InfoOfFish(6);
                            trash[1]++;
                        }
                        break;
                    }
            }
        }
        #endregion
        #region 물고기의 정보
        private void InfoOfFish(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine(@"물고기1의 가격 : 3000원
물고기1의 정보 : 심심해서 만든 물고기1 이다.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(@"물고기2의 가격 : 4500원
물고기2의 정보 : 심심해서 만든 물고기2 이다.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(@"물고기3의 가격 : 6000원
물고기3의 정보 : 심심해서 만든 물고기3 이다.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(@"물고기4의 가격 : 7500원
물고기4의 정보 : 심심해서 만든 물고기4 이다.");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(@"물고기5의 가격 : 10000원
물고기5의 정보 : 심심해서 만든 물고기5 이다.");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(@"쓰레기이다.");
                        break;
                    }
            }
        }
        #endregion
        #region 가방
        public void Bag()
        {
            Console.Clear();
            Console.WriteLine(" ------------가방--------------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"물고기1    : {fish[0]}개(1500)");
            Console.ResetColor();
            Console.WriteLine("        |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"물고기2    : {fish[1]}개(3000)");
            Console.ResetColor();
            Console.WriteLine("        |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"물고기3    : {fish[2]}개(4500)");
            Console.ResetColor();
            Console.WriteLine("        |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"물고기4    : {fish[3]}개(6000)");
            Console.ResetColor();
            Console.WriteLine("        |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"물고기5    : {fish[4]}개(7500)");
            Console.ResetColor();
            Console.WriteLine("        |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"쓰레기	    : {trash[0]}개(-1000)");
            Console.ResetColor();
            Console.WriteLine("       |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"비싼쓰레기 : {trash[1]}개(100000)");
            Console.ResetColor();
            Console.WriteLine("      |");
            Console.Write("|");
            Console.WriteLine("                              |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"남은 약    : {medicine}개");
            Console.ResetColor();
            Console.WriteLine("              |");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"현재 장비  : {tool}");
            Console.ResetColor();
            Console.WriteLine("             |");
            Console.WriteLine(" ------------------------------");
        }
        #endregion
        #region 구매 상점
        public void BuyTool()
        {
            if (myMoney >= 10000)
            {
                tool = "견고한 낚시대";
                myMoney -= 10000;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("성공적으로 구매하셨습니다.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("돈이 부족합니다.");
                Console.ResetColor();
            } 
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        public void BuyMedicine()
        {
            if (myMoney >= 5000)
            {
                medicine++;
                myMoney -= 5000;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("성공적으로 구매하였습니다.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("돈이 부족합니다.");
                Console.ResetColor();
            }
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        #endregion
        #region 판매 상점

        public void EverySell()
        {
            Scene Money = new Scene();
            int[] n = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            for (; fish[0] > 0; fish[0]--)
            {
                n[0]++;
                myMoney += 1500;
            }
            for (; fish[1] > 0; fish[1]--)
            {
                n[1]++;
                myMoney += 3000;
            }
            for (; fish[2] > 0; fish[2]--)
            {
                n[2]++;
                myMoney += 45000;
            }
            for (; fish[3] > 0; fish[3]--)
            {
                n[3]++;
                myMoney += 6000;
            }
            for (; fish[4] > 0; fish[4]--)
            {
                n[4]++;
                myMoney += 7500;
            }
            for (; trash[0] > 0; trash[0]--)
            {
                n[5]++;
                myMoney -= 1000;
            }
            for (; trash[1] > 0; trash[1]--)
            {
                n[6]++;
                myMoney += 100000;
            }
            Console.WriteLine($"총 {n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] }개 판매 완료");
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        public void SeparatelySell()
        {
            Scene Money = new Scene();
            while (true)
            {
                Bag();
                Console.WriteLine("어떤 것을 파시겠습니까?");
                Console.Write("팔 것 : ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (fish[n - 1] > 0)
                {
                    for (; fish[n] > 0; fish[n]--)
                    {
                        switch (n)
                        {
                            case 1:
                                {
                                    myMoney += 1500 * fish[0];
                                    break;
                                }
                            case 2:
                                {
                                    myMoney += 3000 * fish[1];
                                    break;
                                }
                            case 3:
                                {
                                    myMoney += 4500 * fish[2];
                                    break;
                                }
                            case 4:
                                {
                                    myMoney += 6000 * fish[3];
                                    break;
                                }
                            case 5:
                                {
                                    {
                                        myMoney += 7500 * fish[4];
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                    Console.WriteLine("판매가 완료되었습니다.");
                    ConsoleKeyInfo ss = Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine($"판매할수 있는 물고기{n}이 없습니다.");
                    ConsoleKeyInfo ss = Console.ReadKey(true);
                }
                if (trash[n - 5] > 0)
                {
                    switch (n)
                    {
                        case 5:
                            {
                                myMoney -= 1000 * trash[0];
                                break;
                            }
                        case 6:
                            {
                                myMoney += 100000 * trash[1];
                                break;
                            }
                    }
                    break;
                }
                break;
            }
        }
        #endregion
        #region 돈
        public void Money()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"남은 돈 : {myMoney}원");
            Console.ResetColor();
        }
        #endregion
        #region 입장료
        public void Admission(int n)
        {
            Scene scene = new Scene();
            if (myMoney >= n) scene.SceneN2();
            else Console.WriteLine("돈이 부족합니다.");
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        #endregion
        #region 낚시대 확인
        public int IdentifyedFishingtool()
        {
            if(tool == "기본")
            {
                return 0;
            }
            else if(tool == "견고한 낚시대")
            {
                return 1;
            }
            return 2;
        }
        #endregion
        #region 위험떴을때 돈 날림
        public void LostMoney()
        {
            myMoney = 0;
        }
        #endregion
        #region 돈 확인
        public void IdentifyedMoney()
        {
            if (myMoney == 100000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("목표치 달성!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"남은 목표치까지 남은 돈 : {100000 - myMoney} 원");
                Console.ResetColor();
            }
            ConsoleKeyInfo tt = Console.ReadKey(true);
        }
        #endregion
        #region 약 사용하기
        public void takeMedicine()
        {
            if (medicine > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("약을 사용하였습니다.");
                Console.ResetColor();
                ConsoleKeyInfo tt = Console.ReadKey(true);
                countMedicine++;
            }
            else if (medicine == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("사용할 약이 없습니다.");
                Console.ResetColor();
                ConsoleKeyInfo tt = Console.ReadKey(true);
            }
        }
        #endregion
    }
}