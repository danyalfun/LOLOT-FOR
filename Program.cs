using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Task1()
        {
            int num;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
            }
        }
        static void Task2()
        {
            int num;
            Console.WriteLine("ENTER NUMBER");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i+=2)
            { 
                Console.Write(i);
            }

        }
        static void Task3()
        {
            int num;
            int factorial = 1;
            Console.WriteLine("ENTER NUMBER");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(num + "! = " + factorial);
        }
        static void Task4()
        {
            int days;
            int dayStaps;
            int stepsCount = 0;
            int OKSTEPSsteps = 0;
            Console.WriteLine("enter days");
            days = int.Parse(Console.ReadLine());
            for (int i = 1; i <= days; i++)
            { 
                Console.WriteLine("step per day" + i);
                dayStaps = int.Parse(Console.ReadLine());
                if (dayStaps >= 10000)
                { 
                    Console.WriteLine("YOU DO MORE 10000 STEPS THIS DAY CONGRADS");
                    OKSTEPSsteps = OKSTEPSsteps + 1;
                }
                stepsCount += dayStaps;
            }
            Console.WriteLine("sam steps =" + stepsCount);
            Console.WriteLine("YOU HAVE GOOD STEPS IN " + OKSTEPSsteps + " DAYS ");
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }
    }
}
