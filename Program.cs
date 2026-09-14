using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_Basics_C__Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("./Values.txt");
            string line = "";
            while (line != null) { 
               line = reader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
            reader.Close();
            Console.ReadLine();
        }
    }
}
