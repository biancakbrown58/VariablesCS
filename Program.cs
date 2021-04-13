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
            var today = DateTime.Now;
            var time = DateTime.Now.ToLongTimeString();
            Console.WriteLine($"My name is: {fullName}");
            Console.WriteLine($"I drink {numberOfCupsOfCoffee} many cups of coffee a day");
            Console.WriteLine($"Today's date is {today}");
            Console.WriteLine($"The time is {time}");
            Console.WriteLine("");
        }

        static string AskUserName(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static void Main(string[] args)
        {
            AboutMe();

            //Getting Input From the User with AskUserName Method
            var userName = AskUserName("What is your name? ");
            if (userName == "Alice" || userName == "alice")
            {
                Console.WriteLine("HEY ALICE!!");
            }
            else
            {
                Console.WriteLine($"Hmm, where's Alice? That's alright, hi there {userName}");
            }

            //Getting Different Types of Input From the User
            Console.WriteLine("");
            Console.Write($"{userName}, will you enter a number? ");
            var firstNumberAsString = Console.ReadLine();

            Console.WriteLine($"Awesome, thank you! {userName}.");
            Console.Write("Will you enter another number? ");
            var secondNumberAsString = Console.ReadLine();

            //Converting String Input Into Numbers
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            //Doing Math Portion
            Console.WriteLine("");

            //Results Message
            Console.WriteLine("Here are some different results of your two numbers!");
            Console.WriteLine("");

            //Adding
            Console.WriteLine("+Adding+");
            Console.WriteLine("~~~~~~~~~");
            var sum = firstOperand + secondOperand;
            Console.WriteLine($"The total of your two numbers are: {sum}");

            //Subtracting
            Console.WriteLine("-Subtracting-");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var difference = secondOperand - firstOperand;
            Console.WriteLine($"The difference of you two numbers are: {difference}");

            //Multiply
            Console.WriteLine("*Multiplying*");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            var product = firstOperand * secondOperand;
            Console.WriteLine($"Your two numbers multiplied are: {product}");

            //Divide
            Console.WriteLine("/Dividing/");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"Your two numbers divied are: {quotient}");

            //Remainder
            Console.WriteLine("%Remainder%");
            Console.WriteLine("~~~~~~~~~~~~~~");
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"The remainder of the two divided numbers are: {remainder}");
        }
    }
}
