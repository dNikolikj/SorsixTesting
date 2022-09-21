using System;

namespace SorsixTask_2.SecondTaskHelpers
{
    public static  class SecondTaskHelper
    {
        public static string FindTheMinimumAndTheMaximumNumber(int input)
        {
            if (input.ToString().StartsWith("0"))
            {
                return "The number cannot be 0 or negative!";
            }

            int maxNumber = 0;
            int minNumber = 0;

            string numbers = input.ToString();
            int maxNumberDigit = 0;
            int minNumberDigit = 10;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i].ToString()) > maxNumberDigit)
                {
                    maxNumberDigit = int.Parse(numbers[i].ToString());
                }
                if (int.Parse(numbers[i].ToString()) < minNumberDigit)
                {
                    minNumberDigit = int.Parse(numbers[i].ToString());
                }
            }

            if (!(int.Parse(numbers.ToCharArray()[0].ToString()) == maxNumberDigit))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (int.Parse(numbers[i].ToString()) == maxNumberDigit)
                    {
                        maxNumber = int.Parse(Switch(numbers, i, 0));
                    }
                }
            }
            else maxNumber = input;


            if (!(int.Parse(numbers.ToCharArray()[0].ToString()) == minNumberDigit))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (int.Parse(numbers[i].ToString()) == minNumberDigit)
                    {
                        minNumber = int.Parse(Switch(numbers, i, 0));
                    }
                }
            }
            else minNumber = input;

            Console.WriteLine(maxNumber);
            return $"The minimum number is :{minNumber}, while the maximum number of the given input is {maxNumber}.";
        }

        public static string Switch(string input, int x, int y)
        {
            char[] chars = input.ToCharArray();

            char tempChar = input[x];

            chars[x] = input[y];
            chars[y] = tempChar;

            return String.Join("", chars);
        }
    }
}
