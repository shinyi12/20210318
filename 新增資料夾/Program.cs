using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            StreamReader r = new StreamReader("公共充電站.json");
            string json = r.ReadToEnd();

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    if (reader.TokenType == JsonToken.PropertyName)
                        Console.WriteLine("PropertyName: {0}", reader.Value);
                    else if (reader.TokenType == JsonToken.String)
                        Console.WriteLine("Value: {0}", reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
            Console.Read();
        }
    }

}