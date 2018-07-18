using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var resultList = words.Where(w => w.Contains("th"));

            foreach(var result in resultList)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            var singleNameList = names.Distinct();

            foreach (var result in singleNameList)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();

            //Problem 3
            List<string> classGrades = new List<string>()
                    {
                    "80,100,92,89,65", //90.25
                    "93,81,78,84,69", //84
                    "73,88,83,99,64", //85.75
                    "98,100,66,74,55" //84.5
                    //86.125
                    };

            var classGradesAsNunmbers = classGrades.Select(g => g.Split(',').Select(m => double.Parse(m)));
            var classGradesLowestDropped = classGradesAsNunmbers.Select(g => g.Where(m => m != g.Min()));
            var classGradeAverages = classGradesLowestDropped.Select(g => g.Average());
            Console.WriteLine(classGradeAverages.Average());
            

            //Problem 4

            string testString = "Terrill";

            var letterAndFrequency = testString.ToUpper().GroupBy(l => l).OrderBy(l => l.Key).Select(l => new { character = l.Key, count = l.Count() });

            foreach (var letter in letterAndFrequency)
            {
                Console.WriteLine(letter.character+letter.count.ToString());
            }
            Console.ReadLine();
        }
    }
}
