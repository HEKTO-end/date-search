using System;
using DataWsego;

namespace DataWsego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою дату рождения");
            Console.Write("год = ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("месяц = ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("день = ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" ваш знак задиака это - {Proverka.Zodiac_Sign(year,month,day)}");
            Console.WriteLine($" Вы родились в год - {Proverka.Chinese_Сalendar(year, month, day)}");
            Console.ReadKey();
        }

    }
}
