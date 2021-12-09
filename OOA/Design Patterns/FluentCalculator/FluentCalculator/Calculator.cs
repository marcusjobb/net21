// -----------------------------------------------------------------------------------------------
//  Calculator.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FluentCalculator
{
    internal class Calculator
    {
        private double mem = 0;
        private char op = '+';

        public Calculator Digit(double d)
        {
            //Console.Write(mem + " " + op + " " + d);
            switch (op)
            {
                case '+': mem += d; break;
                case '-': mem -= d; break;
                case '*': mem *= d; break;
                case '/': mem /= d; break;
                case 'C':
                case 'c': mem = 0; op = '+'; break;
            }
            //Console.WriteLine(" = " + mem);
            return this;
        }

        public Calculator Operator(char op)
        {
            this.op = op;
            return this;
        }

        public double Result()
        {
            return mem;
        }
    }
}
