using System;

namespace _01StudetInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	student name 
            //•	age
            //•	average grade. 
            string studentName = Console.ReadLine();
            string age=Console.ReadLine();
            string drade=Console.ReadLine();
            // "Name: {student name}, Age: {student age}, Grade: {student grade}".
            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {drade}");

        }
    }
}
