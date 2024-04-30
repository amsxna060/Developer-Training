using System;
using System.Globalization;

namespace programss
{
class Programs
{
    // #Average of 4 Numbers;
    public static void Average()
    {
        int a,b,c,d;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        int sum = a+b+c+d;
        float avg = (float)sum/4;
        Console.WriteLine($"avg is {avg}");
    }
}
}