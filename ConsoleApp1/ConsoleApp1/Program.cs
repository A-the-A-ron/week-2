using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Welcome. What is your name?");     
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " +(name) +". What is your gender?");
            String gender = Console.ReadLine();
            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();
            Console.WriteLine("Hello, " + (name) + ". You are a " + (age) + " year old " + (gender)+".");
            Console.ReadKey();
            ;


        }
    }
}
