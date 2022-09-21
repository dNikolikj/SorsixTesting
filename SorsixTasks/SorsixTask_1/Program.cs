using SorsixTesting.Helper.FirstTaskHelpers;
using System;

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
            FistTaskHelper.IsStringCorrect(inputLine);

        }


    }
}