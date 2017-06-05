using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            double course = 0;
            if (p % n == 0)
                course = p / n;
            else
            
                course = (double) p / n;
                Console.WriteLine( "{0:f3}",course);

                Console.WriteLine("{0}", Math.Ceiling(course));
            
        }
    }
}
