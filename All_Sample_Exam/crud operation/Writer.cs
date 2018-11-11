using System;
using System.IO;
using System.Text;

namespace Form
{
    class Writer
    {
        public static void Main(string[] args)
        {

            try
            {

                FileStream f = new FileStream(@"g:\\HELLOEVERYONE.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);

                s.WriteLine("1 Shahil");
                s.WriteLine("2 Manoj");
                s.Close();
                f.Close();
            }

            catch (FileNotFoundException ex)

            {
                Console.WriteLine("FileNotFoundException" + ex);
            }
            Console.WriteLine("File created successfully...");
            Console.Read();
        }
    }
}


