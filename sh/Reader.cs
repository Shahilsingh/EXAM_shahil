using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class Reader
    {
        public static void Main(string[] args)
        {

            try
            {

                FileStream f = new FileStream(@"g:\\HELLOEVERYONE.txt", FileMode.OpenOrCreate);
                StreamReader s = new StreamReader(f);

                string line1 = s.ReadLine();
                Console.WriteLine(line1);
                string line2 = s.ReadLine();
                Console.WriteLine(line2);

                s.Close();
                f.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFoundException" + ex);
            }
            Console.Read();
        }
    }
}
