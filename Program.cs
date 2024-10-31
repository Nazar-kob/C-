// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp1

{
    class Program
    {
        static void Main()
        {


            int stringLength = Int32.TryParse(Console.ReadLine(), out stringLength) ? stringLength : 0;

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            result["even"] = new List<string>();
            result["odd"] = new List<string>();


            for (int i = 0; i < stringLength; i++)
            {
                if (i % 2 == 0)
                {
                    result["even"].Add(i.ToString());
                }
                else
                {
                    result["odd"].Add(i.ToString());
                }
            }

            int evenCount = result["even"].Count;
            int oddCount = result["odd"].Count;

            // Console.WriteLine("Even numbers count: " + evenCount);
            // Console.WriteLine("Odd numbers count: " + oddCount);


            int[] evenNumbers = result["even"].ConvertAll(int.Parse).ToArray();
            int[] oddNumbers = result["odd"].ConvertAll(int.Parse).ToArray();

            // Console.WriteLine("Even numbers len: " + evenNumbers.Length);
            // Console.WriteLine("Odd numbers len: " + oddNumbers.Length);


        }
    }
}

