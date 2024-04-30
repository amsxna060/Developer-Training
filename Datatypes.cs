using System;
using System.Globalization;

namespace datatypes
{
    class Datatype
    {
        public static void DT()
        {
            byte x = 3; // unsigned byte we can store only positive integer until 0 to 255
            sbyte y = -23; // signed byte -128 to 127

            short s = -45; // 2 byte memory
            ushort us = 55;  // 2 byte memory

            int n = -1234; // 4 byte

            uint un =  123123; // only positive 4 byte memory (suffix 456u)

            // long, ulong both are 64 bit memory integer signed & unsigned respectfully (suffix l & ul)
            // float is 32-bit single precision floating type (max precision = 5) 'f'
            // double is 64 bit double precision floating type (max precision around 14 or 15) 'd'

            decimal dec = 7.9e28m; // for financial values 128 bit 'm' 
            char ch = 'A';  // 16 bit, single unicode character
            bool isValid = true; // 8 bit logical for true false.. 
            
            // object, string, DateTime other datatypes 

            // - In C# Compiler give error if we exceed the range in datatypes, not rotate values like c++.
            // The value of unsigned integers, long, float, double, and decimal type must be suffix by u,l,f,d, and m, respectively.
            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 45755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;

            /**
                - all datatypes in C# is struct of .NET, those written datatypes are alias for .NET Type (CLR Class)
                like int is System.Int32 & ushort is System.UInt16

                except object & string all datatypes in .NET are struct type, these two are class type.
                */

            /*
            Every data type has a default value. Numeric type is 0, boolean has false,
            and char has '\0' as default value. 
            Use the default(typename) to assign a default value of the data type or C# 7.1 onward.
            */

            int def = default(int); // before C# 7.1
            int defa = default; // after C# 7.1

            // implicit conversion mostly happen from small size datatypes to large datatypes
            int sc = 123;
            float fc = sc; // implicit 

            // explicit conversion may cause dataloss and precision loss
            // syntax 

            int fi = (int)fc; // explict conversion;
        }
        
        public static void convertStrToInt()
        {
            /**
                - There are three ways;
                    1. Parse() 
                    2. Convert Class
                    3. TryParse()

                The Parse() methods are available for all the primitive datatypes. 
                It is the easiest way to convert from string to integer.

                in Int16,Int32,Int64 we have parse method.
                Method Overloads
                - Parse(string s)
                - Parse(string s, numberstyle style)
                - Parse(String s, NumberStyles style, IFormatProvider provider)
            */
            Console.WriteLine(Int32.Parse("100"));
            Console.WriteLine(int.Parse("(100)",NumberStyles.AllowParentheses));
            Console.WriteLine(int.Parse("-100",NumberStyles.AllowLeadingSign));
            Console.WriteLine(int.Parse("30,000",NumberStyles.AllowThousands,new CultureInfo("en-au")));
            Console.WriteLine(int.Parse("$1000000", NumberStyles.AllowCurrencySymbol));
            
            /**
                Pros:

                Converts valid numeric string to integer value.
                Supports different number styles.
                Supports culture-specific custom formats.
                
                Cons:

                Input string must be a valid numeric string.
                The numeric string must be within the range of int type on which the method is called.
                Throws exception on converting null or invalid numeric string.
            */

            Convert.ToInt16("100"); // returns short
            Convert.ToInt16(null);//returns 0

            Convert.ToInt32("233300");// returns int
            Convert.ToInt32("1234",16); // returns 4660 - Hexadecimal of 1234

            Convert.ToInt64("1003232131321321"); //returns long

            // the following throw exceptions
            // Convert.ToInt16("");//throws FormatException
            // Convert.ToInt32("30,000"); //throws FormatException
            // Convert.ToInt16("(100)");//throws FormatException
            // Convert.ToInt16("100a"); //throws FormatException
            // Convert.ToInt16(2147483649);//throws OverflowException

            // bool Int32.TryParse(string s, out int result)
            // bool Int32.TryParse(string s, NumberStyle style, IFormatProvider provider, out int result)
        }

        public static void Number()
        {
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine(Int64.MaxValue);//9223372036854775807
            Console.WriteLine(Int64.MinValue);//-9223372036854775808
            Console.WriteLine(UInt64.MaxValue);//18446744073709551615
            Console.WriteLine(UInt64.MinValue);//0

            // in Int struct static field of MinValue & MaxValue to access max & min value.

        }

    }
    class Strings
    {
        public static void RunStrings()
        {
            //ways to declaring strings
            string s1 = "Hello"; // uses string keyword
 
            String s2 = "Hello"; // uses System.String class

            char[] chars = {'H','e','l','l','o'};

            string str1 = new string(chars);  
            String str2 = new String(chars); 

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }
            // for special character like ' " \ we need to use backslash in string.
            string text = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";

            // It is tedious to prefix \ to include every special characters. 
            // Verbatim string in C# allows a special characters and line brakes.

            string vstr = @"xyzdef\rabc
            fsdlfjsdl";

            Console.WriteLine(vstr);

            // can't use backslash for " in v string. 
            string text1 = "This is a \"string\" in C#."; // valid
            // string text = @"This is a "string." in C#."; // error
            // string text = @"This is a \"string\" in C#."; // error
            string text2 = @"This is a ""string"" in C#."; // valid

            // ** String interpolation or like format string in python
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";
            
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            // String is mutable in C# like Java & python. (ref type)

        }
        // The ternary operator is right-associative. The expression a ? b : c ? d : e 
        // is evaluated as a ? b : (c ? d : e), not as (a ? b : c) ? d : e.
    }
}