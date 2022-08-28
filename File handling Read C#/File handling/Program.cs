using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_handling
{
     class Program
    {
        static void Main(string[] args)
        {
            string name,fname,Sname;
            int age,fee;
            string path = "E:\\Semester 2 (Spring)\\OOP's\\Week 1\\File.txt";
            if(File.Exists(path))
            {
            string record;
                StreamReader fR= new StreamReader(path);
            while((record = fR.ReadLine()) != null)
            {
                    string[] SplitRecord= record.Split(',');
                    name=SplitRecord[0];
                    fname=SplitRecord[1];
                    age = int.Parse(SplitRecord[2]);
                    Sname = SplitRecord[3];
                    fee= int.Parse(SplitRecord[4]);
                    
                Console.WriteLine(name);
            Console.WriteLine(fname);
            Console.WriteLine(age);
            Console.WriteLine(Sname);
            Console.WriteLine(fee);
                }
            }
            else
            {
                Console.WriteLine("File not exsist");
            }

            Console.Read(); 

        }
    }
}
