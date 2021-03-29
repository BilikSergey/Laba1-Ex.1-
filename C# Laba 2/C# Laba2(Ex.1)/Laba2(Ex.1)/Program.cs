using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate double Decision(double number);
   class Program
    {

       private static double Sqrt(double number) { return Math.Sqrt(Math.Abs(number)); }

       private static double Myltiply(double number) { return Math.Pow(number, 3); }

       private static double Plus(double number) { return number + 3.5; }

        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послiдовно один за одним.\n" +
                "Поки вони матимуть вигляд 0 x чи 1 x чи 2 x\n" +
                "(тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа),\n" +
                "програма обчислюватиме одну з трьох функцiй\n " +
                "\t 0 -- sqrt(abs(x))\n" +
                "\t 1 -- x^3 (?накше кажучи, x*x*x)\n" +
                "\t 2 -- x + 3,5");
            Decision[] op = new Decision[]
            {Sqrt, Myltiply, Plus};

            bool start = true;

            while (start)
            {
                try
                {
                    string str = Console.ReadLine();
                    string[] s = str.Split(' ');
                    Console.WriteLine(op[int.Parse(s[0])](double.Parse(s[1])));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    start = false;
                }
            }
            Console.ReadKey();
        }
    }
}
