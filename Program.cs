using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkV
{
    internal class Program
    {

        public static int page = 0;
        public static void Entering(ConsoleKeyInfo key, int positon, int page)
        {
            SubItem forms = new SubItem();
            forms.items = new String[] { "Круг - 500", "Квадрат - 500", "Прямоугольник - 500", "Сердечко - 700" };
            forms.cost = new int[] { 500, 500, 500, 700 };
            SubItem sizes = new SubItem();
            sizes.items = new String[]
            {
                "Маленький (Диаметр - 16 см, 8 порций) - 1000", "Обычный (Диаметр - 18 см, 10 порций) - 1200",
                "Большой (Диаметр - 28 см, 24 порций) - 2000"
            };
            sizes.cost = new int[] { 1000, 1200, 2000 };
            SubItem taste = new SubItem();
            taste.items = new string[]
                { "Ванильный - 100", "Шоколадный - 100", "Кармаельный - 150", "Ягодный - 200", "Кокосовый - 250" };
            taste.cost = new int[] { 100, 100, 150, 200, 250 }; 
            SubItem amount = new SubItem();
            amount.items = new string[] { "1 корж - 200", "2 коржа - 400", "3 коржа - 600", "4 коржа - 800" };
            amount.cost = new int[] { 200, 400, 600, 800 };
            SubItem glaze = new SubItem();
            glaze.items = new string[] { "Шоколад - 100", "Крем - 100", "Бизе - 150", "Драже - 150", "Ягоды - 200" };
            glaze.cost = new int[] { 100, 100, 150, 150, 200 };
            SubItem decor = new SubItem();
            decor.items = new string[] { "Шоколадная - 150", "Ягодная - 150", "Кремовая - 150" };
            decor.cost = new int[] { 150, 150, 150 };
            if (page > 0)
            {
                for (; ;)
                {
                    Clear();
                    GreetingSub();
                    switch (positon)
                    {
                        case 3:
                            page = 2;
                            foreach (var item in forms.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }

                            //if (page == 2)
                            //{
                            //    key = Console.ReadKey(true);
                            //    if (key.Key == ConsoleKey.Enter)
                            //    {
                            //        switch (positon)
                            //        {
                            //            case 3:
                            //                Order.cost += forms.cost[0];
                            //                break;
                            //            case 4:
                            //                Order.cost += forms.cost[1];
                            //                break;
                            //            case 5:
                            //                Order.cost += forms.cost[2];
                            //                break;
                            //            case 6:
                            //                Order.cost += forms.cost[3];
                            //                break;
                            //        }
                            //    }
                            //}
                            break;
                        case 4:
                            page = 3;
                            foreach (var item in sizes.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }
                            break;
                        case 5:
                            page = 4;
                            foreach (var item in taste.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }
                            break;
                        case 6:
                            page = 5;
                            foreach (var item in amount.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }
                            break;
                        case 7:
                            page = 6;
                            foreach (var item in glaze.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }
                            break;
                        case 8:
                            page = 7;
                            foreach (var item in decor.items)
                            {
                                Console.Write("   ");
                                Console.WriteLine(item);
                            }
                            break;
                    }
                    key = Console.ReadKey(true);
                    Order.ChangePosition(key, page);
                }

            }

            if (page > 0 && page < 10)
            {
                for (;;)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (positon)
                        {
                            case 3:
                                Order.cost += forms.cost[0];
                                break;
                        }
                    }
                }
            }
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void GreetingSub()
        {
            Console.WriteLine(" Для выхода нажимте Escape" +
                              "\n Выберите пункт из меню:" +
                              "\n -----------------------");
        }

        public static void Greetings()
        {
            Clear();
            Console.WriteLine(" Заказ тортов в Пахомленд" +
                              "\n Выберите параметры торта" +
                              "\n -------------------------");
            List<string> points = new List<string>()
            {
                "1. Форма торта", "2. Размер торта", "3. Вкус коржей", "4. Количество коржей", "5. Глазурь", "6. Декор",
                "7. Конец заказа"
            };
            foreach (var item in points)
            {
                Console.Write("   ");
                Console.WriteLine(item);
            }

            Console.WriteLine($"Итоговая цена: {Order.cost}");
        }

        static void Main(string[] args)
        {
            Greetings();
            ConsoleKeyInfo key = Console.ReadKey(true);
            Order.ChangePosition(key, page);
        }
    }
}
