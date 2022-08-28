using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
     class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number to check it nature");
            num=int.Parse(Console.ReadLine());
            Check(num);

            Console.Read();
        }
        
           
        static bool Check(int number)
        {
            if(number%2 != 0)
            {
                Console.WriteLine("Number is odd");
            return true;

            }
            else
            {
                Console.WriteLine("Number is even");

                return false;
            }
        }
    }
}
