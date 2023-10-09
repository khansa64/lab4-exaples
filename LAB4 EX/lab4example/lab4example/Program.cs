using System;

namespace lab4example
{
    class Program
    {
        static void Main(string[] agrs)
        {
            //CastInAndDoubles();
            //ConvertToString();
            ParseToNumberAndDates();
        }
         private static void ParseToNumberAndDates()
        {
            /*  //cast an int variable into  a double variable 
              int a = 10;
              double b = a;//an int can be stored in a double 
              Console.WriteLine(b);
              double c = 9.8;
              //cast  adouble variable into an int variable 
              int d = (int)c;

              long e = 10;
              int f = (int)e;
              Console.WriteLine($"e is {e} and f is {f}");

              e = long.MaxValue;
              f = (int)e;
              Console.WriteLine($"e is {e} and f is {f}");*/
            /* int number = 12;
             Console.WriteLine(number.ToString());

             bool boolean = true;
             Console.WriteLine(boolean.ToString());

             DateTime now = DateTime.Now;
             Console.WriteLine(now.ToString());

             object me = new object();
             Console.WriteLine(me.ToString());
            */

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4july 1980");
            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"my birthday is {birthday} .");
            Console.WriteLine($"my birthday is {birthday : D} .");
        }

    }
}
