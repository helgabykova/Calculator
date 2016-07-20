<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReaderAndOutput.GetData();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {

        public static void GetData()
        {
            double operand1;
            double operand2;
            string sign;

            try
            {
                Console.WriteLine("Enter the 1st number");
                operand1 = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.WriteLine("Enter the sign");
                    sign = Console.ReadLine();
                }
                while (sign != "+" && sign != "-" && sign != "*" && sign != "/");


                Console.WriteLine("Enter the 2st number");
                operand2 = Convert.ToDouble(Console.ReadLine());

                if (sign == "+")
                {
                    Sum(operand1, operand2);
                }
                else if (sign == "-")
                {
                    Minus(operand1, operand2);
                }
                else if (sign == "*")
                {
                    Multi(operand1, operand2);
                }
                else if (sign == "/")
                {
                    Div(operand1, operand2);
                }

                Console.ReadLine();
                AskToContinue();
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                GetData();
            }
        }


        public static double Sum(double a, double b)
        {
            Console.WriteLine("The sum of {0}+{1}={2}", a, b, a + b);
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            Console.WriteLine("The deduction of {0}-{1}={2}", a, b, a - b);
            return a - b;
        }

        public static double Multi(double a, double b)
        {
            Console.WriteLine("The multiplication of {0}*{1}={2}", a, b, a * b);
            return a * b;
        }

        public static double Div(double a, double b)
        {
            Console.WriteLine("The division of {0}/{1}={2}", a, b, a / b);
            return a / b;
        }

        public static void AskToContinue()
        {
            string answer;
            do
            {
                Console.WriteLine("Do you want to continue and enter one more function?");
                Console.WriteLine("Answer 'y' or 'n'.");
                answer = Console.ReadLine();
            }
            while (answer != "y" && answer != "Y" && answer != "n" && answer != "N");

            if (answer == "y" || answer == "Y") { 
            GetData();
            }
            else
            {
                Console.WriteLine("Thanks for using the funtion");
                Console.ReadLine();
            }
            
        }

        static void Main(string[] args)
        {
            GetData();
        }
    }
}
>>>>>>> fff55aeaccea580a17b8f7200c49562cb8e18185
