using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompProblem.LineComparisionProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problems");
            Console.ReadLine();

            LineComparision lineComparision = new LineComparision();
            lineComparision.length_line();
            lineComparision.function_check();
            lineComparision.Comparelines();
        }
    }
}