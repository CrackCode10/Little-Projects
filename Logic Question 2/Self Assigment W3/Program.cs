using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assigment_W3
{
     class Program
    {

        // Question
        /*1. KamyabLife is launching a network of autonomous 
        pizza delivery drones and wants you to create a flexible 
        rewards system (Pizza Points) that can be tweaked in 
        the future. The rules are simple:
        if a customer has made at least N orders of at least Y 
        price, they get a FREE pizza!
        The information of the customers is stored in a file 
        Customers.txt in the following format. First the name 
        of the customer is given then after the space the 
        number of orders are given then after the space within 
        the brackets all the orders prices are given*/
        static string Fname;
        static int Forder;
        static int order;
        
        static int[] BPrice = new int[20];

        static void Main(string[] args)
        {
            int[] price = new int[10]; 
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter The number of Order: ");
            order = int.Parse(Console.ReadLine());
            for (int i = 0; i < order; i++)
            {
                Console.Write("Enter The Price : ");
                price[i] = int.Parse(Console.ReadLine());
            }
            storeddatainfile(name, order, price);
            Readdatafromfile();
            ReadPricefromfile();
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(BPrice[i]);
            }
          

            Console.Read();
        }
       /* static int Menu()
        {
            int op;
            int small = 70;
            int medium = 170;
            int large = 270;
            Console.WriteLine("   1. Small  Price= {0}",small);
            Console.WriteLine("   2. Medium Price= {0}",medium);
            Console.WriteLine("   3. Large  price= {0}",large);
            Console.WriteLine("   4. Complete ");
            Console.WriteLine("Select the order: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }*/
        static void storeddatainfile(string name,int order, int[] price)
        {
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\Coustmer.txt";
            StreamWriter F = new StreamWriter(path, true);
            F.Write(name + " " + order+" ");
            for(int j = 0; j < order; j++)
            {
                F.Write( price[j]+";");
            }
               

            F.Flush();
            F.Close();
            

        }


        static void Readdatafromfile()
        {
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\Coustmer.txt";
            string record;
            StreamReader RF = new StreamReader(path, true);
           // int x = 0;
           
            while ((record=RF.ReadLine())!=null)
            {
                string[] splitedRecord = record.Split(' ');
                Fname = splitedRecord[0];
                Forder = int.Parse(splitedRecord[1]);
              /*  BPrice[x] = int.Parse(splitedRecord[3]);
                x++;
                BPrice[x] = int.Parse(splitedRecord[4]);
                x++;*/
            }
            RF.Close();
        }



        static void ReadPricefromfile()
        {
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\Coustmer.txt";
            string record;
            StreamReader RF = new StreamReader(path, true);
            int x = 0;
            int count = 0;
           
            while ((record = RF.ReadLine()) != null)
            {
                string[] splitedprice = record.Split(';');
                
               BPrice[x] = int.Parse(splitedprice[0]);
               //BPrice[x++] = int.Parse(splitedprice[count++]);
                x++;
                if (count == order)
                {
                    break;
                }
                
            }
            RF.Close();
        }




    }
}
