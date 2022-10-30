namespace praktich_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Open();
        }
        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Выберите программу которую хотите запустить");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");
            Input(Console.ReadLine());
        }
        static void Input(string input)
        {
            Console.Clear();
            if (Convert.ToInt32(input) == 1)
            {
                Random rnd = new Random();
                int t = rnd.Next(0, 100);
                Console.WriteLine("ПК загадал число от 0 до 100. Угадайте это число!");
                int w;
                int prob = 0;
            start: Console.WriteLine("Введите это число: ");
                w = Int32.Parse(Console.ReadLine());
                if (w != t)
                {
                    if (w < t)
                    {
                        Console.WriteLine("Вы НЕ угадали. Введите число больше этого!");
                    }
                    else
                    {
                        Console.WriteLine("Вы НЕ угадали.Число должно быть меньше!");
                    }
                    Console.WriteLine("Побробуйте ёще раз"); prob++; goto start;
                }
                else
                {
                    Console.WriteLine("Вы угадали. Молодец! Поздравляю");
                    Console.WriteLine("Количество проб: " + prob);
                }
                Console.ReadKey();
            }
            else if (Convert.ToInt32(input) == 2)
            {
                var table = new int[10, 10];
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        table[i, j] = i * j;
                    }
                }
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        Console.Write("{0, 3}", table[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (Convert.ToInt32(input) == 3)
            {
                Console.WriteLine($"Добро пожаловать в - Вывод делителей числа");
                string strA, resul;
                Int32 intA;
            start: Console.WriteLine("Введите число: ");
                strA = Console.ReadLine();
                intA = Convert.ToInt32(strA);
                resul = "";

                for (int i = 1; i <= intA; i++)
                {
                    if (intA % i == 0)
                    { resul += i + " "; }
                }

                Console.WriteLine("Все целые числа, на которое заданное число делиться без остатка: ");
                Console.Write(resul); goto start;
            }
            else if (Convert.ToInt32(input) == 4) Environment.Exit(0);
        }
    }
}