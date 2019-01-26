using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorLibrary;


namespace CalcLibrary
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Select Calculation Operation to test...");
            Console.WriteLine("0. EXIT PROGRAM");
            Console.WriteLine("1. Absolute");
            Console.WriteLine("2. Additon");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Exponential");
            Console.WriteLine("5. Log");
            Console.WriteLine("6. Modulus");
            Console.WriteLine("7. Multiply");
            Console.WriteLine("8. Power");
            Console.WriteLine("9. SquareRoot");
            Console.WriteLine("10. Subtract");
            

        }


        public static double getNumber()
        {
            double num = 0;

            Console.WriteLine("Enter Number: ");
            bool Isvalid = double.TryParse(Console.ReadLine(), out num);

            while (!Isvalid)
            {
                Console.WriteLine("Invalid selecton...try again!\nEnter Number: ");
                Isvalid = double.TryParse(Console.ReadLine(), out num);
            }

            return num;

        }


        static void Main(string[] args)
        {
            // Calculator calcTest = new Calculator();
            int selection = -1;
            Calculator calc1 = new Calculator();
            Calculator calc2 = new Calculator();
            bool Isvalid;

            Menu();
            Isvalid = int.TryParse(Console.ReadLine(), out selection);

            while (selection !=0)
            {


                while (!Isvalid || (selection < 1 || selection > 10))
                {
                    Console.WriteLine("\nInvalid Selection....try again!\n");
                    Menu();
                    Isvalid = int.TryParse(Console.ReadLine(), out selection);
                }


                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter 1 numbers to perform Absolute operation...");
                        calc1.X = getNumber();
                        Console.WriteLine($"Absolute of {calc1.X} is {Calculator.abs(calc1)}");
                        break;

                    case 2:
                        Console.WriteLine("Enter 2 numbers to perform addition operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"Sum of {calc1.X} & {calc2.X} is { calc1 + calc2}");
                        break;

                    case 3:
                        Console.WriteLine("Enter 2 numbers to perform subtraction operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"{calc1.X} divide by {calc2.X} = { calc1 / calc2}");
                        break;

                    case 4:
                        Console.WriteLine("Enter 1 numbers to calculate the exponential operation...");
                        calc1.X = getNumber();
                        Console.WriteLine($"Exponential of {calc1.X} = { Calculator.exp(calc1)}");
                        break;

                    case 5:
                        Console.WriteLine("Enter 1 numbers to calculate the Log operation...");
                        calc1.X = getNumber();
                        Console.WriteLine($"Log of {calc1.X} = { Calculator.log(calc1)}");
                        break;

                    case 6:
                        Console.WriteLine("Enter 2 numbers to calculate the Modulus operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"{calc1.X} Modulus {calc2.X} = { calc1 % calc2}");
                        break;

                    case 7:
                        Console.WriteLine("Enter 2 numbers to calculate the Multiplication operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"{calc1.X} multiply b {calc2.X} = { calc1 * calc2}");
                        break;

                    case 8:
                        Console.WriteLine("Enter 2 numbers to calculate the to the Power of operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"{calc1.X} to the power of {calc2.X} = { calc1 ^ calc2}");
                        break;

                    case 9:
                        Console.WriteLine("Enter 1 numbers to calculate the SquareRoot operation...");
                        calc1.X = getNumber();
                        Console.WriteLine($"Square Root of {calc1.X} = { Calculator.sqrt(calc1)}");
                        break;

                    case 10:
                        Console.WriteLine("Enter 2 numbers to calculate the Subraction operation...");
                        calc1.X = getNumber();
                        calc2.X = getNumber();
                        Console.WriteLine($"{calc1.X} minus  {calc2.X} = { calc1 - calc2}");
                        break;


                    default:
                        break;


                }

                Console.WriteLine("Any key to continue...or \"0\"(zero) to finish");

                Isvalid = int.TryParse(Console.ReadLine(),out selection);
                if (!Isvalid)
                {
                    selection = -1;
                }

                if (selection != 0) {
                    Menu();
                    Isvalid = int.TryParse(Console.ReadLine(), out selection);
                }
                



            }

            Console.WriteLine("\nAny key to finish...");

            Console.ReadLine();
        }
    }
}
