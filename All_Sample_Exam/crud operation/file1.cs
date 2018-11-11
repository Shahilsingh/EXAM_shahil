using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the name you want for your file");
                string s1 = Console.ReadLine();
                  
                string loc = s1 +".txt";
                 
                FileInfo file = new FileInfo(loc);
                  
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}
