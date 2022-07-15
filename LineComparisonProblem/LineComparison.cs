using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparison
    {
        static double lengthOfLine(int first, int first1, int second,int second1)
        {
            int diffOfXCordinate = first1 - first;
            int diffOfYCordinate = second1 - second;

            double XExp2 = Math.Pow(diffOfXCordinate, 2);
            double YExp2 = Math.Pow(diffOfYCordinate, 2);

            double lengthOfLine = Math.Sqrt(XExp2 + YExp2);
            return lengthOfLine;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");
          
            Console.WriteLine("Enter the poitns of first cordinator");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the points of second cordinator");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of 1st line is ({0},{1}) ({2},{3})",x1,y1, x2, y2);

            double lenghtOfLineOne = lengthOfLine(x1, x2, y1, y2);
            Console.WriteLine("Length of the first line is " + lenghtOfLineOne + " CM");

            Console.WriteLine("Enter the poitns of third cordinator");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the points of fourth cordinator");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of 2st line is ({0},{1}) ({2},{3})", x3, y3, x4, y4);

            double lengthOfLineTwo = lengthOfLine(x3, x4, y3, y4);
            Console.WriteLine("Length of the second line is " + lengthOfLineTwo + " CM");

            bool checkLines = lenghtOfLineOne.Equals(lengthOfLineTwo);
            if (checkLines)
            {
                Console.WriteLine("Lines are equal.");
            }
            else
            {
                Console.WriteLine("Lines are not equal.");
            }


            Console.ReadLine();

        }



    }
        
}
