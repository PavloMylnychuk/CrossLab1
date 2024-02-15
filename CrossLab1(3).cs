using System;

namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());

            string dayName = "";
            switch (n)
            {
                case 1: dayName = "понеділок"; break;
                case 2: dayName = "вівторок"; break;
                case 3: dayName = "середа"; break;
                case 4: dayName = "четвер"; break;
                case 5: dayName = "п’ятниця"; break;
                case 6: dayName = "субота"; break;
                case 7: dayName = "неділя"; break;
                default: dayName = "Помилка"; break;
            }

            Console.WriteLine(dayName);
        }
    }
}
