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
            string activity = "";
            Console.WriteLine("Hello, ");
            do
            {

                Console.WriteLine("how may I help you? (timetable, memory program, exit.)");
                activity = Console.ReadLine();
                while(activity!="exit"|| activity!="timetable"||activity!="memory program")
                {
                    Console.WriteLine("sorry, please try again. (timetable, memory program, exit.)");
                    activity = Console.ReadLine();
                    if (activity == "exit" || activity == "timetable" || activity == "memory program")
                        break;
                }
                if (activity == "memory program")
                {
                    Console.WriteLine("Welcome. What is your name?");
                    String name = Console.ReadLine();
                    Console.WriteLine("Welcome. What is your name?");
                    Console.WriteLine("Hello, " + (name) + ". What is your gender?");
                    String gender = Console.ReadLine();
                    Console.WriteLine("How old are you?");
                    String age = Console.ReadLine();
                    Console.WriteLine("Hello, " + (name) + ". You are a " + (age) + " year old " + (gender) + ".");
                    Console.ReadKey();
                }
                else if (activity == "timetable")
                {
                    Console.WriteLine("Welcome. What day would you like to know about? (mon,tue,wed,thu,fri.)");
                    string myDay = Console.ReadLine();
                    if (myDay == "mon")
                        Console.WriteLine("1-3: Enterprise, 303. 3-5: Programming, 308.");
                    else if (myDay == "tue")
                        Console.WriteLine("1-3: Proffesional Practise, 308. 3-5: Information Technology, 219");
                    else if (myDay == "wed")
                        Console.WriteLine("1-2: information Technology, 219. 2-3: Enterprise, 303. 3-4: Proffesional Practice, 308. 4-5: Programming, 308");
                    else if (myDay == "thu")
                        Console.WriteLine("1-3: Programming, 308. 3-5: Enterprise, 303.");
                    else if (myDay == "fri")
                        Console.WriteLine("1-3: information technology, 219. 3-5: Proffesional Practise, 308.");
                    else if (myDay == "sat" || myDay == "sun")
                        Console.WriteLine("Do whatever the hell you want, you mother fucking god");
                    Console.ReadKey();
                }
                else if (activity == "exit")
                {
                    Console.WriteLine("Goodbye.");
                    Console.ReadKey();
                    break;
                }
            } while (activity != "exit");

            Console.WriteLine("Goodbye");
        }
    }
}
