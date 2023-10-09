using System;
namespace Pointerprogram
{
    class DemoRefDataTypes
    {
        static void Main()
        {
            /*// declaring string
            string a = "Salam";
            //append in a
            a += "for";
            a = a + "All";
            Console.WriteLine(a);
            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);
            // to show type of object using GetType()
            Console.WriteLine(obj.GetType());
            */
            unsafe
            {
                // declare variable

                int n = 10;
                // store variable n address location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }
}
