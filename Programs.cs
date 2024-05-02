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
    public static string AverageByArray(int n)
    {
        int[] nums = new int[n];
        int sum=0;
        for(int i = 0;i<n;i++)
        {
            nums[i]=int.Parse(Console.ReadLine());
            sum+=nums[i];
        }
        return $"Average of {n} numbers is {(float)sum/n}.";
        
    }

    // # reverse a string in C# 
    public static void ReverseString(string str)
    {
        string ans;
        char[] charray = new char[str.Length];
        
        for(int i=0;i<str.Length;i++){
            charray[i] = str[i];
        }
        foreach(char ch in charray){
            // Console.WriteLine(ch);
            // Console.Write(ch+" ");
            Console.Write(ch);
        }
        Console.WriteLine();
        
        // Array.Reverse(charray);
        // Array.ForEach(charray, ch => Console.Write(ch));
        
        int k = 0,j=str.Length-1; // What is ErrorCS0136
        while(k<=j){
            char temp = charray[k];
            charray[k] = charray[j];
            charray[j] = temp;
            // k++;
            // j--;
            ++k;
            --j;
        }
        ans = new String(charray);
        Console.WriteLine(ans);
    }

    public static void incrementDecrement()
    {
        // # use of pre & post increment
        int i = 0;
        int j = 0;
        // Console.WriteLine("{}",i++);
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        Console.Write($"{i++} ");
        
        Console.WriteLine();
        
        Console.Write($"{++j} ");
        Console.Write($"{++j} ");
        Console.Write($"{++j} ");
        Console.Write($"{--j} ");
        Console.Write($"{j--} "); // It will print 2 but decrement happen to 1 after printing two.
        Console.Write($"{--j} ");

        // conclusion it is working similar to  C/C++ .
        // in post first value print then increment decrement happen.
        // in pre first increment decrement happen then value print.
    }

    // we can tell compiler about type of integer should use for enum value.
    enum Weeks:uint{
        Sunday,
        Monday,
        Tuesday=11,
        Wednesday,
        Thursday=23,
        Friday,
        Saturday
    }   
    enum Rollno:byte{
        Ram = 10,
        shyam = 14,
        Shivam = 8,
        Tanu = 7
    }
    static void useOfEnum()
    {
        // # use of enum
        // foreach(var x in Weeks){
        //     Console.WriteLine(Weeks);
        // } doubt : can i access enum member with foreach loop.
        
        Console.WriteLine(Weeks.Sunday);
        Console.WriteLine(Weeks.Monday);
        Console.WriteLine(Weeks.Tuesday);
        Console.WriteLine(Weeks.Wednesday);
        Console.WriteLine(Weeks.Thursday);
        Console.WriteLine(Weeks.Friday);
        Console.WriteLine(Weeks.Saturday);
        
        Console.WriteLine((int)Weeks.Sunday);
        Console.WriteLine((int)Weeks.Monday);
        Console.WriteLine((int)Weeks.Tuesday);
        Console.WriteLine((int)Weeks.Wednesday);
        Console.WriteLine((int)Weeks.Thursday);
        Console.WriteLine((int)Weeks.Friday);
        Console.WriteLine((int)Weeks.Saturday);
        
        // Weeks.Wednesday = 11; // giving error left side is a value not a variable;
        
        // Console.WriteLine((int)Weeks.Sunday);
        // Console.WriteLine((int)Weeks.Monday);
        // Console.WriteLine((int)Weeks.Tuesday);
        // Console.WriteLine((int)Weeks.Wednesday);
        // Console.WriteLine((int)Weeks.Thursday);
        // Console.WriteLine((int)Weeks.Friday);
        // Console.WriteLine((int)Weeks.Saturday);
        
        // Enum always increment next value by 1 respect to previous enum member.
        
        Console.WriteLine((int)Rollno.Ram);
        Console.WriteLine((Rollno)7); // Conversion int value to enum value.
        Console.WriteLine((Rollno) 24); // if try to convert int value which is not in 
        //enum then it will return the same value.

        // we can't do algebric operation on enum values, until they are converted to int.
        // Console.WriteLine(Weeks.Sunday+Weeks.Tuesday); // giving Error CS0019 can't use + sign.
        Console.WriteLine((Weeks)((int)Weeks.Monday+(int)Weeks.Tuesday));
    }
    static void eligibleToVote(int age)
    {
        //Develop a C# program that asks the user for their age and determines if they are eligible to vote.
        if (age>=18)
        {
            Console.WriteLine($"Yes person with {age} age are eligible to vote.");
        }else
        {
            Console.WriteLine($"You are not eligible to vote");
        }
    }
    
}
}