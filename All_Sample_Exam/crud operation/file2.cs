using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file2
    {
        static void Main(string[] args)
        {
            try
            {
                // Specifying file location  
                string loc = "D:\\HTMLoffice\\Assesment\\Shahil.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                // Creating an file instance to write  
                StreamWriter sw = file.CreateText();
                // Writing to the file  
                sw.WriteLine("A very good evening to all of you");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            Console.WriteLine("text written successfully");
            Console.Read();
        }
    }
}
