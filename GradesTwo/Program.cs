using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesTwo
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "The New Gradebook";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g2);
            Console.WriteLine(g2.Name);

            int x1 = 4;

            IncrementNumber(x1);
            Console.WriteLine(x1);
            
            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.1f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);
        }
    }
}
