using System;

namespace Dumpolayze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input filepath:");
            var dumppath = Console.ReadLine();
            Reader.Convert(dumppath);
            //Reader.Convert(args[0]);
        }
    }


}
