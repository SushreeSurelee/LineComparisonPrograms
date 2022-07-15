using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");

            Console.WriteLine("Enter the cordinates of first points");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of first point is ({0},{1})" , x1, y1);

            Console.WriteLine("Enter the cordinates of second points");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of second point is ({0},{1})", x2, y2);

            int diffOfXCordinate = x2 - x1;
            int diffOfYCordinate = y2 - y1;

            double XExp2 = Math.Pow(diffOfXCordinate, 2);
            double YExp2 = Math.Pow(diffOfYCordinate, 2);

            double lengthOfLine = Math.Sqrt(XExp2 + YExp2);
            Console.WriteLine("Length of the line is " + lengthOfLine + " CM");

            bool checkLines = diffOfXCordinate.Equals(diffOfYCordinate);
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
