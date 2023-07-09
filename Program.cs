using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (input.Length >= 3)
        {
            int number = int.Parse(input);
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }
}