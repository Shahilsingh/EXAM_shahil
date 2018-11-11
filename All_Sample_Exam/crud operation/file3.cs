using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file3
    {
        static void Main(string[] args)
        {
            try
            {
                // Specifying file to read  
                string loc = "D:\\HTMLoffice\\Assesment\\Shahil.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                // Opening file to read  
                StreamReader sr = file.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            Console.Read();
        }
    }
}
