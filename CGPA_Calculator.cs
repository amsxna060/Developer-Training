/**
    In this code program I have used 
    - (Exception Handling)
        - Custom Exception class, 
        - throw a custom exception and 
        - use try-catch finally blocks.
    - goto keyword 
    - Oops Concepts, 
        - class & object
        - Inheritance, 
        - calling of base class constructor, 
        - accessing base class field in sub class.
*/
namespace college
{
    public class InvalidMarks : Exception
    {
        public InvalidMarks(string message) : base(message)
        {
        }
    }
    class Student
    {
        protected string name;
        protected int roll_no;
        public Student(string name, int roll_no)
        {
            this.name=name;
            this.roll_no=roll_no;
        }

    }
    class CGPA_Cal : Student
    {
        int no_of_subjects;
        int[] marks;
        public CGPA_Cal(string name, int roll_no) : base(name, roll_no)
        {
            no_of_subjects = 0;
            marks = null;
        }
        public CGPA_Cal(string name, int roll_no, int n) : base(name, roll_no)
        {
            no_of_subjects = n;
            marks = new int[n];
        }
        public void inputMarks()
        {
            Console.WriteLine("Enter Marks : ");
            for (int i = 0; i < no_of_subjects; i++)
            {
                remarks:
                Console.Write($"SubJect {i + 1} : ");
                int mark = int.Parse(Console.ReadLine());
                try{
                    if ((mark>=0) && (mark<=100)){
                        marks[i] = mark;
                    }else
                    {
                        throw new InvalidMarks("Marks is Invalid, should be between 0 to 100.\nPlease Re-Enter Marks\n");
                    }
                }catch(InvalidMarks e){
                    Console.WriteLine(e.Message);
                    goto remarks;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }finally{
                    Console.WriteLine("This is Finally Blocks");
                } 
            }
        }
        public void printMarks()
        {
            for (int i = 0; i < no_of_subjects; i++)
            {
                {
                    Console.WriteLine($"Mark Sub {i + 1}: {marks[i]}");
                }
            } 
        }

        public void printCGPA()
        {
            Console.WriteLine($"CGPA of {this.name} roll no {this.roll_no} is {(((float)marks.Sum()) / (no_of_subjects * 100)) * 10}CGP.");
        }
    }
}