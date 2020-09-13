using System;

namespace MasteringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);
            Console.WriteLine(@"\\");

            Enums enums = new Enums();
            enums.Main();
        }
    }
}
