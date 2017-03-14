using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime userBirthdate;
            DateTime todayDate = DateTime.Today;
            string input;
            bool inMode = false;
            while (true)
            
            {
                input = Console.ReadLine();

                if (input == "/help")
                {
                    Console.WriteLine("[/version], [/birthday]");
                }
                else if (input == "close")
                {
                    Console.WriteLine("Konsole wird geschlossen");
                    Environment.Exit(0);
                }
                else if (input == "/version")
                {
                    Console.WriteLine("Version 0.1");
                }
                else if (input == "/birthday")                    
                {
                    Console.WriteLine("Bitte geben sie ihr Geburtstag ein: dd/mm/yy");
                    userBirthdate = DateTime.Parse(input);
                    int userAge = todayDate.Year - userBirthdate.Year;
                    if (userBirthdate > todayDate.AddYears(-userAge)) userAge--;
                    Console.WriteLine("Du bist + userage + Jahre alt");
                }               
                else
                {

                    Console.WriteLine("Unknown command, use /help for more informations");
                }
                    
            }        
        }
    }
}
