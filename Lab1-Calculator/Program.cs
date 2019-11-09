using System;

namespace Lab1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            //New object of the Calculator class
            var calculator = new Calculator();

            do // Show this menus as long as user didnt enter #7 
            {
                Console.WriteLine("Pick an alternative between (1) to (7) to continue..\n");
                Console.WriteLine("(1). Add two numbers");
                Console.WriteLine("(2). Multiply two numbers");
                Console.WriteLine("(3). Sum the numbers between two numbers");
                Console.WriteLine("(4). Add number to memory");
                Console.WriteLine("(5). Clear memory");
                Console.WriteLine("(6). Print calculator contents.");
                Console.WriteLine("(7). Quit");
                Console.WriteLine();
               

                choice = (Console.ReadLine());
                CalculatorOptions(choice, calculator);
            } while (choice != "7");

        }

        // To take inputs from user 
        private static void UserEntries(Calculator calculator)
        {
            Console.Write("\nEnter the First number: ");
            calculator.FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("\nEnter The Second number: ");
            calculator.SecondNumber = int.Parse(Console.ReadLine());

        }
        // A method to run the choosen alternative from user with Switch
        private static void CalculatorOptions(string choice, Calculator calculator)
        {
            switch (choice)


            {
                // Made all the cases in the string so if the user enters a character instead of a number , program wont crash.
                case "1":
                    // add
                    UserEntries(calculator);
                    Console.WriteLine(String.Format("Sum of : {0} + {1} =  is {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.SumNumbers()));
                    break;
                case "2":
                    // multiply
                    UserEntries(calculator);
                    Console.WriteLine(String.Format("Product of {0} * {1} = is {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.MultiplyNumbers()));
                    break;
                case "3":
                    // sum between two numbers
                    UserEntries(calculator);
                    Console.WriteLine(String.Format("The sum between {0} and {1} = is {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.SumInBetween()));
                    break;
                case  "4":
                    // to save numbers in the calculator memory 
                    Console.Write("add number to save in the memory: ");
                    calculator.NumberInMemory = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(String.Format("{0} successfully has been added to memory.\n", calculator.NumberInMemory));
                    break;
                case "5":
                    // clear all the numbers from memory
                    calculator.NumberInMemory = 0;
                    Console.WriteLine(" memory has been cleared\n");
                    break;
                case "6":
                    //Print saved numbers in the calclulator's memory
                    Console.WriteLine(calculator.ToString());
                    break;
                case "7":
                    // Exit
                    Console.WriteLine("Goodbye!");
                    break;
                default:

                    Console.WriteLine("\n *****INVALID INPUT - ONLY GIVEN ALTERNATIVES ARE ACCEPTED***** \n");
                    break;
            }
        }

    }
}
