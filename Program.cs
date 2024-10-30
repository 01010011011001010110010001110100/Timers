using System;

namespace Timers
{
    public class Program {

        // --------------------------------------// [ EntryPoint ]


        public static void Main(string[] args) 
        {
            StartProgram();
        }


        // --------------------------------------// [ MAIN PROCESS ]


        private static void StartProgram()
        {
            // Resouces
            string? userAnswer = string.Empty;
            CustomTimer timer1 = new CustomTimer(1);
            CustomTimer timer2 = new CustomTimer(2);
            
            // Start
            while (true) 
            {
                // Menu
                while (true) 
                {
                    Console.Clear();
                    Console.WriteLine("     _________________________________");
                    Console.WriteLine("    |              MENU               |");
                    Console.WriteLine("    |¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                    Console.WriteLine(" 1# |         Start Timer #1          |");
                    Console.WriteLine(" 2# |         Start Timer #2          |");
                    Console.WriteLine(" 3# |          Stop Timer #1          |");
                    Console.WriteLine(" 4# |          Stop Timer #2          |");
                    Console.WriteLine(" 5# |    Show current Timers Values   |");
                    Console.WriteLine(" 6# |         [*] End Program         |");
                    Console.WriteLine("    |_________________________________|");
                    Console.Write("\n\n Write the number of an option: ");

                    userAnswer = Console.ReadLine();
                    if (ValidAnwer(userAnswer, new []{"1","2","3","4","5","6"})) break;
                }

                // Make Action
                switch (userAnswer)
                {
                    case "1": timer1.Start(); break;
                    case "2": timer2.Start(); break;
                    case "3": timer1.Stop(); break;
                    case "4": timer2.Stop();break;
                    case "5": ShowTimersState(timer1, timer2); break;
                    case "6": Environment.Exit(0); break;
                }
            }
        }


        // --------------------------------------// [ Secondary Functions ]


        private static bool ValidAnwer(string? answer, string[] options) 
        {
            if (answer == null) return false;
            string? OptionSelected = options.FirstOrDefault(option => option == answer);
            return OptionSelected == null ? false : true;
        }

        private static void ShowTimersState(CustomTimer timer1, CustomTimer timer2)
        {
            Console.Clear();
            Console.WriteLine(" ________________________ ");
            Console.WriteLine("|    TIMERS PROGRESS     |");
            Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ \n");
            Console.WriteLine($" * | Timer #1 : [ {timer1.Value} ]");
            Console.WriteLine($" * | Timer #2 : [ {timer2.Value} ]");
            Console.WriteLine("\n\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}