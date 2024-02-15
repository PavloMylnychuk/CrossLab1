using System;

namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("x=");
            if (float.TryParse(Console.ReadLine(), out float x))
            {
                Console.Write("y=");
                if (float.TryParse(Console.ReadLine(), out float y))
                {
                    if (x * x + y * y < 9 && y > 0)
                    {
                        Console.WriteLine("Так, точка лежить всередині");
                    }
                    else if (x * x + y * y > 9 || y < 0)
                    {
                        Console.WriteLine("Ні, точка лежить поза заштрихованою областю");
                    }
                    else
                    {
                        Console.WriteLine("На межі заштрихованої області");
                    }
                }
                else
                {
                    Console.WriteLine("Невірний формат введення y");
                }
            }
            else
            {
                Console.WriteLine("Невірний формат введення x");
            }
        }
    }
}
