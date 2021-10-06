using System;

namespace tocak
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, v, t, s, br, o;
            n = double.Parse(Console.ReadLine());
            v = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());

            s = v * t;
            n = n / 100;
            o = n * Math.PI;

            br = Math.Ceiling(s / o);

            Console.WriteLine(br);
        }
    }
}

