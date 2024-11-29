using System;

namespace integer3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Byt = int.Parse(Console.ReadLine());
            var result = Byt / 1024;
            Console.WriteLine(result+" ");
        }
    }
}