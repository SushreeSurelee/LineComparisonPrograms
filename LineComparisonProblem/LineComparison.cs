using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparison
    {
        static double lengthOfLine(int x1, int x2, int y1,int y2)
        {
            int diffOfXCordinate = x2 - x1;
            int diffOfYCordinate = y2 - y1;

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
            Console.WriteLine("The cordicates of first point is ({0},{1})" , x1, y1);

            Console.WriteLine("Enter the points of second cordinator");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cordicates of second point is ({0},{1})", x2, y2);

            double lenghtOfLines = lengthOfLine(x1, x2, y1, y2);
            
            Console.WriteLine("Length of the line is " + lenghtOfLines + " CM");

            Console.ReadLine();

        }



    }
        
}
