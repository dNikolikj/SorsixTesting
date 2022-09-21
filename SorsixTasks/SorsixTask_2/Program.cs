using SorsixTask_2.SecondTaskHelpers;
using System;

namespace MaxMinAlteredNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            SecondTaskHelper.FindTheMinimumAndTheMaximumNumber(int.Parse(input));
        }



    }
}
