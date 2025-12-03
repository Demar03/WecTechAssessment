using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WecTechnicalAssessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var obj = new Program();

            //string fizBuzz= obj.MakeFizBuzz(9);
            Console.WriteLine(obj.MakeFizBuzz(20));

            var rules = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" },
    { 7, "Bar" }
};

            Console.WriteLine(obj.MakeCustomFizzBuzz(30, rules));

        }

        public string MakeFizBuzz(int input)
        {
            var sb = new StringBuilder();
            bool isFizzBuzz = false;
            for (int i = 1; i <= input; i++)
            {
                isFizzBuzz = (i % 3 == 0 && i % 5 == 0);

                if (isFizzBuzz)
                {
                    sb.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    sb.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    sb.AppendLine("Buzz");
                }
                else
                {
                    sb.AppendLine(i.ToString());
                }
                isFizzBuzz = false;
            }

            return sb.ToString();
        }

        public string MakeCustomFizzBuzz(int input, Dictionary<int, string> rules)
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= input; i++)
            {
                string output = "";

                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        output += rule.Value;
                    }
                }

                if (string.IsNullOrEmpty(output))
                    output = i.ToString();

                sb.AppendLine(output);
            }

            return sb.ToString();
        }

        public List<long> GenerateFibonacci(int limit)
        {
            List<long> result = new List<long>();

            long a = 0, b = 1;

            while (a <= limit)
            {
                result.Add(a);
                long next = a + b;
                a = b;
                b = next;
            }

            return result;
        }

        public List<string> FizzBuzzFibonacci(long limit)
        {
            List<string> result = new List<string>();

            long a = 0, b = 1;

            while (a <= limit)
            {
                string output = "";

                if (a % 3 == 0 && a % 5 == 0 && a != 0)
                    output = "FizzBuzz";
                else if (a % 3 == 0 && a != 0)
                    output = "Fizz";
                else if (a % 5 == 0 && a != 0)
                    output = "Buzz";
                else
                    output = a.ToString();

                result.Add(output);

                long next = a + b;
                a = b;
                b = next;
            }

            return result;
        }


    }
}