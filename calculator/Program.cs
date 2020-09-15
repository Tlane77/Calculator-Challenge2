using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Calculatron 3000!");
            //use for the string operation choice
            int operation = 0;
            //stock the result of the operation
            double result = 0;

            //Ask user first number
            Console.WriteLine("Please enter the first number :");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);

            //Ask user second number
            Console.WriteLine("Please enter the second number :");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);

            //Ask user operation to use
            Console.WriteLine("Enter the operation + (addition), - (subtraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");
            string stringOperation = Console.ReadLine();

            // Convert string choice to integral
            if (stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "subtraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }
            else if (stringOperation == "^" || stringOperation == "exponant")
            {
                operation = 5;
            }
            else if (stringOperation == "%" || stringOperation == "remainder")
            {
                operation = 6;
            }

            //Do someting depending on the operation choose
            switch (operation)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;

                case 2:
                    result = firstNumber - secondNumber;
                    break;

                case 3:
                    result = firstNumber * secondNumber;
                    break;

                case 4:
                    result = firstNumber / secondNumber;
                    break;

                case 5:
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                case 6:
                    result = firstNumber % secondNumber;
                    break;
            }
            Console.WriteLine("\nResult of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
            Console.ReadKey();
        }
    }
}