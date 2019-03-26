using System;
using System.IO;
class MyClass
{
    public static void Main()
    {
        string[] Directories = Directory.GetDirectories(@"C:\Users\AnjaliBalchadani\File");
        foreach (string dir in Directories)
            Console.WriteLine(dir);
        string[] files = Directory.GetFiles(@"C:\Users\AnjaliBalchandani\File");
        foreach (string file in files)
            Console.WriteLine(file);

    }
}
