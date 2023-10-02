using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Найти делители числа");
            Console.WriteLine("4. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    FindDivisors();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Значение отсутствует.");
                    break;
            }
        }
    }

    static void PlayGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int userNumber;

        Console.WriteLine("Игра 'Угадай число'!");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать!");

        do
        {
            Console.Write("Введите ваше число: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (userNumber > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        } while (userNumber != randomNumber);

        Console.WriteLine("Поздравляю! Вы угадали число {0}!", randomNumber);
        Console.WriteLine("Возвращаем вас в меню выбора программы.");
    }

    static void PrintMultiplicationTable()
    {
        int[,] multiplicationTable = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0}\t", multiplicationTable[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine("Возвращаем вас в меню выбора программы.");
    }

    static void FindDivisors()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Делители числа {0}:", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Возвращаем вас в меню выбора программы.");
    }
}
