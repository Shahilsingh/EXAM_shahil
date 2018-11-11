using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Form
{
    class Update
    {
        static void Main(string[] args)
        {

            /// Replaces text in a file.

            string filePath = @"g:\HELLOEVERYONE.txt";
            string searchText = "Ravi";
            string replaceText = "ashu";
            ReplaceInFile(filePath, searchText, replaceText);
        }

        static public void ReplaceInFile(string filePath, string searchText, string replaceText)
        {

            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }
    }
}
