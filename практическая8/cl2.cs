using Newtonsoft.Json;

namespace практическая8
{
    internal class cl2
    {
        public int Str(int a, int z)
        {
            int p = 2;
            ConsoleKeyInfo k;
            int b = 3;
            int c = 1;
            while (c != 0)
            {
                k = Console.ReadKey();
                if (k.Key == ConsoleKey.DownArrow)
                {
                    b = p;
                    p++;
                }
                if (k.Key == ConsoleKey.UpArrow)
                {
                    b = p;
                    p--;
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    c = 0;
                }
                if (p == -1)
                {
                    p = 0;
                }
                if (p < a)
                {
                    p = a;
                    b = p + 1;
                }
                if (p > z)
                {
                    p = z;
                    b = p - 1;
                }
                Console.SetCursorPosition(0, p);
                Console.WriteLine("->");
                Console.SetCursorPosition(0, b);
                Console.WriteLine("  ");
            }
            return p;
        }
        public void Inf()
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("Проверьте вашу раскладку (должна быть русская). Игра начнётся через пару секунд.");
            Console.WriteLine("================================================================================");
            Thread.Sleep(5000);
            Console.Clear();
        }
        public void Crlz(List<cl3> pleer)
        {
            string desk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string putt = desk + "\\Резы.json";
            List<cl3> pler = pleer.OrderByDescending(x => x.atsec).ToList();
            var json = JsonConvert.SerializeObject(pler, Formatting.Indented);
            File.WriteAllText(putt, json);
        }
        public List<cl3> Dcrlz(int k)
        {
            string desk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string putt = desk + "\\Резы.json";
            if (!File.Exists(putt))
            {
                File.Create(putt).Close();
            }
            List<cl3> uch = new List<cl3>();
            string json = File.ReadAllText(putt);
            uch = JsonConvert.DeserializeObject < List <cl3 > > (json) ?? new List<cl3>();
            if ((k == 1) || (k == 2))
            {
                Console.WriteLine("Имя ======    В минуту ======    В секунду ======");
                int p = 2;
                if (k == 1)
                {
                    p = 2;
                }
                if (k == 2)
                {
                    p = 4;
                }
                foreach (var vrem in uch)
                {
                    Console.WriteLine(vrem.name);
                    Console.SetCursorPosition(14, p);
                    Console.WriteLine(vrem.atmin);
                    Console.SetCursorPosition(33, p);
                    Console.WriteLine(vrem.atsec);
                    p++;
                }
            }
            return uch;
        }
    }
}