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
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            List<string> classGrades = new List<string>()
                    {
                    "80,100,92,89,65",
                    "93,81,78,84,69", 
                    "73,88,83,99,64", 
                    "98,100,66,74,55" 
                    };
            string testString = "Terrill";


            SearchWordsForTH(words);
            RemoveDuplicateStrings(names);
            AverageClassGrades(classGrades);
            GetLetterFrequency(testString);

            void SearchWordsForTH(List<string> wordList) 
             {

                var resultList = wordList.Where(w => w.Contains("th"));
                foreach (var result in resultList)
                {
                    Console.WriteLine(result);
                }
                Console.ReadLine();
             }

            void RemoveDuplicateStrings(List<string> nameList)
            {
                var singleNameList = nameList.Distinct();

                foreach (var result in singleNameList)
                {
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }

            void AverageClassGrades(List<string> gradeList)
            {
                var classGradesAsNumbers = gradeList.Select(g => g.Split(',').Select(m => double.Parse(m)));
                var classGradesLowestDropped = classGradesAsNumbers.Select(g => g.Where(m => m != g.Min()));
                var classGradeAverages = classGradesLowestDropped.Select(g => g.Average());
                Console.WriteLine(classGradeAverages.Average());
                Console.ReadLine();
            }
 
            void GetLetterFrequency(string input)
            {
                var letterAndFrequency = input.ToUpper().GroupBy(l => l).OrderBy(l => l.Key).Select(l => new { character = l.Key, count = l.Count() });

                foreach (var letter in letterAndFrequency)
                {
                    Console.WriteLine(letter.character + letter.count.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
