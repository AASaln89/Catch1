using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO, USER");
            Console.WriteLine("PLEASE, INSERT INT FIRST NUMBER");
            int a = 0;
            int b = 0;
            int M = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("PLEASE, INSERT INT SECOND NUMBER");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("CHOISE MATH METHOD");
            M = Convert.ToInt32(Console.ReadLine());
            if (M == 1)
            {
                Console.WriteLine(a + b);
            }
            if (M == 2)
            {
                Console.WriteLine(a - b);
            }
            if (M == 3)
            {
                Console.WriteLine(a * b);
            }
            if (M == 4)
            {
                try
                {
                    Console.WriteLine(a / b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }

    }
}