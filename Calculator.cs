using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    /* Calculator struct which contains methods which perform some calculation operations
        * add operator +
        * subtract operator -
        * multiplication operator *
        * Divide operator /
        * Modulus operator % 
        * Power operation ^
        * Absolute operaton: abs
        * Exponential operation: exp
        * Logarithm operation: log
        * Square Root: sqrt
    */
    public struct Calculator
    {
        // property X holds number 
        public double X { get; set; }

        // overloaded constructor which takes one parameter
        public Calculator(double x)
        {
            X = x;
        }

        // add method takes two Calculator arguments and return the aggregation of two numbers
        public static double operator +(Calculator x, Calculator y)
        {
            return (x.X + y.X);
        }

        // subtract method takes two Calculator arguments and returns difference of two numbers
        public static double operator -(Calculator x, Calculator y)
        {
            return (x.X - y.X);
        }

        // Multiplication method takes two Calculator arguments and return two numbers
        public static double operator *(Calculator x, Calculator y)
        {
            return (x.X * y.X);
        }

        // Division method takes two Calculator arguments and returns division of two numbers 
        public static double operator /(Calculator x, Calculator y)
        {
            // control to ensure that the denonimator is not zero (infinity)
            if (y.X == 0)
            {
                Console.WriteLine("Cannot Dividing by Zero...Infinity");
                return 0;
            }
            else
            {
                return (x.X / y.X);
            }

        }

        // Modulus method takes two Calculator arguments and returns the remainder of two fractions
        public static double operator %(Calculator x, Calculator y)
        {
            if (y.X == 0)
            {
                Console.WriteLine("Dividing by Zero...Infinity");
                return 0;
            }
            else
            {
                return (x.X % y.X);
            }
        }

        // Power method takes two Calculator arguments and returns base number x to the power y
        public static double operator ^(Calculator x, Calculator y)
        {
            /*  x is the base and y is the power e.g x^y
                control to ensure that the operation does not compute zero to power of a negative number (infinity)
            */
            if (x.X == 0 && y.X <=0)
            {
                Console.WriteLine("Error, can't generate a number: zero to power of negative number...Infinity");
                return 0;
            }
            else
            {                
                return (Math.Pow(x.X, y.X));
            }
        }

        // abs method takes one Calculator argument and returns the positive value of a number
        public static double abs(Calculator x)
        {
            return Math.Abs(x.X);
        }

        // exp method takes 1 Calculator argument and return exponential on a number
        public static double exp(Calculator x)
        {           
                return Math.Exp(x.X);            
        }

        // log method takes 1 Calculator argument and returns Log base 10 of a number e.g Log(100) =2
        public static double log(Calculator x)
        {
            // control to ensure that method does not allow log of negative number
            if (x.X <= 0)
            {
                Console.WriteLine("Error, cannot calculate Log of negative num!");
                return 0;
            }
            else
            {
                return Math.Log10(x.X);
            }
        }

        // sqrt method takes one Calculator argument and return SquareRoot of number
        public static double sqrt(Calculator x)
        {
            // control: error when calculating the Square Root of negative number
            if (x.X <=0)
            {
                Console.WriteLine("Error, cannot calculate square root of negative num!");
                return 0;
            }
            else
            {
                return Math.Sqrt(x.X);
            }
        }








    }
}
