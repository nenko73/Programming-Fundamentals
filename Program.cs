using System;

namespace TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //   Weekday          12$	          18$	          12$
            
            
            string dey=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            switch (dey)
            {
                case "Weekday":
                    if(age>=0&& age <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age>18&& age <= 64)
                    {
                        Console.WriteLine(  "18$");
                    }
                    else if (age>64&& age<=122)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");  
                    }
                    break;
                case "Weekend":
                    //   Weekend          15$	          20$	          15$
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (age>18&& age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else if (age>64&& age <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    //   Holiday          5$	          12$	          10$
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age>18 && age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age>64&& age <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                
            }

        }
    }
}
