using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem.LineCompProb
{
    internal class LineComparision
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
        public void Comparelines()
        {
            double Differene = Length_XY.CompareTo(Length_SR);
            if (Differene < 0)
            {
                Console.WriteLine("Length of XY is less than Length of SR");
            }
            if (Differene > 0)
            {
                Console.WriteLine("Length of XY is greater than Length of SR");
            }
            if (Differene == 0)
            {
                Console.WriteLine("Length of XY is equal to Length of SR");
            }
            Console.ReadKey();

        }
    }
}
