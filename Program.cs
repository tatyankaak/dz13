using System;

class Program
{
    static void Main()
    {
        int number = Input("Введите число: ");
        number = Math.Ads(number);
        if (number > 99)
        {
            while(number > 999)
            {
                number /= 10;
            } 
            Console.WriteLine($"Третья цифра числа: {number % 10}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }
}
