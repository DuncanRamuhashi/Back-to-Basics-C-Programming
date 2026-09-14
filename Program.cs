using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_Basics_C__Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Working with Text file
            /***
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
            ***/

            //5. Working with Strings 

            //   \ is an escape character in C# and is used to represent special characters in a string.

            //string myString = "Go to you c:\\drive";
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \n new line?";

            //string myString =  string.Format("{0} {1}", "First", "Second");
            // currency formatting
            //string myString = string.Format("{0:C}", 455.4888);  
            // decimal formatting
            //string myString = string.Format("{0:N}", 455.4888);
            // percentage formatting 
            //string myString = string.Format("{0:P}", .4888);

            // custom formatting like phone numbers
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            //StringBuilder stringBuilder = new StringBuilder();       //this can be good for polymorphic behavior and can be used to build strings efficiently

           // for (int i = 0; i < 100; i++) {
          //      stringBuilder.Append("--");
          //      stringBuilder.Append(i);
          //  }

            //Console.WriteLine(stringBuilder.ToString());
           // Console.ReadLine();


            //6.Working with Dates and Times
             

           // DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString());
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());
            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToLongTimeString());
            //Console.WriteLine(dateTime.AddDays(3).ToLongDateString());
            //Console.WriteLine(dateTime.AddHours(3).ToLongTimeString());


           //DateTime myBirthday = new DateTime(1999, 01, 05);
           // TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myBirthday.ToString());
           // Console.WriteLine(myAge.ToString());
          //  Console.ReadLine();




        }

        class car
        {
            public string model;
            public string color;
            public int year;
            public void drive()
            {
                Console.WriteLine("Car is driving");
            }
            public void brake()
            {
                Console.WriteLine("Car is braking");
            }
        }
        class polo : car{ 
        
          
        }


    }
}
