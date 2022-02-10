using System;

namespace ConsoleAppExe0
{
    class Program
    {
        static void Main(string[] args)
        {
                bool keepGoing = true;
            do
            {
                try
                {
                    Console.WriteLine("Enter 1 to 3 to select excercise and -1 to quit !!");
                    int assignmentSel = int.Parse(Console.ReadLine() ?? "0");
                    switch (assignmentSel)
                    {
                        case 1:
                            string fn = UserInputStr("First Name");
                            string ln = UserInputStr("Last Name");
                            RunExcerciseOne(fn, ln);
                            break;
                        case 2:
                            Console.WriteLine("Excercise 2");
                            break;
                        case -1:
                            keepGoing = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection !!!");
                            break;
                    }
                    Console.WriteLine("Press any key to continue !");
                    // key press hiden with (True)
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Invalid selection - Non Numberic key detected !!!");
                }
            } while (keepGoing);
                
                Console.WriteLine("Goodbye!!!");
         }// End of Main

        private static void RunExcerciseOne(string fname, string lname)
        {
            Console.WriteLine("Hello "+fname+" "+lname+" I am glad that you completed Ex1");
            Console.WriteLine("Exc 1 completed !!!");
        }

        static string UserInputStr(string what)
        {
            Console.Write("Please enter " + what + ": ");
            return Console.ReadLine();
        }
        static int AskUserForNumber(string what)
        {
            //   string inputed = AskUserFor(what);
            string inputed = "0";
            int number = Convert.ToInt32(inputed);
            return number;
        }
        static void CodeLove()
        {
            int amount = AskUserForNumber("how mush code love do you need?");
            while (amount > 0)
            {
                Console.WriteLine("Code loves you!");
                amount--;
            }
        }

    }// End of Program
}// End of NS
