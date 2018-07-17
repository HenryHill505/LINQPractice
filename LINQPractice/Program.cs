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
        }
    }
}
