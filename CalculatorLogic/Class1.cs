using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class Class1
    {
       //Addition
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

       //Substraction
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        //Multiplication
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        //Division
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}

