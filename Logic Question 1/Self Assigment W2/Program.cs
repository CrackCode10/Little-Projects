using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assigment_W2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Questtion
            /* Lilly is N years old. For each birthday she receives a 
            present. For each odd birthday (1, 3, 5, …, n) she receives toys
            for each even birthday (2, 4, 6, …, n) she receives money. For her 
            second birthday she received 10.00 USD, and the amount is 
            increased by 10.00 USD for each following even birthday (2 -> 10, 
            4 -> 20, 6 -> 30 etc.).
            Over the years Lilly has secretly saved her money. Lilly's brother, 
            in the years when she received money, took 1.00 USD from each 
            of the amounts.
            Lilly has sold the toys, received over the years, each one for P 
            USD and added the sum to the amount of saved money.
            With the money she wanted to buy a washing machine for X USD. 
            Write a Function that takes lily’s age, price of washing machine 
            and price of toy and calculates how much money she has saved and 
            if it is enough to buy a washing machine            */

            float age = 78F; float ToySold = 0F; float even=0F;float Even1 = 0F;
            float Price=100001F;  float Tprice=41F;
            
            while (age > 77F)
            {
                Console.WriteLine("Enter the Lilly Age");
                age = float.Parse(Console.ReadLine());
            }
            
            while( Price > 10000F)
            {
                Console.WriteLine("Enter the Price of Washing Machine");
                Price = float.Parse(Console.ReadLine());

            }

            while (Tprice > 40F)
            {
                Console.WriteLine("Enter the Price of Toy u Sold");
                Tprice = float.Parse(Console.ReadLine());
            }


            for (int i = 2; i <= age; i=i+2)
            {
                even = even + 10;
                Even1 = Even1 + even;              
            }
            int count=0;
            for(int i = 1; i <= age; i=i+2)
            {
                count++;
            }
            ToySold = count * Tprice;
            float total; float Rem; float gave;
            total = Even1 + ToySold - count;
            if(total > Price)
            {
                Console.WriteLine("Yes!!");
                Rem = total - Price;
                Console.WriteLine("Your Remaining Balance is {0}",Rem);
            }
            if(total < Price)
            {
                Console.WriteLine("NO!!");
                gave = Price-total;
                Console.WriteLine("Your have to pay the is {0}", gave);

            }















            Console.Read();












        }
    }
}
