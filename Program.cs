using System;

namespace OverloadMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToString.Get(true));
            Console.WriteLine(ConvertToString.Get(123));
            Console.WriteLine(ConvertToString.Get(new DateTime(2012, 05, 14)));

            Console.WriteLine(Address.Format("Joao Nogueira"));
            Console.WriteLine(Address.Format("Joao Nogueira", "1207"));
            Console.WriteLine(Address.Format("Joao Nogueira", "1207", "04521000"));
            Console.WriteLine(Address.Format("Joao Nogueira", "1207", "04521000", "Brasil"));
        }
    }
}