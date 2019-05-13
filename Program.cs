using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamba
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAMBDA
            //#1
            Func<string> greet = () => "This is an example string: 'Hello World!'";
            Console.WriteLine(greet());

            //#2
            Console.WriteLine();
            Func<int, int> add = x => x + 1;
            Console.Write("This is the result when you have one input '3' and then add '1': ");
            Console.WriteLine(add(3));

            //#3
            Console.WriteLine();
            Func<int, int, int> squareTwoNumbers = (ns, nd) => (int)Math.Pow(nd, ns);
            var numbers = (2, 5);
            var squareThem = squareTwoNumbers(2, 5);
            Console.WriteLine($"Take the example set of {numbers}. When you take the second number to the power of the first it becomes: {squareThem}");

            //#4
            Console.WriteLine();
            Func<int, int, int> addTwoNumbers = (ab, ac) => ab + ac;
            var numbers1 = ("4 & 6");
            var addNumbers = addTwoNumbers(4, 6);
            Console.WriteLine($"The two numbers are {numbers1}. When you add them together it becomes {addNumbers}.");

            //#5
            Console.WriteLine();
            Func<string, string, string> append = (q, w) => w + q;            
            string firstString = " This is the first string attached after the second.";
            string secondString = "This is the second string parameter.";
            var MainString = append(firstString, secondString);
            Console.WriteLine(MainString);

            //LINQ
            IList<int> numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //#1
            Console.WriteLine();
            int start = 0;
            Console.WriteLine("This is where you add 1 to each number in the list: ");
            foreach (var num in numList)
            {
                
                Console.WriteLine(add(numList[start]));
                start++;
            }

            //#2
            Console.WriteLine();
            int start1 = 0;
            Console.WriteLine("These are the squared values of the numbers:");
            foreach (var num in numList)
            {
                Console.WriteLine($"{squareTwoNumbers(2, (numList[start1]))}");
                start1++;
            }

            //#3
            Console.WriteLine();
            Console.Write("The sum of the list is: ");
            Console.WriteLine(numList.Aggregate((x, next) => addTwoNumbers(x, next)));


            //#4
            IList<string> stringList = new List<string>()
            {
                "Year,  ", "Month, ", "Day, ",
                "Hour, ", "Minute, ", "Second, "
            };
            Console.WriteLine();
            string stringProblem = stringList.Aggregate((result, next) => append(result, next));
            Console.WriteLine(stringProblem);

            //#5
            Console.WriteLine();
            List<int> listGenerated = Enumerable.Repeat(2, 4).ToList();
            Console.WriteLine(listGenerated.Aggregate((result, next) => squareTwoNumbers(result, next)));


        }
    }
}
