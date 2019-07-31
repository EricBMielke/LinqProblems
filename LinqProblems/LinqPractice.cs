using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class LinqPractice
    {
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> thWords = new List<string>() { };
        List<string> names = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        List<string> classGrades = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };

        public List<string> LispFunction()
        {

            var varSubstring = words.Where(x => x.IndexOf("th") == 0).ToList();
            foreach (var vartemp in varSubstring)
            {
                thWords.Add(vartemp);
            }
            return thWords;
        }

        public List<string> RemoveDuplicates()
        {
            names = names.Distinct().ToList();
            return names;
        }
        public double DropLowestAndAverage(List<string> classGrades)
        {

            List<double> singleAverage = new List<double>();
            foreach (string originalValue in classGrades)
            {
                var values = originalValue.Split(',');
                var orderedValues = values.OrderBy(s => s);
                var changedValues = orderedValues.Select(s => Convert.ToDouble(s)).ToList();
                var averageMinusSmallest = changedValues.Where(d => d > changedValues.Min()).Average();
                singleAverage.Add(averageMinusSmallest);
            }
            var totalAverage = singleAverage.Average();
            return totalAverage;
        }
        public string AtoZWithFrequency(string letters)
        {
           string finalString = "";
           var orderedLetters = letters.OrderBy(c => c).GroupBy(c => c);
           foreach(var c in orderedLetters){
                finalString += c.Key;
                finalString += c.Count();
            }
            return finalString;
        }
    }
}
