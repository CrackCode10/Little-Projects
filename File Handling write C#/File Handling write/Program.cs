using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling_write
{
     class Program
    {
        static void Main(string[] args)
        {
            string name; string Fname; int age;string Sname;int fee; 
            Console.WriteLine("Enter the Student Name ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Father Name ");
            Fname = Console.ReadLine();

            Console.WriteLine("Enter the Age");
            age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the School Name ");
            Sname = Console.ReadLine();

            Console.WriteLine("Enter the Fee");
            fee = int.Parse(Console.ReadLine());



            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\File.txt";
            StreamWriter F=new StreamWriter(path,true);
            F.WriteLine(name+","+Fname+","+age+","+Sname+","+fee);
            F.Flush();
            F.Close();

            Console.Read();






        }
    }
}
