using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectStringsNamespace
{
    public class CorrectStrings
    {
        public static string ReadInput()
        {
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string inputLine = ReadInput();
            IsStringCorrect(inputLine);

        }

        public static string IsStringCorrect(string inputLine)
        {
            string trimmedInput = inputLine.Trim();

            Dictionary<char, int> dictionary = ListOfKeysFromDictionary(trimmedInput);

            for (int i = 0; i < trimmedInput.Length; i++)
            {
                if (dictionary.ContainsKey(trimmedInput[i]))
                {
                    dictionary[trimmedInput[i]]++;
                }
            }

            if (dictionary.Values.Distinct().Count() == 1)
            {

                return "Correct string!";
            }
            else if (dictionary.Values.Distinct().Count() == 2)
            {
                int checkHelper = dictionary.Values.Distinct().OrderBy(x => x).First();
                if (checkHelper == 1 && dictionary.Select(x => x.Value == 1).ToList().Count == 1)
                {

                    return "Correct string!";
                }
                else if (dictionary.Values.Distinct().OrderByDescending(x => x).First() == (dictionary.Values.Distinct().OrderByDescending(x => x).Last() + 1))
                {

                    return "Correct string!";
                }
                else
                {

                    return "Wrong string!";
                }
            }

            Console.WriteLine("Wrong string!");
            return "Wrong string!";

        }

        public static Dictionary<char, int> ListOfKeysFromDictionary(string input)
        {
            string distincInput = string.Join("", input.ToCharArray().Distinct());

            Dictionary<char, int> keysResult = new Dictionary<char, int>();
            foreach (var item in distincInput)
            {
                keysResult[item] = 0;
            }

            return keysResult;
        }
    }
}