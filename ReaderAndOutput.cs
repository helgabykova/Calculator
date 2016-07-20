using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ReaderAndOutput
    {
        public double A { get; set; }

        public double B { get; set; }

        public ReaderAndOutput() { }

        public ReaderAndOutput(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public void Output(ReaderAndOutput r, string sign, double result)
        {
            Console.WriteLine(r.A.ToString() + " " + sign + " " + r.B.ToString() + " = " + result.ToString());
            Console.ReadLine();
        }

        public static void GetData()
        {
            double a;
            double b;
            string sign;

            try
            {
                Console.WriteLine("Enter the 1st number");
                a = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.WriteLine("Enter the sign");
                    sign = Console.ReadLine();
                }
                while (sign != "+" && sign != "-" && sign != "*" && sign != "/");

                Sign convertedSign = MathOperations.ConvertStringToEnum(sign);

                Console.WriteLine("Enter the 2st number");
                b = Convert.ToDouble(Console.ReadLine());


                if (b == 0)
                {
                    throw new System.DivideByZeroException();

                }

                ReaderAndOutput r = new ReaderAndOutput(a, b);
                if (convertedSign == Sign.Plus)
                {
                    MathOperations.Sum(r);
                    r.Output(r, sign, MathOperations.Sum(r));
                }

                else if (convertedSign == Sign.Minus)
                {
                    MathOperations.Minus(r);
                    r.Output(r, sign, MathOperations.Minus(r));
                }

                else if (convertedSign == Sign.Multi)
                {
                    MathOperations.Multi(r);
                    r.Output(r, sign, MathOperations.Multi(r));
                }

                else if (convertedSign == Sign.Div)
                {
                    MathOperations.Div(r);
                    r.Output(r, sign, MathOperations.Div(r));
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

            if (answer == "y" || answer == "Y")
            {
                GetData();
            }
            else
            {
                Console.WriteLine("Thanks for using the funtion");
                Console.ReadLine();
            }
        }
    }
}
