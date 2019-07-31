using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqPractice practice = new LinqPractice();
            Console.WriteLine(practice.AtoZWithFrequency("terrill"));
            Console.ReadKey();
        }
    }
}
