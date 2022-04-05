using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem.LineCompProb
{
    internal class FunctionCheck
    {
        public int X_One;
        public int X_Two;
        public int Y_One;
        public int Y_Two;
        public int S_One;
        public int S_Two;
        public int R_One;
        public int R_Two;
        public double Length_XY;
        public double Length_SR;
        public void function_check()
        {
            bool equal_result = Length_XY.Equals(Length_SR);

            if (equal_result == false)
                Console.WriteLine(" Length of XY and Length of SR are NOT Equal");
            else
                Console.WriteLine("Length of XY and Length of SR are Equal");
            Console.ReadKey();
        }

    }
}
