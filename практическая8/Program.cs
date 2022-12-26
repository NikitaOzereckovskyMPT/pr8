using System;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;

namespace практическая8
{
    internal class Program
    {
        public static int t = 0;
        public static int sec = 60;

        static void Main(string[] args)
        {
            while (true)
            {
                Thread timer = new Thread(() =>
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Thread.Sleep(60000);
                    stopWatch.Stop();
                    Console.Clear();

                    t++;
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("Конец игры! Для того, чтобы увидеть результаты, нажмите Enter.");
                    Console.WriteLine("==============================================================");
                });
                Thread tim = new Thread(() =>
                {
                    sec = 60;
                    while (sec != 0)
                    {
                        Thread.Sleep(1000);
                        sec = sec - 1;

                    }
                });
                cl2 dp = new cl2();
                Console.WriteLine("Тест на скоропечатание слов");
                Console.WriteLine("=====================================================");
                Console.WriteLine("  Начать тест на скоропечатание слов");
                Console.WriteLine("  Посмотреть таблицу рекордов по скоропечатанию слов");
                int v = dp.Str(2, 3);
                cl3 vrem = new cl3();
                vrem.name = "";
                vrem.atmin = 0;
                vrem.atsec = 0;
                if (v == 2)
                {
                    Console.Clear();
                    vrem.name = Iformation();
                    dp.Inf();
                    tim.Start();
                    timer.Start();
                    cl1 sl = new cl1();
                    int[] a = new int[2];
                    int d = 0;
                    int h = 0;
                    while (t == 0)
                    {
                        a = sl.lg(d, h);
                        d = a[0];
                        h = a[1];
                        if (t == 1)
                        {
                            Console.Clear();
                            break;
                        }
                        Console.SetCursorPosition(55, 6);
                        Console.Write("Осталось " + sec + " секунд");
                    }

                    Console.WriteLine("Результат:");
                    Console.WriteLine("За 10 секунд: " + Math.Round((d / 6.00), 2) + ". В секунду: " + Math.Round((d / 60.00), 2) + ". В минуту: " + d + ". Количество ошибок: " + h);
                    Console.WriteLine("Нажмите ESC или любую другую кнопку чтобы вернуться на начальное меню.");
                    vrem.atmin = d;
                    vrem.atsec = Math.Round((d / 60.00), 2);
                    List<cl3> uch = dp.Dcrlz(0);
                    uch.Add(vrem);
                    dp.Crlz(uch);
                    dp.Dcrlz(2);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (v == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Нажмите ESC что бы вернуться.");
                    dp.Dcrlz(1);
                    int s = 0;
                    while (s == 0)
                    {
                        ConsoleKeyInfo k = Console.ReadKey(true);
                        if (k.Key == ConsoleKey.Escape)
                        {
                            s++;
                        }
                    }
                    Console.Clear();
                }
            }

        }
        static string Iformation()
        {
            Console.WriteLine("Как вас зовут?");
            string n = Console.ReadLine();
            return n;
        }

    }
}