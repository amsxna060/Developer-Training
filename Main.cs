using variablevar;
using datatypes;
using programss;
using college;
class MyClass{
    static void Main(string[] args){
        int a,b,c;
        a=5;
        b=10;
        c = a+b;
        // Console.WriteLine(c);

        
        /**
        In windows system console window might 
        disappear after printing the last line 
        so keeping we can use 
        
        Console.ReadLine(); // this will wait for input on console window.
         */

        // Execution of UseOfVar file
        // UseOfVar.Var();
        // Datatype.convertStrToInt();
        // Strings.RunStrings();
        // Programs.Average();

        // string ans = Programs.AverageByArray(5);
        // Console.WriteLine(ans);

        // Programs.ReverseString("Hello this is a Reversed Strings");


        // Code regarding Cgpa calculator;
        CGPA_Cal c1 = new CGPA_Cal("Amol Saxena",21,2);
        c1.inputMarks();
        c1.printMarks();
        c1.printCGPA();
    }
}
