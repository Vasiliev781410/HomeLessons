﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp23
{
    class WorkWithUserData1
    {
        public delegate int Transformed(string str);
        static object locker = new object();
        public static void WorkWithUserDataMain()
        {
            lock (locker)
            {
                MainMenu();

                while (true)
                {
                    string str = Console.ReadLine();
                    Transformed tr = new Transformed(Parsing);
                    int result = tr.Invoke(str);
                    if (result == 0)
                    {
                        "Неправильный выбор меню: выбор меню лежит в дипозоне от 1 до 9".WriteExpr();
                    }
                    else
                    {
                        Console.Clear();
                        if (result < 7)
                        {
                            string name = null;
                            int day = 0;
                            bool stop = true;
                            "Введите название основного  средства".WriteExpr();
                            name = Console.ReadLine();

                            do
                            {
                                "Введите срок эксплуатации в количестве дней".WriteExpr();
                                string str1 = Console.ReadLine();
                                int res = tr.Invoke(str1);
                                if (res == 0)
                                {
                                    "Ошибка ввода: срок эксплутации может быть только целочисленным значением".WriteExpr();
                                }
                                else
                                {
                                    day = res;
                                    stop = false;
                                }
                            }
                            while (stop == true);

                            switch (result)
                            {
                                case 1:
                                    ClassLibrary1.Computers Asset1 = new ClassLibrary1.Computers();
                                    ClassLibrary1.Computers comp = Asset1.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(comp);
                                    break;
                                case 2:
                                    ClassLibrary1.MachineTools Asset2 = new ClassLibrary1.MachineTools();
                                    ClassLibrary1.MachineTools mash = Asset2.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(mash);
                                    break;
                                case 3:
                                    ClassLibrary1.Furnitures Asset3 = new ClassLibrary1.Furnitures();
                                    ClassLibrary1.Furnitures furn = Asset3.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(furn);
                                    break;
                                case 4:
                                    ClassLibrary1.Appliances Asset4 = new ClassLibrary1.Appliances();
                                    ClassLibrary1.Appliances appliance = Asset4.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(appliance);
                                    break;
                                case 5:
                                    ClassLibrary1.Autotrucks Asset5 = new ClassLibrary1.Autotrucks();
                                    ClassLibrary1.Autotrucks auto = Asset5.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(auto);
                                    break;
                                case 6:
                                    ClassLibrary1.Cars Asset6 = new ClassLibrary1.Cars();
                                    ClassLibrary1.Cars car = Asset6.NewAsset(name, day, ClassLibrary1.LogicOperation.CurrentDate);
                                    ClassLibrary1.LogicOperation.AddList(car);
                                    break;
                            }
                            "Данные по основнму средству записаны. Для продолжения нажмите Enter".WriteExpr();
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                        }
                        else if (result == 7)
                        {
                            Console.Clear();
                            ClassLibrary1.LogicOperation.CountWearout();
                            ClassLibrary1.LogicOperation.ListAssets();
                            "Для продолжения нажмите Enter".WriteExpr();
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                        }
                        else if (result == 8)
                        {
                            Console.Clear();
                            ClassLibrary1.LogicOperation.OrderAsset();
                            "Для продолжения нажмите Enter".WriteExpr();
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                        }
                    }
                }
            }
        }

        public static void MainMenu()
        {
            "Ввод основных средств по группам: ".WriteExpr();
            "  1 - компьютеры".WriteExpr();
            "  2 - станки".WriteExpr();
            "  3 - мебель".WriteExpr();
            "  4 - приборы".WriteExpr();
            "  5 - грузовики".WriteExpr();
            "  6 - легковые авто".WriteExpr();
            "Просмотр износа:".WriteExpr();
            "  7".WriteExpr();
            "Сформировать заказ на обновление фондов:".WriteExpr();
            "  8".WriteExpr();
         }

        public static int Parsing(string str)
        {
            int i = 0;
            bool rez = int.TryParse(str, out i);

            return i;
        }

    }
}

