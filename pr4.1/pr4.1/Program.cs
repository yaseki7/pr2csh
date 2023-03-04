using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rim = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
            string input = "XXVI";
            int output = 0;
            for (int i = 0; i < input.Length; i++) {
                if (i == input.Length - 1)
                {
                    output += rim[input[i]];
                }
                else if (rim[input[i]] < rim[input[i + 1]])
                {
                    output += rim[input[i + 1]] - rim[input[i]];
                    i++;
                }
                else {
                    output += rim[input[i]];
                }

            }

            Console.WriteLine(output);

        }
    }
}