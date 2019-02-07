using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Refelction
{
    class MainClass
    {

        static void Main()
        { 
            Type T = Type.GetType("Refelction.Student");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType+" "+method.Name);
            
            }

            PropertyInfo[] properties = T.GetProperties();
            
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType+" "+ property.Name);        
            }

            Console.WriteLine("\nConstructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.ReadKey();
        }
    }

   
    


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Student()
        {
            this.Id = -1;
            this.Name = string.Empty;
        
        }

        public void printId()
        {
            Console.WriteLine("ID = {0}", this.Id);

        }
        public void printName()
        {
            Console.WriteLine("Name={0}",this.Name);
        }

    }
}
