using System;
namespace Overloading
{
    public class overloadingExample
    {
        public int Add(int a)
        {
            return a + 3;
        }
       
        public int Add(int a, int b)
        {
            return a + b;
        }
       
        public static void Main()
        {
            overloadingExample obj = new overloadingExample();
            int a = 10, b = 2;
           
            Console.WriteLine("Addition of a and 3 is: {0}", obj.Add(a));
           
            Console.WriteLine("Addition of a and b is: {0}", obj.Add(a, b));
          
        }
    }
}
