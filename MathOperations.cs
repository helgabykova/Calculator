using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
        public class MathOperations
    {


        public static double Sum(ReaderAndOutput r)
        {
            return r.A + r.B;
        }

        public static double Minus(ReaderAndOutput r)
        {
            return r.A - r.B;
        }

        public static double Multi(ReaderAndOutput r)
        {
            return r.A * r.B;
        }

        public static double Div(ReaderAndOutput r)
        {
            return r.A / r.B;
        }

        public static Sign ConvertStringToEnum (string sign)
        {
            switch (sign)
            {
                case "+":
                    return Sign.Plus;
                case "-":
                    return Sign.Minus;
                case "*":
                    return Sign.Multi;
                case "/":
                    return Sign.Div;

                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
}
    public enum Sign { Plus, Minus, Multi, Div };


}
