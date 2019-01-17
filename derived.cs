using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_1
{
    class Car
    {
        public  virtual  void   display()
        {
            Console.WriteLine("This is car class.");
        }
    }
    class Mahindra : Car
    {
        public  override void display()
        {
            Console.WriteLine("this is mahindra class");
        }
    }
    class Maruti : Car
    {
        public override void display()
        {
            Console.WriteLine("this is maruti class");
        }
    }
    class derived
    {
        public static void Main()
        {
            Maruti ma = new Maruti();
            Mahindra m = new Mahindra();
            ma.display();
            m.display();
            Console.ReadKey();
        }
    }

}
