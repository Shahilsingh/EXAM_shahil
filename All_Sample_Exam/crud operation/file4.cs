using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file4
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the name of your file");
                string s = Console.ReadLine();
                string text = File.ReadAllText(@"D:\\HTMLoffice\\Assesment\\" + s + ".txt");
                Console.WriteLine("enter the text you want to replace");
                string s1 = Console.ReadLine();
                Console.WriteLine("enter the text you want at its place");
                string s2 = Console.ReadLine();
                text = text.Replace(s1, s2);
                File.WriteAllText(@"D:\\HTMLoffice\\Assesment\\" + s + ".txt", text);
                
            }
            catch(FileNotFoundException)
            {

                // updating file
                Console.WriteLine("entered file name is wrong please write correct name");
                string s = Console.ReadLine();
                string text = File.ReadAllText(@"D:\\HTMLoffice\\Assesment\\" + s + ".txt");
                Console.WriteLine("enter the text you want to replace");
                string x1 = Console.ReadLine();
                Console.WriteLine("enter the text you want at its place");
                string x2 = Console.ReadLine();
                text = text.Replace(x1, x2);
                File.WriteAllText("D:\\HTMLoffice\\Assesment\\" + s + ".txt", text);
                
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Ooops...something went wrong please try again later: " + e);
            }
            Console.Read();
            
        }
    }
}
