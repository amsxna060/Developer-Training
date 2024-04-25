namespace variablevar{
class UseOfVar{
    public static void Var()
    {
        var i = 10;
        Console.WriteLine("Type of i is {0}", i.GetType());

        var str = "Hello World!!";
        Console.WriteLine("Type of str is {0}", str.GetType());

        var dbl = 100.50d;
        Console.WriteLine("Type of dbl is {0}", dbl.GetType());

        var isValid = true;
        Console.WriteLine("Type of isValid is {0}", isValid.GetType());

        var ano = new { name = "Steve" };
        Console.WriteLine("Type of ano is {0}", ano.GetType());

        var arr = new[] { 1, 10, 20, 30 };
        Console.WriteLine("Type of arr is {0}", arr.GetType());

        // var file = new FileInfo("MyFile");
        // Console.WriteLine("Type of file is {0}", file.GetType());
    }
}
/** Implicitly Typed variable **/

/**
    In C#, variables must be declared with the data type. These are called 
    explicitly typed variables.

    C# 3.0 introduced var keyword to declare method level variables without 
    specifying a data type explicitly.

    // var i = 10;

    The compiler will infer the type of a variable from the expression on the 
    right side of the = operator. Above, var will be compiled as int.

    var can be used to declare any built-in data type or a user-defined type or 
    an anonymous type variable.

    In Short var in C# work like dynamic variable in other programming language 
    like groovy& javascript.

*/
}
