using System;

namespace _2console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1");
                Console.Write("x=");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y=");
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine("Вывод: " + CheckCoordinates(x, y));

                Console.WriteLine("Задание 2");
                Console.WriteLine("Введите признак транспортного средства: " +
                    "a – автомобиль, " +
                    "в – велосипед, " +
                    "м - мотоцикл, " +
                    "с – самолет, " +
                    "п – поезд.");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Максимальная скорость: " + GetMaxSpeed(ch));

                Console.WriteLine("Задание 3");
                GetNumbers();

                Console.WriteLine("Задание 4");
                ShowNumbers();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ShowNumbers()
        {
            int first = 9;
            int second = 4;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(first + " ");
                }
                first--;
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Console.Write(second + " ");
                }
                second--;
                Console.WriteLine();
            }

        }

        private static void GetNumbers()
        {
          
            for (int i = 10; i < 100; i++)
            {
                if (Math.Abs(i % 10 - (i - i % 10) / 10) <= 1)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            

            int j = 9;
            while (j < 100)
            {
                j++;
                if (Math.Abs(j % 10 - (j - j % 10) / 10) <= 1)
                    Console.Write(j + " ");
            }
            Console.WriteLine();
            

            int k = 10;
            do
            {
                if (Math.Abs(k % 10 - (k - k % 10) / 10) <= 1)
                    Console.Write(k + " ");
                k++;
            }
            while (k < 100);
            Console.WriteLine();
        }

        private static int GetMaxSpeed(char ch)
        {
            switch (ch)
            {
                case 'a': return 300;
                case 'в': return 45;
                case 'м': return 245;
                case 'с': return 1200;
                case 'п': return 450;
                default: return 0; 
            }
        }

        private static String CheckCoordinates(float x, float y)
        {
            if (x > 0 && x < 10 && y > 0 && y < 5) return "Да";
            else if (x < 0 || x > 10 || y < 0 || y > 5) return "Нет";
            else return "На границе";
        }
    }
}
