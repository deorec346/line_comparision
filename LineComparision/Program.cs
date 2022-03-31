using LineComparisionProblem.LineCompProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem.LineCompProb
{
    public class lineComparision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RFP-131Batch");
            Console.WriteLine("1:LengthLine\n2:FunctionCheck\n3:CompareLine\n4:\n5:\n6:\n7");
            int option = Convert.ToInt32(Console.ReadLine());//"1"
            Console.WriteLine("Welcome to Line Comparison Problems");
            switch (option)
            {
                case 1:
                    LengthLine lengthLine = new LengthLine();
                    lengthLine.length_line();
                    Console.WriteLine();
                    break;

                case 2:
                    FunctionCheck functionCheck = new FunctionCheck();  
                    functionCheck.function_check();
                    Console.WriteLine();
                    break;
                case 3:
                    LineComparision lineComparision = new LineComparision();
                    lineComparision.Comparelines();
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Please choose number within range");
                    break;
            }
            Console.ReadLine();

            
        }
    }
}