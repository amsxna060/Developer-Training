using variablevar;
class MyClass{
    static void Main(string[] args){
        int a,b,c;
        a=5;
        b=10;
        c = a+b;
        Console.WriteLine(c);
        
        UseOfVar.Var();
        /**
        In windows system console window might 
        disappear after printing the last line 
        so keeping we can use 
        
        Console.ReadLine(); // this will wait for input on console window.
         */
    }
}
