using System;
using System.Collections.Generic;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEnd = false, isCorrect = false;
            List<double> arr = new List<double>();
            int i = 0, count = 0; ;
            double number;

            while(isEnd == false)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number)){
                    arr.Add(Convert.ToDouble(input));
                    i++;
                    count += 1;
                }
                else if(input == "End")
                {
                    isEnd = true;
                }
            }

            while(isCorrect == false)
            {
                string input = Console.ReadLine();
                if(input == "FindMax")
                {
                    double max = 0;
                    for(int j = 0; j < count; j++)
                    {
                        if(arr[j] > max)
                        {
                            max = arr[j];
                        }
                    }
                    Console.WriteLine(max);
                    isCorrect = true;
                }
                else if(input == "FindMin")
                {
                    double min = arr[0];
                    for (int j = 0; j < count; j++)
                    {
                        if (arr[j] < min)
                        {
                            min = arr[j];
                        }
                    }
                    Console.WriteLine(min);
                    isCorrect = true;
                }
                else if (input == "FindMean")
                {
                    double sum = 0, avr;
                    for (int j = 0; j < count; j++)
                    {
                        sum += arr[j];
                    }
                    avr = sum / count;
                    Console.WriteLine(avr);
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Invalid Mode.");
                }
            }
        }
    }
}
