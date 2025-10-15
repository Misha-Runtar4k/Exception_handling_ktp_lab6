using System;

namespace Lab6_Ktp_Buts
{
    class Dogs
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Введіть число: ");
                string gav = Console.ReadLine();

                try
                {
                    double numberdouble = double.Parse(gav);
                    int numberint = (int)numberdouble;
                    Console.WriteLine($"Круто, ти ввів число: {numberint}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bсе фігня давай по новому;)  ");
                }
            }
        }
    }
}