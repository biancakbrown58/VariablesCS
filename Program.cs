using System;

namespace VariablesCS
{
    class Program
    {
        static void AboutMe()
        {
            //Creating Variables Section Method
            Console.WriteLine("About Me");
            Console.WriteLine("~~~~~~~~~~");
            var numberOfCupsOfCoffee = 0;
            var fullName = "Bianca Brown";
            var today = DateTime.Now.ToShortDateString();
            var time = DateTime.Now.ToLongTimeString();
            Console.WriteLine($"My name is: {fullName}");
            Console.WriteLine($"I drink {numberOfCupsOfCoffee} many cups of coffee a day");
            Console.WriteLine($"Today's date is {today}");
            Console.WriteLine($"The time is {time}");
            Console.WriteLine("");
        }
        //Asking user for their name method
        static string AskUserName(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }
        //Asking user for 1st number method
        static double AskForNumber(string prompt)
        {
            Console.Write(prompt);
            var firstNumberAsString = double.Parse(Console.ReadLine());

            return firstNumberAsString;
        }
        //Asking user for 2nd number method
        static double Ask2ndNumber(string prompt)
        {
            Console.Write(prompt);
            var secondNumberAsString = double.Parse(Console.ReadLine());

            return secondNumberAsString;
        }

        static void Main(string[] args)
        {
            AboutMe();

            //Getting Input From the User with AskUserName Method
            var userName = AskUserName("What is your name? ");
            if (userName == "Alice" || userName == "alice")
            {
                Console.WriteLine("HEY ALICE!!!!!");
            }
            else
            {
                Console.WriteLine($"Hmm, where's Alice? That's alright, hi there {userName}!");
            }

            //Getting Different Types of Input From the User calling the AskForNumber and Ask2ndNumber methods
            Console.WriteLine("");
            double firstOperand = AskForNumber($"{userName}, will you enter another number? ");
            double secondOperand = Ask2ndNumber("Will you enter another number? ");
            Console.WriteLine($"Awesome, thank you! {userName}.");
            Console.WriteLine("");

            //Results Message - Doing Math Portion
            Console.WriteLine("Here are some different results of your two numbers!");
            Console.WriteLine("");

            //Adding
            Console.WriteLine("+ Adding +");
            Console.WriteLine("~~~~~~~~~");
            var sum = firstOperand + secondOperand;
            Console.WriteLine($"The total of your two numbers are: {sum}");
            Console.WriteLine("");

            //Subtracting
            Console.WriteLine("- Subtracting -");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var difference = secondOperand - firstOperand;
            Console.WriteLine($"The difference of you two numbers are: {difference}");
            Console.WriteLine("");

            //Multiply
            Console.WriteLine("* Multiplying *");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            var product = firstOperand * secondOperand;
            Console.WriteLine($"Your two numbers multiplied are: {product}");
            Console.WriteLine("");

            //Divide
            Console.WriteLine("/ Dividing /");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"Your two numbers divied are: {quotient}");
            Console.WriteLine("");

            //Remainder
            Console.WriteLine("% Remainder %");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"The remainder of the two divided numbers are: {remainder}");
            Console.WriteLine("");
        }
    }
}
