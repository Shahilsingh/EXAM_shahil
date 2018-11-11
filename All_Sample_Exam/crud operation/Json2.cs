using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Test
{
    class J1
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0}\n Age:{1}", name, age);
        }
    }
    class Json2
    {
        static void Main(string[] args)
        {
            //deserialize json from file
            String JSONstring = File.ReadAllText(@"G:\Json1.json.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            J1 p1 = ser.Deserialize<J1>(JSONstring);//JSONstring is an object
            Console.WriteLine(p1);
            Console.Read();
        }
    }
}
