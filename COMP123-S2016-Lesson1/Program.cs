using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the hello world to console method
            HelloWorldToConsole();
        }
        /**
        *@description This is my Hello World Method
        *@method HelloWorldToConsole
        *@return {string} HelloWorldString
        */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
