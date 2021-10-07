using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine($"Sum of two integers is {Add(2, 5)}");
          
            Console.WriteLine($"Sum of two decimal is {Add(2.5m,5.7m)}");
           
            Console.WriteLine($"Amount is {Add(-1,1,true)}");
           
        }

        public static int Add(int x,int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;

        }
        public static string Add(int x,int y, bool a)

        {
            if (a)
                return x + y > 1 || x + y == 0 ? $" {x + y} dollars" : $" {x + y} dollar";
            else
                return (x + y).ToString();
        }
    }
}
