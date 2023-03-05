using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tool
    {
        public void goToolShop()
        {
            Things things = new Things();
            Scene scene = new Scene();
            things.Money();
            Console.WriteLine();
            scene.Say("1", "낚시대 구매하기(10000원)");
            scene.Say("2", "약 구매하기(5000원)");
            scene.Say("3", "상점 나가기");
            Console.Write("구매할 것 : ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    {
                        things.BuyTool();
                        break;
                    }
                case "2":
                    {
                        things.BuyMedicine();
                        break;
                    }
                case "3":
                    {
                        return;
                    }
            }
            ConsoleKeyInfo ss = Console.ReadKey(true);
            switch (ss.Key)
            {
                case ConsoleKey.Spacebar:
                    {
                        break;
                    }
            }
        }
    }
}
