using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай-ка\".");
            Console.WriteLine("Необходимо угадать число, которое загадал компьютер. Но для начала...\n");
            Console.Write("Введите максимальное целое число диапазона: ");
            int RangeNumber = int.Parse(Console.ReadLine());

            if (RangeNumber <= 0)
            {
                Console.WriteLine("\nУпс.. Кажется вы ввели неправильное значение.");
                Console.WriteLine("Необходимо ввести положительное целое число и больше 0.");
                Console.WriteLine("Попробуйте еще раз :)");
            }

            if (RangeNumber > 0)
            {
                Random rnd = new Random();
                int RandomNumberForGame = rnd.Next(0, RangeNumber);
                int count = 0;

                while (true)
                {
                    count++;

                    Console.Write("\nВведите загаданное число: ");
                    string UserString = Console.ReadLine();
                    if (UserString == "")
                    {
                        Console.WriteLine("\nОчень жаль, что вы уходите.");
                        Console.WriteLine($"Загаданное число: {RandomNumberForGame}");
                        break;
                    }

                    int UserNumber = int.Parse(UserString);

                    if (UserNumber < RandomNumberForGame)
                    {
                        Console.WriteLine($"Число {UserNumber} меньше загаданного\n");
                    }

                    else if (UserNumber > RandomNumberForGame)
                    {
                        Console.WriteLine($"Число {UserNumber} больше загаданного\n");
                    }

                    else if (UserNumber == RandomNumberForGame)
                    {
                        Console.WriteLine($"\nПоздравляю! Вы угадали число. Количество попыток: {count}");
                        break;
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
