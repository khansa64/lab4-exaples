using System;
namespace ValueTypeTest
{
    class DemoRefDataTypes
    {
        static void Main()
        {
        // declaring string
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
        }
    }
}
